---
title: "Analyze Performance of .NET Asynchronous Code | Microsoft Docs"
ms.date: "5/5/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "asynchronous, async, profiling"
author: "Esteban Herrera"
ms.author: "esherrer"
manager: AndSter
ms.workload:
  - "multiple"
---

# Analyze Performance of .NET Asynchronous Code

The .NET Async Tool allows you to analyze the performance of asynchronous code in your application.

>[!NOTE]
> The .NET Async tool requires Visual Studio 2019 version <= 16.7
and a .NET project using async/await.

## Setup

1. Open the Performance Profiler **(Alt + F2)** in Visual Studio.
2. Select the **.NET Async** checkbox.

![.NET Async Tool Selected](./media/async_tool_selected.png ".NET Async Tool Selected")

3. Click the **Start** button to run the tool.

4. Once the tool starts running, go through the desired scenario in your app, then press **Stop Collection** or close your app to see your data.

5. After collection is stopped, you'll see a table of the activities that happened during your profiling session.

![.NET Async Tool Stopped](./media/async_tool_opened.png ".NET Async Tool Stopped")

The queries will be organized chronologically, but can be sorted by any of the columns (more columns can be enabled by right clicking the column titles), clicking the Duration column will order the queries from longest lasting to shortest, and once you’ve found a query you’d like to investigate, you can right click the query and select “Go to Source File” to see what code is responsible for that query.

![Allocation](./media/async_tool_gotosource.png "Allocation")

Selecting a time range on graph will also filter the query table to only queries that occcured during that time range. This can be especially useful when running this alongside the [CPU Usage tool](https://docs.microsoft.com/en-us/visualstudio/profiling/cpu-usage?view=vs-2019).

task in, task, incomplete