---
title: "How to: Collect Event Tracing for Windows (ETW) Data | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.events"
helpviewer_keywords: 
  - "event trace providers, performance tools"
  - "profiling tools, event trace providers"
  - "performance tools, enabling event trace providers"
ms.assetid: aa2261fe-d5f5-49fc-a171-d18842e1dc7d
caps.latest.revision: 31
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Collect Event Tracing for Windows (ETW) Data
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Event Tracing for Windows (ETW) is an efficient kernel-level tracing facility that enables profiler log kernel or application-defined events. The data that is collected from the event provider can be viewed only by using the /**Summary:ETW** option of the [VSPerfReport](../profiling/vsperfreport.md) command-line tool. You can use this report to determine where performance issues occur in the application.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
### To enable event trace providers  
  
1. In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2. In the **Property Pages**, click the **Windows Events** properties.  
  
3. In the **Select event trace provider to collect data from** list, select the event providers that you want to use to profile your application.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)
