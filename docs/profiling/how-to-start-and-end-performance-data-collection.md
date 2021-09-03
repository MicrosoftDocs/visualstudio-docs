---
title: Start and End Performance Data Collection | Microsoft Docs
description: Learn how you can add the target binary that you want to profile to the performance session before you start profiling.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.performance.wizard.summarypage
helpviewer_keywords: 
  - profiling tools, launching sessions
  - performance sessions, launching
  - performance sessions, ending
  - profiling tools, ending sessions
ms.assetid: 9f6eb0d5-d9e9-4bec-b627-445065610bce
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Start and end performance data collection
You must add the target binary that you want to profile to the performance session before you start profiling. To add a target, right-click **Targets** in **Performance Explorer**, and then click **Add Target Binary**. In the **Add Target Binary** dialog box, select the file name, and then click **Open**. A new binary is added.

### To start profiling

1. Right-click the name of the performance session on the **Performance Explorer** window and choose one of the following options:

    - **Launch with Profiling** - starts the application and immediately begins profiling.

    - **Launch with Profiling Paused** - starts the application but does not begin profiling. You can start profiling by selecting **Resume Collection** in the **Data Collection Control** window. For more information, see [How to: Pause and resume performance data collection](../profiling/how-to-pause-and-resume-performance-data-collection.md).

### To end profiling

- The preferred method of ending a profiling session is to exit the application. To immediately stop profiling, on the **Performance Explorer** toolbar, click **Stop**.

## See also
- [Control data collection](../profiling/controlling-data-collection.md)
- [How to: Pause and resume performance data collection](../profiling/how-to-pause-and-resume-performance-data-collection.md)
