---
title: "Collecting tier interaction data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.tierinteraction"
helpviewer_keywords: 
  - "Profiling Tools,ADO.NET profiling"
  - "tier interaction profiling method"
  - "Profiling Tools,tier-interaction method"
  - "ADO.NET performance profiling"
ms.assetid: 47a944c2-3098-497c-8fc7-e1f43d750bbc
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Collecting tier interaction data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Tier interaction profiling provides additional information about the execution times of functions of multi-tiered applications that communicate with databases through ADO.NET services. Data is collected only for synchronous function calls.  
  
 **Visual Studio editions**  
  
 Tier interaction profiling data can be collected using Visual Studio Ultimate, Visual Studio Premium, or Visual Studio Professional. However, tier interaction profiling data can be viewed only in VS Ultimate and VS Premium.  
  
 **Windows 8 and Windows Server 2012**  
  
 To collect tier interaction data on Windows 8 desktop apps and Windows Server 2012 apps, you must use the instrumentation method. You cannot collect tier interaction data for Windows Store apps. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md). You can include tier interaction data in all profiling methods on other supported version of Windows.  
  
 **Performance Wizard**  
  
 Because of a bug in the Performance Wizard, you must add the tier interaction data collection option to a profiling run from the Performance Explorer. You must also add the project, executable, or website to the Target node of Performance Explorer.  
  
### To add tier interaction data to a profiling run by using the performance session property pages  
  
1. In Performance Explorer, choose **Properties** from the context menu.  
  
2. Select **Tier Interactions** page and then check the **Enable tier interaction profiling** check box.  
  
3. In Performance Explorer, select the **Targets** node, and then specify the project, executable, or web site that you want to profile.  
  
## See Also  
 [Tier Interactions View](../profiling/tier-interactions-view.md)
