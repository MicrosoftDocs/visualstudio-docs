---
title: "Call Tree View | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.view.calltree"
helpviewer_keywords: 
  - "Call Tree view"
  - "profiling tools reports, Call Tree view"
  - "performance reports, Call Tree view"
  - "profiling tools, Call Tree view"
ms.assetid: b2dbc033-bf95-4d10-8e51-f9462979133e
caps.latest.revision: 39
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Call Tree View
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Call Tree view displays the function execution paths that were traversed in the profiled application. The root of the tree is the entry point into the application or the component. Each function node lists all the functions it called and performance data about those function calls.  
  
 The Call Tree view can also expand and highlight the execution path of a function that consumed the most time or was sampled most frequently. To display the most performance-expensive path, right-click the function and then click **Expand Hot Path**.  
  
 Each process in the profiling run is displayed as a root node. You can set the start node of the Call Tree view by right-clicking the node you want to set as the start node and then selecting **Set Root**.  
  
 When you set the root node, you eliminate all other entries from the view except the subtree of the selected node. You can reset the root node back to the node you were viewing. On the Call Tree view window, right-click and then select **Reset Root**.  
  
 The Call Tree view can be customized to add or remove columns. Right-click the **Column Name Title Bar**, and then select **Add/Remove Columns**.  
  
 The Call Tree view can be configured for noise reduction by limiting the amount of data that is presented. By using noise reduction, performance problems are more prominent in the view. When performance problems are easy to distinguish, analysis is easier. For more information, see [How to: Configure Noise Reduction in Report Views](../profiling/how-to-configure-noise-reduction-in-report-views.md).  
  
> [!NOTE]
> If noise reduction is configured to display a warning when it is enabled, an information bar will be displayed in the report.  
  
 For more information about definitions for columns in the Call Tree view, see the following:  
  
 [Call Tree View](../profiling/call-tree-view-sampling-data.md)  
  
 [Call Tree View](../profiling/call-tree-view-instrumentation-data.md)  
  
 [Call Tree View - Sampling](../profiling/call-tree-view-dotnet-memory-sampling-data.md)  
  
 [Call Tree View](../profiling/call-tree-view-contention-data.md)  
  
## See Also  
 [Performance Report Views](../profiling/performance-report-views.md)   
 [Understanding Instrumentation Data Values](../profiling/understanding-instrumentation-data-values.md)   
 [Understanding Sampling Data Values](../profiling/understanding-sampling-data-values.md)
