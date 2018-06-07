---
title: "What's New in Profiling | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "profiling"
  - "what's new"
ms.assetid: d4736cc8-8961-4089-be9e-d5190ce8353c
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# What's new in profiling tools in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]
The Diagnostics Tools include new visualizations to help you identify issues in your app that need fixing. The Diagnostics Tools now include support for ASP.NET apps.

For additional information, see the [Release notes for [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]](https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#debuggingdiag).

A **Summary** tab has been added to the tools that helps you to focus on key areas for your performance analysis. This tab shows how many events have occurred, lets you take snapshots of the heap, and lets you quickly enable CPU usage data collection. This view shows any [Application insights](https://azure.microsoft.com/en-us/documentation/articles/app-insights-visual-studio/) or [UI analysis](https://www.visualstudio.com/en-us/news/releasenotes/vs2017-relnotes#UIAnalysis) events. In addition, for Visual Studio Enterprise, this view also shows IntelliTrace events.

![Diagnostics Tools Summary tab](../profiling/media/DiagToolsSummaryTab-2.png "DiagToolsSummaryTab")

The CPU usage tool has [new visualizations](../profiling/Beginners-Guide-to-Performance-Profiling.md) to help you identify the functions that are most likely to be causing performance issues. The new **Caller/Callee** view allows you to investigate costs of function calls made to and from a selected function.

![Diagnostics Tools caller callee view](../profiling/media/DiagToolsCallerCallee.png "DiagToolsCallerCallee")
  
## See also  
 [Profile in Visual Studio](../profiling/index.md)  
 [Profile feature tour](../profiling/profiling-feature-tour.md)