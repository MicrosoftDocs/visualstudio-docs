---
title: "How to: Specify the .NET Framework Runtime | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "Profiling Tools, .NET Framework versions"
  - ".NET Framework versions,profililng"
ms.assetid: d39f3579-719a-4f47-a97d-5b4232fe4c64
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "dotnet"
---
# How to: Specify the .NET Framework runtime

With the release of .NET Framework 4, applications can be composed of modules that were built by using different versions of the .NET Framework run-time. By default, Visual Studio Profiling Tools profile the first runtime that is loaded by the application. You can specify the run-time to profile when you start an application with the profiler and when you attach the profiler to an already running application.

## To specify the .NET Framework run-time to profile when starting an application with the profiler

1. In **Performance Explorer**, right-click the performance session, click **Properties**, and then click **Advanced**.

     The **Target CLR Version** list box displays **Automatic** and the versions of the .NET Framework runtime that are installed on the computer.

2. Perform one of the following steps:

    - Click the version of the CLR that you want to profile.

    - Click **Automatic** to profile the first version that is loaded by the application.

## To specify the .NET Framework run-time to profile when attaching the profiler to an application

1. On the **Analyze** menu, point to **Profiler**, then click **Attach/Detach**.

2. On the **Attach Profiler to Process** dialog box, click the process that you want to profile.

     The **Target CLR Version** list box s **Automatic** and the versions of the .NET Framework runtime that are installed on the computer.

3. Perform one of the following steps:

    - Click the version of the CLR that you want to profile.

    - Click **Automatic** to profile the version that is loaded when the profiler attaches to the application.
