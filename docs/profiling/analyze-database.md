---
title: "Analyze Database usage for .NET Core projects | Microsoft Docs"
ms.date: "5/5/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "database, profiling"
author: "esteban-herrera"
ms.author: "esherrer"
manager: AndSter
ms.workload:
  - "multiple"
---
# Analyze database performance using the Database tool

The Database Tool allows you to record the database queries that your application makes during a given diagnostic session. You can then analyze information about individual queries in order to find places where your app's performance can be improved.

>[!NOTE]
> The database tool requires Visual Studio 2019 version <= 16.3
and a .NET Core project on Windows using either [ADO.NET]( https://docs.microsoft.com/dotnet/framework/data/adonet/ado-net-overview) or [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

## Setup

1. Open the Performance Profiler **(Alt + F2)** in Visual Studio.
2. Select the **Database** checkbox.

![Database Tool Selected](./media/db_launch.png "Database Tool Selected")
>[!NOTE]
>If the tool is not available to click, uncheck every other tool as some tools need to run by themselves. To learn more about running tools together, see "Running tools from CLI"
If the tool still isn't available, please check that your project meets the requirements above.
Make sure your Project is in Release mode in order to capture the most accurate data.

3. Click the **Start** button to run the tool.

4. Once the tool starts running, go through the desired scenario in your app, then press **Stop Collection** or close your app to see your data.

5. After collection is stopped, you'll see a table of the queries that happened during your profiling session.

![Database Tool Stopped](./media/db_after.png "Database Tool Stopped")

The queries will be organized chronologically, but can be sorted by any of the columns (more columns can be enabled by right clicking the column titles), clicking the Duration column will order the queries from longest lasting to shortest, and once you’ve found a query you’d like to investigate, you can right click the query and select “Go to Source File” to see what code is responsible for that query.

![Allocation](./media/db_gotosource.png "Allocation")

Selecting a time range on graph will also filter the query table to only queries that occcured during that time range. This can be especially useful when running this alongside the [CPU Usage tool](https://docs.microsoft.com/visualstudio/profiling/cpu-usage?view=vs-2019).
