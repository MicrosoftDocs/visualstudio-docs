---
title: Pause and Resume Performance Data Collection | Microsoft Docs
description: Learn how you can control the collection of profiling data interactively from the profiling session page window.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - profiling tools, remote profiling
ms.assetid: b8e76363-65cd-424d-8173-3e2b5f54203b
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Pause and resume performance data collection
From the profiling session page window, you can control the collection of profiling data interactively.

 Controlling data collection enables you to reduce the size of the profile data file, and to collect data only for those operations that you are interested in. You can pause and resume profiling multiple times in a performance session.

 ![Profiling session page](../profiling/media/prof_profilingsessionpage.png "PROF_ProfilingSessionPage")

> [!NOTE]
> You can also start the performance session with profiling paused, then resume profiling at a later point in the program execution. To start the performance session with profiling paused, choose **Start Performance Analysis with Profiling Paused** command on the **Debug** menu.

### To pause,  resume, or stop profiling

- On the profiling session page:

  - Choose **Pause Collection** to suspend data collection.

  - Choose **Resume Collection** to restart data collection after it has been paused.

  - Choose **Stop profiling** to end the profiling session and generate reports.

## See also
- [Control data collection](../profiling/controlling-data-collection.md)
- [How to: Start and end performance data collection](../profiling/how-to-start-and-end-performance-data-collection.md)
