---
title: "Modules View | Microsoft Docs"
description: Learn how the Modules view lists the modules of the profiling data. Each module is the root node of a hierarchical tree.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.modules"
helpviewer_keywords:
  - "Modules view"
  - "profiling tools reports, Modules view"
  - "profiling tools, Modules view"
ms.assetid: 4314a404-2120-425b-be42-180cd4bac840
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Modules View
The Modules view lists the modules of the profiling data. Each module is the root node of a hierarchical tree. The profiled functions of the module are listed underneath the module node. If the profiling data was collected by using the sampling method, line information is listed underneath the function node and instruction pointer data is listed underneath the line node.

 Expand or collapse the module name to display or close the view of module performance data.

 To add or remove columns, right-click in the report window, and then select **Add/Remove Columns**. You can sort the data by clicking a column name. For more information, see [How to: Customize Report View columns](../profiling/how-to-customize-report-view-columns.md).

 The columns that are available in the Modules view depend on the profiling method (sampling or instrumentation) that was used to collect the data, and whether .NET memory data was collected in the profiling run.

## See also
- [Modules View](../profiling/modules-view-sampling-data.md)
- [Modules View](../profiling/modules-view-instrumentation-data.md)
- [Modules View - instrumentation](../profiling/modules-view-dotnet-memory-instrumentation-data.md)
- [Modules View - sampling](../profiling/modules-view-dotnet-memory-sampling-data.md)
- [Modules View](../profiling/modules-view-contention-data.md)
