---
title: "Analyze Performance of .NET Asynchronous Code | Microsoft Docs"
ms.date: "5/5/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "asynchronous, async, profiling"
author: "esteban-herrera"
ms.author: "esherrer"
manager: AndSter
ms.workload:
  - "multiple"
---

# Analyze Performance of .NET Asynchronous Code

The .NET Async Tool allows you to analyze the performance of asynchronous code in your application.

>[!NOTE]
> The .NET Async tool requires Visual Studio 2019 version >= 16.7 and a .NET project using async/await.

## Setup

1. Open the Performance Profiler **(Alt + F2)** in Visual Studio.

2. Select the **.NET Async** checkbox.

![.NET Async Tool Selected](../profiling/media/async_tool_selected.png ".NET Async Tool Selected")

3. Click the **Start** button to run the tool.

4. Once the tool starts running, go through the desired scenario in your app, then press **Stop Collection** or close your app to see your data.

5. After collection is stopped, you'll see a table of the activities that happened during your profiling session.

![.NET Async Tool Stopped](../profiling/media/async_tool_opened.png ".NET Async Tool Stopped")

Asynchronous events are organized into activites chronologically, and display their respective start time, end time and duration. If a row corresponds to a [Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks) it is labeled in the 'Name' column. If a Task name cannot be resolved a 'Task in' label appears followed by the name of the method the Task occurs within. If an asynchronous activity does not complete within the collection session, it is indicated by an 'Incomplete' label in the End Time column. To investigate a specific Task or activity further you can right-click on the row and click '"Go to Source File" to see where in your code that activity happens.

![.NET Async Go To Source](../profiling/media/async_tool_gotosource.png ".NET Async Go To Source")
