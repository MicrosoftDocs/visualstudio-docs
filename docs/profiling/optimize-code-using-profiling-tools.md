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

Start investigating where to focus your efforts by taking a CPU usage trace. The CPU Usage tool is often helpful to begin performance investigations and to optimize code to reduce cost.

## Example

The example screenshots shown in this article are based on a .NET app that runs queries against a database of blogs and associated blog posts. We will first examine a CPU usage trace to look for opportunities to optimize and reduce compute cost. We will use a few other profiling tools to help isolate issues.

To get the type of results shown in these examples:

- Set the app to a Release build
- Select the CPU Usage tool from the Performance Profiler (**Alt+F2**). (Later steps involves a few of the other tools.)
- From the Performance Profiler, start the app and collect a trace.

## Inspect areas of high CPU usage

Start by collecting a trace with the CPU Usage tool. When the diagnostic data loads, first check the initial *.diagsession* report page that shows Top Insights and the Hot Path. The Hot Path shows the code path with highest CPU usage in your app. These sections may provide tips to help you quickly identify performance issues that you can improve.

Next, use the **Open details** link in the report and then select **Call tree**.

In this view, you see the hot path again, which shows high CPU usage for the `GetBlogTitle` method in the app, using 82.57% share of the app's CPU usage. Two external calls to LINQ DLLs are using the bulk of the app's CPU usage. This is the first clue that you may want to look for a LINQ query as an area to optimize.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree.png" alt-text="Alt text that describes the content of the image.":::

For another visualization, switch to the **Flame Graph** view, in the same list as the **Call tree**. The Flame Graph shows a visualized call tree. Here again, it looks like the `GetBlogTitle` method is responsible for a lot of the app's CPU usage. External calls to the LINQ DLLs show up beneath the `GetBlogTitle` box, and they are using all of the CPU time for the method.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph.png" alt-text="Alt text that describes the content of the image.":::

It's time to take a look at the `GetBlogTitle` source code. Double-click the function in the Flame Graph. In the source code for `GetBlogTitle`, we find the following code using a LINQ query.

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

## Gather additional data

When you have explored areas of high CPU usage in the CPU Usage tool, you may want decide to use one of the other profiling tools for additional insights or to help identify the exact source of the problem. For example:

- If you're using ADO.NET or Entity Framework (as in this example), you can try the Database tool to examine SQL queries, precise query time, et al.
- Take a look at the memory usage. For .NET, try the .NET Object Allocation tool first. For any supported language, you can look at the Memory Usage tool.
- For additional tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md).

In this example, the `GetBlogTitle` method uses a LINQ query that looks like it could be optimized. Use the Database tool in the Performance Profiler (**Atl+F2**). You can multi-select this tool along with CPU Usage. When you've collected a trace, select the **Query** tab in the diagnostics page.

In the Query tab for the Database trace, you can see the first row shows the longest query, 2446 ms. By examining the SELECT statement generated by LINQ, you identify the first row as the query associated with the `GetBlogTitle` method. The **Records** 

:::image type="content" source="./media/optimize-code-database.png" alt-text="Alt text that describes the content of the image.":::

Next, use the .NET Object Allocation tool to see what's going on in with the memory usage. The **Call Tree** view in the memory trace shows the hot path and helps you identify an area of high memory usage. No surprise at this point, the GetBlogTitle method appears to be generating a lot of objects! Over 900,000 object allocations, in fact.

:::image type="content" source="./media/optimize-code-dotnet-object-allocations.png" alt-text="Alt text that describes the content of the image.":::

## Optimize code

## Check the results

After updating the code, re-run the CPU Usage tool to collect a trace. The **Call Tree** view shows that GetBlogTitle is running only 1754 ms, using 37% of the app's CPU total, a significant improvement from 59%.

:::image type="content" source="./media/optimize-code-cpu-usage-call-tree-fixed.png" alt-text="Alt text that describes the content of the image.":::

Switch to the **Flame Graph** view to see another visualization of the improvement. In this view, GetBlogTitle also uses a smaller portion of the CPU.

:::image type="content" source="./media/optimize-code-cpu-usage-flame-graph-fixed.png" alt-text="Alt text that describes the content of the image.":::

Check the results in the Database tool trace, and only two records are read, instead of 100,000!

:::image type="content" source="./media/optimize-code-database-fixed.png" alt-text="Alt text that describes the content of the image.":::

Next, recheck the results in the .NET Object Allocation tool, and see that GetBlogTitle is only responsible for 56,000 object allocations, about a 94% reduction!

:::image type="content" source="./media/optimize-code-dotnet-object-allocations-fixed.png" alt-text="Alt text that describes the content of the image.":::

## Iterate