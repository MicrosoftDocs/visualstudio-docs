---
title: "How to: Collect Windows Counter Data | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.property.syscounter"
  - "vs.performance.property.wincounter"
helpviewer_keywords:
  - "windows counters"
  - "performance tools, using windows counters"
  - "profiling tools, using windows counters"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Collect Windows counter data

Windows Counters are system performance counters that can be collected at set intervals during profiling. In the Marks view of the Profiling Tools report, a row is labeled **AutoMark** for each collection interval. The row contains columns that describe the performance counter values at that interval. To restrict the analysis to a period of time between two particular marks, select the marks, right-click, and then select **Filter By** > **Marks** from the shortcut menu.

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

## To collect Windows counter data

1. In Performance Explorer, right-click the session for which you want to configure Windows counters and select **Properties**.

2. In the **Property Pages**, click **Windows Counters**.

3. Select the **Collect Windows Counters** check box.

4. In the **Collection interval (msecs)** text box, type a time interval.

5. Select a category from the **Counter Category** drop-down list.

6. Select an instance from the **Instance** drop-down list.

7. Select the counters you want to use when you profile your application.

8. Click **Apply.**

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[Performance session properties](../profiling/performance-session-properties.md)
[CPU and Windows counters](../profiling/cpu-and-windows-counters.md)
