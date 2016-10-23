---
title: "Modules View"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4314a404-2120-425b-be42-180cd4bac840
caps.latest.revision: 17
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Modules View
The Modules view lists the modules of the profiling data. Each module is the root node of a hierarchical tree. The profiled functions of the module are listed underneath the module node. If the profiling data was collected by using the sampling method, line information is listed underneath the function node and instruction pointer data is listed underneath the line node.  
  
 Expand or collapse the module name to display or close the view of module performance data.  
  
 To add or remove columns, right-click in the report window, and then select **Add/Remove Columns**. You can sort the data by clicking a column name. For more information, see [How to: Customize Report View Columns](../VS_IDE/How-to--Customize-Report-View-Columns.md).  
  
 The columns that are available in the Modules view depend on the profiling method (sampling or instrumentation) that was used to collect the data, and whether .NET memory data was collected in the profiling run.  
  
## See Also  
 [Modules View](../VS_IDE/Modules-View---Sampling-Data.md)   
 [Modules View](../VS_IDE/Modules-View---Instrumentation-Data.md)   
 [Modules View - Instrumentation](../VS_IDE/Modules-View---.NET-Memory-Instrumentation-Data.md)   
 [Modules View - Sampling](../VS_IDE/Modules-View---.NET-Memory-Sampling-Data.md)   
 [Modules View](../VS_IDE/Modules-View---Contention-Data.md)