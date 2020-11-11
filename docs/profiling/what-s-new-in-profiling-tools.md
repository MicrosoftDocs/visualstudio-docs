---
title: "What's New in Profiling in Visual Studio 2017 | Microsoft Docs"
titleSuffix: ""
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling"
  - "what's new"
ms.assetid: d4736cc8-8961-4089-be9e-d5190ce8353c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
monikerRange: vs-2017
---
# What's new in profiling tools in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]

The Diagnostics Tools include new visualizations to help you identify issues in your app that need fixing. The Diagnostics Tools now include support for ASP.NET apps.

For additional information, see the [Release notes for [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]](/visualstudio/releasenotes/vs2017-relnotes).

A **Summary** tab has been added to the tools that helps you to focus on key areas for your performance analysis. This tab shows how many events have occurred, lets you take snapshots of the heap, and lets you quickly enable CPU usage data collection. This view shows any [Application insights](/azure/azure-monitor/app/visual-studio) or [UI analysis](/visualstudio/releasenotes/vs2017-relnotes) events. In addition, for Visual Studio Enterprise, this view also shows IntelliTrace events.

![Diagnostics Tools Summary tab](../profiling/media/diag-tools-summary-tab-2.png "DiagToolsSummaryTab")

The CPU usage tool has [new visualizations](../profiling/Beginners-Guide-to-Performance-Profiling.md) to help you identify the functions that are most likely to be causing performance issues. The new **Caller/Callee** view allows you to investigate costs of function calls made to and from a selected function.

![Diagnostics Tools caller callee view](../profiling/media/diag-tools-caller-callee-2.png "DiagToolsCallerCallee")

## See also

- [Profile in Visual Studio](../profiling/index.yml)
- [First look at profiling tools](../profiling/profiling-feature-tour.md)