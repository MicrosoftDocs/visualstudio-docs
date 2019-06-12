---
title: "Performance Explorer Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performanceexplorer"
  - "vs.performance.explorer"
helpviewer_keywords: 
  - "performance tools, Performance Explorer"
ms.assetid: cb6a6efc-93a5-49a2-8d03-6969b5f3b6d7
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Performance Explorer Window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Performance Explorer** window in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] integrated development environment (IDE) enables you to configure and start performance sessions by using the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
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
  
- **Targets** - Displays the names of binaries that are to be profiled in the session. Right-click **Targets** to add or remove a binary, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project, or Web site. Right-click a target name to set properties for the individual binary.  
  
- **Reports** - Displays the names of profiler data files that are generated for the session. Right-click **Reports** to add an existing report or compare two profiler data files. Right-click a report name to open, remove, or export a profiler data file.  
  
## See Also  
 [Overviews](../profiling/overviews-performance-tools.md)   
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Controlling Data Collection](../profiling/controlling-data-collection.md)
