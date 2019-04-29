---
title: "How to: Specify the .NET Framework Runtime | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "Profiling Tools, .NET Framework versions"
  - ".NET Framework versions,profililng"
ms.assetid: d39f3579-719a-4f47-a97d-5b4232fe4c64
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify the .NET Framework Runtime
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With the release of [!INCLUDE[net_v40_long](../includes/net-v40-long-md.md)], applications can be composed of modules that were built by using different versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] run-time. By default, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Profiling Tools profile the first runtime that is loaded by the application. You can specify the run-time to profile when you start an application with the profiler and when you attach the profiler to an already running application.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
### To specify the .NET Framework run-time to profile when starting an application with the profiler  
  
1. In **Performance Explorer**, right-click the performance session, click **Properties**, and then click **Advanced**.  
  
     The **Target CLR Version** list box displays **Automatic** and the versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] runtime that are installed on the computer.  
  
2. Perform one of the following steps:  
  
    - Click the version of the CLR that you want to profile.  
  
    - Click **Automatic** to profile the first version that is loaded by the application.  
  
### To specify the .NET Framework run-time to profile when attaching the profiler to an application  
  
1. On the Analyze menu, point to Profiler, then click Attach/Detach.  
  
2. On the Attach Profiler to Process dialog box, click the process that you want to profile.  
  
     The **Target CLR Version** list box s **Automatic** and the versions of the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] runtime that are installed on the computer.  
  
3. Perform one of the following steps:  
  
    - Click the version of the CLR that you want to profile.  
  
    - Click **Automatic** to profile the version that is loaded when the profiler attaches to the application.
