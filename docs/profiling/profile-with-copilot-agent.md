---
title: Profile with GitHub Copilot
description: Use the Copilot Profiling Agent to collect CPU and memory traces and get AI-driven performance insights and fixes.
ms.date: 8/22/2025
ms.update-cycle: 180-days
ms.topic: how-to
dev_langs:
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords:
  - profiler, Copilot
  - Copilot, profiling
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= visualstudio'
---

# Profile your app with GitHub Copilot in Visual Studio

In this article, you'll learn how to profile applications using the Copilot Profiling Agent. The agent collects CPU samples, allocation and heap information, and tracing data while your app runs, and then Copilot analyzes that data, adds benchmarks and retests using generated comparison code. Then Copilot suggests code changes to improve performance.

For general information about Copilot agents and agent mode, see [Use Copilot agent mode](../ide/copilot-agent-mode.md).

## Prerequisites

To get started, you need:

+ Visual Studio version 18.0.0 Preview 1 or later
+ [Sign in to Visual Studio using a GitHub account](../ide/work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)
+ [GitHub Copilot](../ide/visual-studio-github-copilot-install-and-states.md) and the Copilot Chat experience installed in Visual Studio

## Profile using the Copilot Profiling Agent

The following example shows how to collect performance data with the Copilot Profiling Agent and use Copilot to analyze the results and suggest fixes.

### Start a profiling session

1. In Visual Studio, create a new C# Console app.

   On the start window, choose **Create a new project**. Type **console** in the search box, select **C#** as the language, and then choose **Console App** for .NET. Choose **Next**. Type a project name like **ConsoleApp_CopilotProfile** and select **Next**. Choose a target framework (for example, .NET 8) and choose **Create**.

1. In Solution Explorer, right-click the **Dependencies** node in the project, choose **Manage NuGet packages**, and add the following packages to the project:

   - Microsoft.EntityFramework.Core
   - Microsoft.EntityFramework.Core.InMemory

1. Replace the code in *Program.cs* with the following code:

    ```csharp
    using System.Diagnostics;
    using Microsoft.EntityFrameworkCore;

    // Configure EF Core to use the InMemory provider
    var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase("PerfDemoDb")
        .Options;

    using var db = new AppDbContext(options);

    // Seed 100,000 records once
    if (!db.People.Any())
    {
        var rand = new Random(42);
        var cities = new[]
        {
            "Chicago", "Seattle", "Cairo", "London", "Paris",
            "Cleveland", "Calgary", "Dallas", "Berlin", "Copenhagen"
        };

        var people = Enumerable.Range(1, 100_000).Select(i => new Person
        {
            Name = $"Person {i}",
            Age = rand.Next(18, 80),
            City = cities[rand.Next(cities.Length)]
        });

        db.People.AddRange(people);
        db.SaveChanges();
    }

    Console.WriteLine($"Seeded records: {db.People.Count():N0}");

    // Inefficient LINQ pattern: materialize everything and repeatedly re-materialize + chain ToList
    // This simulates client-heavy work that doesn't scale, even with in-memory provider
    var sw = Stopwatch.StartNew();

    // Full materialization of all rows
    var all = db.People.ToList();

    // Extra ToList calls create multiple large intermediate lists
    var inefficient = all
        .Where(p => p.Age > 50)
        .ToList()
        .Where(p => p.City.StartsWith("C"))
        .ToList()
        .Select(p => p.Name)
        .Distinct()
        .OrderBy(n => n)
        .Take(10)
        .ToList();

    sw.Stop();
    Console.WriteLine($"Inefficient query returned {inefficient.Count} rows in {sw.ElapsedMilliseconds} ms");

    // EF Core entity
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string City { get; set; } = string.Empty;
    }

    // EF Core DbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Person> People => Set<Person>();
    }
    ```

1. 

### Ask Copilot for profiling insights

1. Open the Copilot Chat window, and use the following prompt.

   ```@Profiler Please evaluate the performance of this code```

   The `@Profiler` command calls the Copilot Profiling Agent. 

   ![Screenshot of start profiling request.](../debugger/media/vs/profiling-agent-start-chat.png)

   Copilot asks if you want to run the profiler.

   ![Screenshot of start profiling request.](../debugger/media/vs/profiling-agent-start-profiling-request.png)

1. Choose **Confirm**.

   The agent runs through a series of steps independently. It examines the code, adds support to the project for BenchmarkDotNet, including project references and packages, adds benchmarks to a new file, and runs comparison tests.

   Benchmark results show up in the Output window, with the output set to **Diagnostics Hub**.

   ![Screenshot of start profiling request.](../debugger/media/vs/profiling-agent-benchmark-output.png)

   When finished testing, the agent summarizes its finding and provides a couple of suggestions for next steps.

   The agent reports a potential 33% gain in efficiency, mainly by removing full-table materialization and an unnecessary ToList() method call.

   ![Screenshot of start profiling request.](../debugger/media/vs/profiling-agent-results.png)

   In this example, you are more interested in optimizing the LINQ query.

1. Select the second Copilot suggestion and select **Send** to tell the agent to optimize the LINQ query chain.

   The agent updates **Program.cs** and provides additional suggestions to optimize code. We will skip those suggestions to focus on the LINQ query.

1. Take a look at code changes in **Program.cs**.

   ![Screenshot of start profiling request.](../debugger/media/vs/profiling-agent-suggested-fixes.png) 

1. In the lower right of the code editor, examine the code changes and select **Keep** to keep them.

   The optimized query is shown here.

   ```csharp
    var optimized = db.People
        .AsNoTracking()
        .Where(p => p.Age > 50 && p.City.StartsWith("C"))
        .Select(p => p.Name)
        .Distinct()
        .OrderBy(n => n)
        .Take(10)
        .ToList();
   ```
