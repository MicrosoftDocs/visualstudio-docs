---
title: "Marks View | Microsoft Docs"
description: Learn how the Marks view displays sampling and ETW events that were inserted into the application.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.marks"
helpviewer_keywords:
  - "profiling tools, Marks view"
  - "profiling tools reports, Marks view"
ms.assetid: b2773344-8081-4116-85a1-58f770448f6a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Marks View
The Marks view displays sampling and ETW events that were inserted into the application.

 The default marks that are prepopulated in the report label the start of the program and the end of the program.

 Windows counters data from automatically generated marks is also presented in this view. For more information, see [How to: Collect Windows counter data](../profiling/how-to-collect-windows-counter-data.md).

 To create a filter between two marks, select the marks, right-click, and then click **Add Filter by Marks** or **Add Filter by Timestamp**.

 The following table provides the definitions of columns that are available in the Marks view.

 **Mark ID**
 Unique identifier of the profiling mark.

 **Mark Name**
 The name of the event.

 **Timestamp**
 Time from the start of profiling to the time that the event is recorded.

 Windows performance counter data
 When Windows performance counter data is collected the values are displayed in a column that has the name of the counter.

## See also
- [Performance report overview](../profiling/performance-report-overview.md)
- [How to: Collect Windows counter data](../profiling/how-to-collect-windows-counter-data.md)
- [&#91;NIB&#93; Data Collection Control window](/previous-versions/bb385767(v=vs.110))