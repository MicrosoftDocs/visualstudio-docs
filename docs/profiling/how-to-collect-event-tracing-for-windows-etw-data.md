---
title: "How to: Collect Event Tracing for Windows (ETW) Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.property.events"
helpviewer_keywords:
  - "event trace providers, performance tools"
  - "profiling tools, event trace providers"
  - "performance tools, enabling event trace providers"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Collect Event Tracing for Windows (ETW) data

Event Tracing for Windows (ETW) is an efficient kernel-level tracing facility that enables profiler log kernel or application-defined events. The data that is collected from the event provider can be viewed only by using the /**Summary:ETW** option of the [VSPerfReport](../profiling/vsperfreport.md) command-line tool. You can use this report to determine where performance issues occur in the application.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## To enable event trace providers

1. In **Performance Explorer**, right-click the performance session, and then click **Properties**.

2. In the **Property Pages**, click the **Windows Events** properties.

3. In the **Select event trace provider to collect data from** list, select the event providers that you want to use to profile your application.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
