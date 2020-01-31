---
title: "Collecting Thread and Process Concurrency Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "concurrency profiling method"
  - "Profiling Tools, concurrency method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Collect thread and process concurrency data

The Visual Studio Profiling Tools concurrency profiling method enables you to collect resource contention data that includes information about every synchronization event that causes a function in the profiled application to wait for access to a resource.

You can specify the concurrency profiling method by using one of the following procedures:

- On the first page of the Profiling Wizard, click **Concurrency**
- On the **General** page of the properties dialog box for the performance session, click **Concurrency**.
- On the **Performance Explorer** toolbar, in the **Method** list, click **Concurrency**.

## Common tasks

You can specify additional options in the _Performance Session_**Property Pages** dialog box of the performance session. To open this dialog box:

- In **Performance Explorer**, right-click the performance session name, and then click **Properties**.

The tasks in the following table describe options that you can specify in the _Performance Session_**Property Pages** dialog box when you profile by using the concurrency method.

|Task|Related Content|
|----------|---------------------|
|On the **General** page, specify naming details for the generated profiling data (.vsp) file.|- [How to: Set performance data file name options](../profiling/how-to-set-performance-data-file-name-options.md)|
|On the **Launch** page, specify the application to start if you have multiple .exe projects in your code solution.|- [How to: Specify the binary to start](../profiling/how-to-specify-the-binary-to-start.md)|
|On the **Tier Interaction** page, add ADO.NET call data to the profiling run.|- [Collect tier interaction data](../profiling/collecting-tier-interaction-data.md)|
|On the **Windows Counters** page, specify one or more operating system performance counters to add to the profiling data as marks.|- [How to: Collect Windows counter data](../profiling/how-to-collect-windows-counter-data.md)|
|On the **Advanced** page, specify the version of the .NET Framework run-time to profile if your application modules use multiple versions. By default, the first version loaded is profiled.|- [How to: Specify the .NET Framework runtime](../profiling/how-to-specify-the-dotnet-framework-runtime.md)|
