---
title: "Getting started with performance tools | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "getting started, performance"
  - "getting started, profiling tools"
ms.assetid: 02085214-a8e4-40fd-9b26-32391a7a7082
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Getting started with performance tools

Visual Studio offers several ways to collect, view, and analyze code performance data. Performance tools include the **Diagnostic Tools** window, **Performance Explorer**, and the **Performance Profiler**. For more information, see [Run profiling tools with or without the debugger](running-profiling-tools-with-or-without-the-debugger.md).

In many cases, the best way to get started with performance tools is to use the default settings of the **Performance Wizard** in **Performance Profiler**. The wizard collects app statistics that can point to performance issues in your code.  
  
In the Visual Studio performance tools:

- Performance warnings that notify you of common coding issues appear in the **Error List** window. You can navigate from the warning to your source code, and to detailed help topics that help you write more efficient code.

- Performance reports provide views on different levels of your application structure, source code lines, and processes. Performance reports show app execution data, from the calling and called functions of a specific function to the call tree of the entire app.  
  
To quickly run Visual Studio performance tools, select **Debug** > **Performance Profiler**, and select one or more available tools. Select **Performance Wizard** to get started profiling a project, app, or ASP.NET website. For detailed instructions, see [Beginners guide to performance profiling](../profiling/beginners-guide-to-cpu-sampling.md) and [How to: Collect performance data for a website](../profiling/how-to-collect-performance-data-for-a-web-site.md).  

To manually specify and configure a performance profiling session, select **Debug** > **Profiler** > **Performance Explorer** > **New Performance Session**. Use the **Targets** folder and **Properties** pages in the **Performance Explorer** window to configure the performance session. For instructions, see [How to: Manually create performance sessions](../profiling/how-to-manually-create-performance-sessions.md).  
  
You can use the **Diagnostic Tools** window to collect performance data while debugging. For more details, see [Quickstart: First look at profiling tools](profiling-feature-tour.md).

**See also:**
  
 [Performance tools overviews](../profiling/overviews-performance-tools.md)   
 [Analyzing performance tools data](../profiling/analyzing-performance-tools-data.md)   
 [Using performance rules to analyze data](../profiling/using-performance-rules-to-analyze-data.md)   
 [Configuring performance sessions](../profiling/configuring-performance-sessions.md)