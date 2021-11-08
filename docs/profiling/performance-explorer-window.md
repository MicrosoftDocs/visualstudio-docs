---
title: "Performance Explorer Window | Microsoft Docs"
description: Learn how the Performance Explorer window in the Visual Studio IDE enables you to configure performance sessions by using the Visual Studio Profiling Tools.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performanceexplorer"
  - "vs.performance.explorer"
helpviewer_keywords:
  - "performance tools, Performance Explorer"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Performance Explorer Window

The **Performance Explorer** window in the Visual Studio IDE enables you to configure and start performance sessions by using the Visual Studio Profiling Tools. If you need to open the window, follow instructions in [Beginners guide to performance profiling](../profiling/beginners-guide-to-cpu-sampling.md).

## Performance Explorer Toolbar

The following options are available on the **Performance Explorer** toolbar:

- **Launch Performance Wizard** - Displays the Performance Wizard to add a new performance session to the Performance Explorer window.

- **New Performance Session** - Adds an empty performance session to the Performance Explorer window.

- **Launch** - The **Launch** command button list enables you to start the target application that has profiling immediately enabled (**Launch with profiling**) or with profiling suspended (**Launch with profiling paused**).

- **Method** - Specifies whether the profiling method of the session is sampling or instrumentation.

- **Stop** - Immediately exits the target application and the profiler.

- **Attach/Detach** - Displays the **Attach Profiler to Process** dialog box to select a running process to which to attach the profiler.

## Performance Explorer Window

The **Performance Explorer** window contains a tree control that displays the binaries and report data files of one or more performance sessions.

- **Session Name** - The root of the tree control contains the name of the session. Right-click the session name to set the session properties or to start the target application and profiler.

- **Targets** - Displays the names of binaries that are to be profiled in the session. Right-click **Targets** to add or remove a binary, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] project, or Web site. Right-click a target name to set properties for the individual binary.

- **Reports** - Displays the names of profiler data files that are generated for the session. Right-click **Reports** to add an existing report or compare two profiler data files. Right-click a report name to open, remove, or export a profiler data file.

## See also

[Overviews](../profiling/overviews-performance-tools.md)
[Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)
[Controlling Data Collection](../profiling/controlling-data-collection.md)
