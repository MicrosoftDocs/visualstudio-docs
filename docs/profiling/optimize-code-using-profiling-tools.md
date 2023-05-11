---
title: "Reduce compute costs using profiling tools"
description: "Learn how to optimize code using profiling tools such as the CPU Usage tool, Database tool, and the .NET Object Allocation tool."
ms.date: 05/09/2023
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "optimize code, profiling tools"
  - "profiling tools, optimize code"
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2022'
ms.workload:
  - "multiple"
---
# Reduce compute costs by using profiling tools to optimize code (C#, Visual Basic, C++, F#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Reducing your compute time means reducing costs, so optimizing your code can save money. The CPU Usage tool can help you capture and visualize where compute resources are used in your application. The CPU Usage views such as the call tree and flame chart provide a nice graphical visualization of where time is spent in your app. In addition, auto insights may show precise optimizations that can have a large impact. Other profiling tools may also be used to give additional insights about what's happening with your app's performance.

## Start an investigation

- To reduce compute costs, start your investigation by taking a CPU usage trace. The CPU Usage tool is often helpful to begin performance investigations and to optimize code to reduce cost.
- If you would like additional insights to help isolate issues or improve the performance, considering collecting a trace using one of the other profiling tools. For example:
  - Take a look at the memory usage. For .NET, try the .NET Object Allocation tool first. For either .NET or C++, you can look at the Memory Usage tool.
  - If you app is using File I/O, use the File I/O tool.
  - If you're using ADO.NET or Entity Framework, you can try the Database tool to examine SQL queries, precise query time, et al.
  - For additional tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md).

## Example

The example screenshots shown in this article are based on a .NET app that runs queries against a database of blogs and associated blog posts. You will first examine a CPU usage trace to look for opportunities to optimize and reduce compute cost. You will also look at traces from other profiling tools to help isolate issues.

To collect the data shown in this article:

- Set your app to a Release build
- Select the CPU Usage tool from the Performance Profiler (**Alt+F2**). (Later steps involves a few of the other tools.)
- From the Performance Profiler, start the app and collect a trace.

## Inspect areas of high CPU usage

Start by collecting a trace with the CPU Usage tool. When the diagnostic data loads, first check the initial *.diagsession* report page that shows Top Insights and the Hot Path. The Hot Path shows the code path with highest CPU usage in your app. These sections may provide tips to help you quickly identify performance issues that you can improve.

You can also view the hot path in the **Call tree** view. To open this view, use the **Open details** link in the report and then select **Call tree**.

In this view, you see the hot path again, which shows high CPU usage for the `GetBlogTitleX` method in the app, using about a 60% share of the app's CPU usage. Two external calls to LINQ DLLs are using most of the CPU time. This is the first clue that you may want to look for a LINQ query as an area to optimize.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree.png" alt-text="Screenshot of Call Tree view in the CPU Usage tool.":::

To get a visualized call tree and a different view of the data, switch to the **Flame Graph** view (select from the same list as the **Call tree**). Here again, it looks like the `GetBlogTitleX` method is responsible for a lot of the app's CPU usage. External calls to the LINQ DLLs show up beneath the `GetBlogTitleX` box, and they are using all of the CPU time for the method.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph.png" alt-text="Screenshot of Flame Graph view in the CPU Usage tool.":::

## Gather additional data

If the CPU Usage tool does not provide enough information to isolate the problem, or you would like additional insights to help improve the performance, you may decide to use one of the other profiling tools. For example:

- If you're using ADO.NET or Entity Framework (as in this example), you can try the Database tool to examine SQL queries, precise query time, et al.
- Take a look at the memory usage. For .NET, try the .NET Object Allocation tool first. For either .NET or C++, you can look at the Memory Usage tool.
- For additional tools such as File I/O, see [Which tool should I choose?](../profiling/choose-performance-tool.md).

As previously described, the `GetBlogTitleX` method uses a LINQ query that could perhaps be optimized. For another view of the query, use the Database tool in the Performance Profiler (**Atl+F2**). You can multi-select this tool along with CPU Usage. When you've collected a trace, select the **Query** tab in the diagnostics page.

In the Query tab for the Database trace, you can see the first row shows the longest query, 2446 ms. By examining the SELECT statement generated by LINQ, you identify the first row as the query associated with the `GetBlogTitleX` method. The **Records** column shows how many records the query reads. We can use this information for later comparison.

:::image type="content" source="./media/optimize-code-database.png" alt-text="Screenshot of Database queries in the Database tool.":::

Next, use the .NET Object Allocation tool to see what's going on in with the memory usage. The **Call Tree** view in the memory trace shows the hot path and helps you identify an area of high memory usage. No surprise at this point, the GetBlogTitleX method appears to be generating a lot of objects! Over 900,000 object allocations, in fact.

:::image type="content" source="./media/optimize-code-dotnet-object-allocations.png" alt-text="Screenshot of Call Tree view in the .NET Object Allocation tool.":::

Most of the objects created are strings, object arrays, and Int32's.

## Optimize code

It's time to take a look at the `GetBlogTitleX` source code. Double-click the function in the Flame Graph. In the source code for `GetBlogTitleX`, we find the following code using a LINQ query.

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

This code uses foreach loops to search the database for any blogs with "Fred Smith" as the author. Looking at it, you can see that a lot of objects are getting generated in memory, a new object array for each blog in the database, associated strings for each URL, and values for properties contained in the posts, such as blog ID.

You investigate and find some common recommendations how to optimize LINQ queries and come up with this code.

```csharp
foreach (var x in db.Posts.Where(p => p.Author.Contains("Fred Smith")).Select(b => b.Title).ToList())
{
  Console.WriteLine("Post: " + x);
}
```

You make several changes to help optimize the query in this code, especially by adding the Where clause.

Next, retest using the profiling tools.

## Check the results

After updating the code, re-run the CPU Usage tool to collect a trace. The **Call Tree** view shows that `GetBlogTitleX` is running only 1754 ms, using 37% of the app's CPU total, a significant improvement from 59%.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-fixed.png" alt-text="Screenshot of improved CPU usage in the Call Tree view of the CPU Usage tool.":::

Switch to the **Flame Graph** view to see another visualization of the improvement. In this view, `GetBlogTitleX` also uses a smaller portion of the CPU.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph-fixed.png" alt-text="Screenshot of improved CPU usage in the Flame Graph view of the CPU Usage tool.":::

Check the results in the Database tool trace, and only two records are read using this query, instead of 100,000!

:::image type="content" source="./media/optimize-code-database-fixed.png" alt-text="Screenshot of faster query time in the Database tool.":::

Next, recheck the results in the .NET Object Allocation tool, and see that `GetBlogTitleX` is only responsible for 56,000 object allocations, nearly a 95% reduction from 900,000!

:::image type="content" source="./media/optimize-code-dotnet-object-allocations-fixed.png" alt-text="Screenshot of reduced memory allocations in the .NET Object Allocation tool.":::

## Iterate

Often, multiple optimizations are possible and you can continue to iterate with code changes to see which changes improve performance and reduce your compute cost.

