---
title: "Beginner's guide to optimizing code"
description: "Learn how to optimize code and reduce compute costs using Visual Studio profiling tools such as the CPU Usage tool, the .NET Object Allocation tool, and the Database tool."
ms.date: 04/17/2024
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

Reducing your compute time means reducing costs, so optimizing your code can save money. In this article, you'll learn how you can use various profiling tools to help you accomplish this task.

Rather than providing step-by-step instructions, the intent here is to show you how to use the profiling tools effectively and how to interpret the data. The CPU Usage tool can help you capture and visualize where compute resources are used in your application. The CPU Usage views such as the call tree and flame graph provide a nice graphical visualization of where time is spent in your app. In addition, auto insights may show precise optimizations that can have a large impact. Other profiling tools can also help you isolate issues. To compare tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md)

## About the example app

The screenshots in this article are based on a .NET app that runs queries against a database of blogs and associated blog posts. It is based on the [Entity Framework sample](/ef/core/querying/), but modified to run a large number of queries against an SQLite local database.

## Start an investigation

- Start your investigation by taking a CPU usage trace. The CPU Usage tool is often helpful to begin performance investigations and to optimize code to reduce cost.
- Next, if you would like additional insights to help isolate issues or improve the performance, considering collecting a trace using one of the other profiling tools. For example:
  - Take a look at the memory usage. For .NET, try the .NET Object Allocation tool first. For either .NET or C++, you can look at the Memory Usage tool.
  - If your app is using File I/O, use the File I/O tool.
  - If you're using ADO.NET or Entity Framework, you can use the Database tool to examine SQL queries, precise query time, et al.

Data collection requires the following steps (not shown in this article):

- Set your app to a Release build.
- Select the CPU Usage tool from the Performance Profiler (**Alt+F2**). (Later steps involve a few of the other tools.)
- From the Performance Profiler, start the app and collect a trace.

## Inspect areas of high CPU usage

Start by collecting a trace with the CPU Usage tool. When the diagnostic data loads, first check the initial *.diagsession* report page that shows Top Insights and the Hot Path. The Hot Path shows the code path with highest CPU usage in your app. These sections may provide tips to help you quickly identify performance issues that you can improve.

You can also view the hot path in the **Call Tree** view. To open this view, use the **Open details** link in the report and then select **Call Tree**.

In this view, you see the hot path again, which shows high CPU usage for the `GetBlogTitleX` method in the app, using about a 60% share of the app's CPU usage. However, the **Self CPU** value for `GetBlogTitleX` is low, only about .10%. Unlike **Total CPU**, the **Self CPU** value excludes time spent in other functions, so we know to look farther down the Call Tree view for the real bottleneck.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree.png" alt-text="Screenshot of Call Tree view in the CPU Usage tool.":::

`GetBlogTitleX` makes external calls to two LINQ DLLs, which are using most of the CPU time, as evidenced by the very high **Self CPU** values. This is the first clue that you may want to look for a LINQ query as an area to optimize.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-self-cpu.png" alt-text="Screenshot of Call Tree view in the CPU Usage tool with Self CPU highlighted." lightbox="./media/optimize-code-cpu-usage-call-tree-self-cpu.png":::

To get a visualized call tree and a different view of the data, right-click `GetBlogTitleX` and choose **View in Flame Graph**. Here again, it looks like the `GetBlogTitleX` method is responsible for a lot of the app's CPU usage (shown in yellow). External calls to the LINQ DLLs show up beneath the `GetBlogTitleX` box, and they are using all of the CPU time for the method.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph.png" alt-text="Screenshot of Flame Graph view in the CPU Usage tool.":::

## Gather additional data

Often, other tools can provide additional information to help the analysis and isolate the problem. For this example, take the following approach:

- First, take a look at memory usage. There might be a correlation between high CPU usage and high memory usage, so it can be helpful to look at both to isolate the issue.
- Because we identified the LINQ DLLs, we'll also look at the Database tool.

### Check the memory usage

To see what's going on with the app in terms of memory usage, collect a trace using the .NET Object Allocation tool (For C++, use the Memory Usage tool instead). The **Call Tree** view in the memory trace shows the hot path and helps you identify an area of high memory usage. No surprise at this point, the `GetBlogTitleX` method appears to be generating a lot of objects! Over 900,000 object allocations, in fact.

:::image type="content" source="./media/optimize-code-dotnet-object-allocations.png" alt-text="Screenshot of Call Tree view in the .NET Object Allocation tool.":::

Most of the objects created are strings, object arrays, and Int32s. You may be able to see how these types are generated by examining the source code.

### Check the query in the Database tool

In the Performance Profiler, select the Database tool instead of CPU Usage (or, you can select both). When you've collected a trace, select the **Queries** tab in the diagnostics page. In the Queries tab for the Database trace, you can see the first row shows the longest query, 2446 ms. The **Records** column shows how many records the query reads. You can use this information for later comparison.

:::image type="content" source="./media/optimize-code-database.png" alt-text="Screenshot of Database queries in the Database tool.":::

By examining the `SELECT` statement generated by LINQ in the Query column, you identify the first row as the query associated with the `GetBlogTitleX` method. To view the full query string, expand the column width if you need to. The full query string is:

```sql
SELECT "b"."Url", "b"."BlogId", "p"."PostId", "p"."Author", "p"."BlogId", "p"."Content", "p"."Date", "p"."MetaData", "p"."Title"
FROM "Blogs" AS "b" LEFT JOIN "Posts" AS "p" ON "b"."BlogId" = "p"."BlogId" ORDER BY "b"."BlogId"
```

Notice that you are retrieving a lot of column values here, perhaps more than you need. Let's look at the source code.

## Optimize code

It's time to take a look at the `GetBlogTitleX` source code. In the Database tool, right-click the query and choose **Go to Source File**. In the source code for `GetBlogTitleX`, you find the following code that uses LINQ to read the database.

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

This code uses `foreach` loops to search the database for any blogs with "Fred Smith" as the author. Looking at it, you can see that a lot of objects are getting generated in memory: a new object array for each blog in the database, associated strings for each URL, and values for properties contained in the posts, such as blog ID.

You do a little research and find some common recommendations for how to optimize LINQ queries and come up with this code.

```csharp
foreach (var x in db.Posts.Where(p => p.Author.Contains("Fred Smith")).Select(b => b.Title).ToList())
{
  Console.WriteLine("Post: " + x);
}
```

In this code, you made several changes to help optimize the query:

- Added the `Where` clause and eliminate one of the `foreach` loops.
- Projected only the Title property in the `Select` statement, which is all you need in this example.

Next, retest using the profiling tools.

## Check the results

After updating the code, re-run the CPU Usage tool to collect a trace. The **Call Tree** view shows that `GetBlogTitleX` is running only 1754 ms, using 37% of the app's CPU total, a significant improvement from 59%.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-fixed.png" alt-text="Screenshot of improved CPU usage in the Call Tree view of the CPU Usage tool.":::

Switch to the **Flame Graph** view to see another visualization of the improvement. In this view, `GetBlogTitleX` also uses a smaller portion of the CPU.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph-fixed.png" alt-text="Screenshot of improved CPU usage in the Flame Graph view of the CPU Usage tool.":::

Check the results in the Database tool trace, and only two records are read using this query, instead of 100,000! Also, the query is much simplified and eliminates the unnecessary LEFT JOIN that was generated previously.

:::image type="content" source="./media/optimize-code-database-fixed.png" alt-text="Screenshot of faster query time in the Database tool.":::

Next, recheck the results in the .NET Object Allocation tool, and see that `GetBlogTitleX` is only responsible for 56,000 object allocations, nearly a 95% reduction from 900,000!

:::image type="content" source="./media/optimize-code-dotnet-object-allocations-fixed.png" alt-text="Screenshot of reduced memory allocations in the .NET Object Allocation tool.":::

## Iterate

Multiple optimizations may be necessary and you can continue to iterate with code changes to see which changes improve performance and reduce your compute cost.

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
