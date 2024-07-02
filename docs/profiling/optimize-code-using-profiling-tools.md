---
title: "Beginner's guide to optimizing code"
description: "Learn how to optimize code and reduce compute costs using Visual Studio profiling tools such as the CPU Usage tool, the .NET Object Allocation tool, and the Database tool."
ms.date: 07/01/2024
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "optimize code, profiling tools"
  - "profiling tools, optimize code"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---
# Beginner's guide to optimizing code and reducing compute costs (C#, Visual Basic, C++, F#)

Reducing your compute time means reducing costs, so optimizing your code can save money. In this case study, we show how you can use profiling tools to help you accomplish this task.  

Our goal is to equip developers with the knowledge to:

- Understand the importance of code optimization and its impact on reducing compute costs.
- Utilize Visual Studio profiling tools to analyze application performance.
- Interpret the data provided by these tools to identify performance bottlenecks.
- Apply practical strategies to optimize code, focusing on CPU usage, memory allocation, and database interactions.

By the end of this guide, readers should be able to apply these techniques to their own projects, leading to more efficient and cost-effective applications.

## Optimization case study

The sample application discussed in this case study is a .NET application designed to run queries against a database of blogs and associated blog posts. It utilizes the Entity Framework, a popular ORM (Object-Relational Mapping) for .NET, to interact with a SQLite local database. The application is structured to execute a large number of queries, simulating a real-world scenario where a .NET application might be required to handle extensive data retrieval tasks. The sample application is a modified version of the [Entity Framework sample](/ef/core/querying/).

The primary performance issue with the sample application lies in how it manages compute resources and interacts with the database. The application suffers from a common performance bottleneck that significantly impacts its efficiency and, consequently, the compute costs associated with running it. The problem includes the following symptoms:

- **High CPU Usage**: Applications may perform inefficient computations or processing tasks in a way that unnecessarily consumes a large amount of CPU resources. This can lead to slow response times and increased operational costs.

- **Inefficient Memory Allocation**: Applications can sometimes face issues related to memory usage and allocation. In .NET apps, inefficient memory management can lead to increased garbage collection, which in turn can affect application performance.

- **Database Interaction Overheads**: Applications that execute a large number of queries against a database can experience bottlenecks related to database interactions. This includes inefficient queries, excessive database calls, and poor use of Entity Framework capabilities, all of which can degrade performance.

The case study aims to address these issues by employing Visual Studio's profiling tools to analyze the application's performance. By understanding where and how the application's performance can be improved, developers can implement optimizations to reduce CPU usage, improve memory allocation efficiency, streamline database interactions, and optimize resource utilization. The ultimate goal is to enhance the application's overall performance, making it more efficient and cost-effective to run.

## Challenge

Addressing the performance issues in the sample .NET application presents several challenges. These challenges stem from the complexity of diagnosing performance bottlenecks. The key challenges in fixing the problems described are as follows:

- **Diagnosing Performance Bottlenecks**: One of the primary challenges is accurately identifying the root causes of the performance issues. High CPU usage, inefficient memory allocation, and database interaction overheads can have multiple contributing factors. Developers must use profiling tools effectively to diagnose these issues, which requires some understanding of how these tools work and how to interpret their output.

- **Knowledge and Resource Constraints**: Finally, teams may face constraints related to knowledge, expertise, and resources. Profiling and optimizing an application requires specific skills and experience, and not all teams may have immediate access to these resources.

Addressing these challenges requires a strategic approach that combines effective use of profiling tools, technical knowledge, and careful planning and testing. The case study aims to guide developers through this process, providing strategies and insights to overcome these challenges and improve the application's performance.

## Strategy

Here is a high-level view of the approach:

- We start the investigation by taking a CPU usage trace. Visual Studio's [CPU Usage tool](../profiling/cpu-usage.md) is often helpful to begin performance investigations and to optimize code to reduce cost.
- Next, to get additional insights to help isolate issues or improve the performance, we collect a trace using one of the other profiling tools. For example:
  - We take a look at the memory usage. For .NET, we try the [.NET Object Allocation tool](../profiling/dotnet-alloc-tool.md) first. (For either .NET or C++, you can look at the Memory Usage tool instead.)
  - For ADO.NET or Entity Framework, we can use the [Database tool](../profiling/analyze-database.md) to examine SQL queries, precise query time, and more.

Data collection requires the following steps:

- We set the app to a Release build.
- We select the CPU Usage tool from the Performance Profiler (**Alt+F2**). (Later steps involve a few of the other tools.)
- From the Performance Profiler, we start the app and collect a trace.

### Inspect areas of high CPU usage

After collecting a trace with the CPU Usage tool and loading it into Visual Studio, we first check the initial *.diagsession* report page that shows Top Insights and the Hot Path. The Hot Path shows the code path with highest CPU usage in the app. These sections may provide tips to help us quickly identify performance issues that we can improve.

We can also view the hot path in the **Call Tree** view. To open this view, use the **Open details** link in the report and then select **Call Tree**.

In this view, we see the hot path again, which shows high CPU usage for the `GetBlogTitleX` method in the app, using about a 60% share of the app's CPU usage. However, the **Self CPU** value for `GetBlogTitleX` is low, only about .10%. Unlike **Total CPU**, the **Self CPU** value excludes time spent in other functions, so we know to look farther down the Call Tree view for the real bottleneck.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree.png" alt-text="Screenshot of Call Tree view in the CPU Usage tool.":::

`GetBlogTitleX` makes external calls to two LINQ DLLs, which are using most of the CPU time, as evidenced by the very high **Self CPU** values. This is the first clue that we may want to look for a LINQ query as an area to optimize.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-self-cpu.png" alt-text="Screenshot of Call Tree view in the CPU Usage tool with Self CPU highlighted." lightbox="./media/optimize-code-cpu-usage-call-tree-self-cpu.png":::

To get a visualized call tree and a different view of the data, we right-click `GetBlogTitleX` and choose **View in Flame Graph**. Here again, it looks like the `GetBlogTitleX` method is responsible for a lot of the app's CPU usage (shown in yellow). External calls to the LINQ DLLs show up beneath the `GetBlogTitleX` box, and they are using all of the CPU time for the method.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph.png" alt-text="Screenshot of Flame Graph view in the CPU Usage tool.":::

### Gather additional data

Often, other tools can provide additional information to help the analysis and isolate the problem. For this example, we take the following approach:

- First, we take a look at memory usage. There might be a correlation between high CPU usage and high memory usage, so it can be helpful to look at both to isolate the issue.
- Because we identified the LINQ DLLs, we'll also look at the Database tool.

#### Check the memory usage

To see what's going on with the app in terms of memory usage, we collect a trace using the .NET Object Allocation tool (For C++, you can use the Memory Usage tool instead). The **Call Tree** view in the memory trace shows the hot path and helps us identify an area of high memory usage. No surprise at this point, the `GetBlogTitleX` method appears to be generating a lot of objects! Over 900,000 object allocations, in fact.

:::image type="content" source="./media/optimize-code-dotnet-object-allocations.png" alt-text="Screenshot of Call Tree view in the .NET Object Allocation tool.":::

Most of the objects created are strings, object arrays, and Int32s. We may be able to see how these types are generated by examining the source code.

#### Check the query in the Database tool

In the Performance Profiler, we select the Database tool instead of CPU Usage (or, we can select both). When we've collected a trace, select the **Queries** tab in the diagnostics page. In the Queries tab for the Database trace, we can see the first row shows the longest query, 2446 ms. The **Records** column shows how many records the query reads. We can use this information for later comparison.

:::image type="content" source="./media/optimize-code-database.png" alt-text="Screenshot of Database queries in the Database tool.":::

By examining the `SELECT` statement generated by LINQ in the Query column, we identify the first row as the query associated with the `GetBlogTitleX` method. To view the full query string, we expand the column width. The full query string is:

```sql
SELECT "b"."Url", "b"."BlogId", "p"."PostId", "p"."Author", "p"."BlogId", "p"."Content", "p"."Date", "p"."MetaData", "p"."Title"
FROM "Blogs" AS "b" LEFT JOIN "Posts" AS "p" ON "b"."BlogId" = "p"."BlogId" ORDER BY "b"."BlogId"
```

Notice that we are retrieving a lot of column values here, perhaps more than we need. Let's look at the source code.

### Optimize code

It's time to take a look at the `GetBlogTitleX` source code. In the Database tool, we right-click the query and choose **Go to Source File**. In the source code for `GetBlogTitleX`, we find the following code that uses LINQ to read the database.

```csharp
foreach (var blog in db.Blogs.Select(b => new { b.Url, b.Posts }).ToList())
  {
    foreach (var post in blog.Posts)
    {
      if (post.Author == "Fred Smith")
      {
        Console.WriteLine($"Post: {post.Title}");
      }
  }
}
```

This code uses `foreach` loops to search the database for any blogs with "Fred Smith" as the author. Looking at it, we can see that a lot of objects are getting generated in memory: a new object array for each blog in the database, associated strings for each URL, and values for properties contained in the posts, such as blog ID.

We do a little research and find some common recommendations for how to optimize LINQ queries and come up with this code.

```csharp
foreach (var x in db.Posts.Where(p => p.Author.Contains("Fred Smith")).Select(b => b.Title).ToList())
{
  Console.WriteLine("Post: " + x);
}
```

In this code, we made several changes to help optimize the query:

- Added the `Where` clause and eliminate one of the `foreach` loops.
- Projected only the Title property in the `Select` statement, which is all we need in this example.

Next, we retest using the profiling tools.

## Results

After updating the code, we re-run the CPU Usage tool to collect a trace. The **Call Tree** view shows that `GetBlogTitleX` is running only 1754 ms, using 37% of the app's CPU total, a significant improvement from 59%.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-fixed.png" alt-text="Screenshot of improved CPU usage in the Call Tree view of the CPU Usage tool.":::

We switch to the **Flame Graph** view to see another visualization of the improvement. In this view, `GetBlogTitleX` also uses a smaller portion of the CPU.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph-fixed.png" alt-text="Screenshot of improved CPU usage in the Flame Graph view of the CPU Usage tool.":::

We check the results in the Database tool trace, and only two records are read using this query, instead of 100,000! Also, the query is much simplified and eliminates the unnecessary LEFT JOIN that was generated previously.

:::image type="content" source="./media/optimize-code-database-fixed.png" alt-text="Screenshot of faster query time in the Database tool.":::

Next, we recheck the results in the .NET Object Allocation tool, and see that `GetBlogTitleX` is only responsible for 56,000 object allocations, nearly a 95% reduction from 900,000!

:::image type="content" source="./media/optimize-code-dotnet-object-allocations-fixed.png" alt-text="Screenshot of reduced memory allocations in the .NET Object Allocation tool.":::

## Iterate

Multiple optimizations may be necessary and we can continue to iterate with code changes to see which changes improve performance and reduce our compute cost.

## Next steps

The following articles and blog posts provide more information to help you learn to use the Visual Studio performance tools effectively.

- [Isolate a performance issue](../profiling/isolate-performance-issue.md)
- [Case Study: Double performance in under 30 minutes](https://devblogs.microsoft.com/visualstudio/case-study-double-performance-in-under-30-minutes/)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/)

## Related content

- [Which tool should I use?](../profiling/choose-performance-tool.md)
- [Analyze CPU usage in the Performance Profiler](../profiling/cpu-usage.md)
- [Choose a memory analysis tool](../profiling/analyze-memory-usage.md)
- [Analyze database performance](../profiling/analyze-database.md)
- [First look at profiling](../profiling/choose-performance-tool.md)
