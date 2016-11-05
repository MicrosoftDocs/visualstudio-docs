---
title: "Modules View | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.performance.view.modules"
helpviewer_keywords: 
  - "Modules view"
  - "profiling tools reports, Modules view"
  - "profiling tools, Modules view"
ms.assetid: 4314a404-2120-425b-be42-180cd4bac840
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Modules View
The Modules view lists the modules of the profiling data. Each module is the root node of a hierarchical tree. The profiled functions of the module are listed underneath the module node. If the profiling data was collected by using the sampling method, line information is listed underneath the function node and instruction pointer data is listed underneath the line node.  
  
 Expand or collapse the module name to display or close the view of module performance data.  
  
 To add or remove columns, right-click in the report window, and then select **Add/Remove Columns**. You can sort the data by clicking a column name. For more information, see [How to: Customize Report View Columns](../profiling/how-to-customize-report-view-columns.md).  
  
 The columns that are available in the Modules view depend on the profiling method (sampling or instrumentation) that was used to collect the data, and whether .NET memory data was collected in the profiling run.  
  
## See Also  
 [Modules View](../profiling/modules-view-sampling-data.md)   
 [Modules View](../profiling/modules-view-instrumentation-data.md)   
 [Modules View - Instrumentation](../profiling/modules-view-dotnet-memory-instrumentation-data.md)   
 [Modules View - Sampling](../profiling/modules-view-dotnet-memory-sampling-data.md)   
 [Modules View](../profiling/modules-view-contention-data.md)