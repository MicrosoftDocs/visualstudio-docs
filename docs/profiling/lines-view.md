---
title: "Lines View | Microsoft Docs"
description: Learn how the Lines view is available only for profiler data that was collected by using the sampling method.
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.view.lines"
helpviewer_keywords:
  - "profiling tools reports, Line view"
  - "profiling tools, Line view"
  - "Lines view"
ms.assetid: 71ec0781-6031-4e17-af09-f50226018437
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Lines View
The Lines view is available only for profiler data that was collected by using the sampling method. The view is not available for data that was collected by using instrumentation.

 For sampling profile data, the Lines view identifies the statement in a function that was directly executing when the sample was collected. For .NET memory data, the Lines view identifies the statements that allocate memory.

 In a source file, a statement can span more that one line in a source file, and a single line can include more than one statement.

 A statement is identified by the following:

- The source file that contains the function statement.

- The function that contains the statement.

- The source line at which the statement starts.

- The character in the source line at which the statement starts.

- The source line at which the statement ends.

- The character in the source line at which the statement ends.

## See also
- [Lines View](../profiling/lines-view-sampling-data.md)
- [Lines View - sampling](../profiling/lines-view-dotnet-memory-sampling-data.md)
- [Lines View](../profiling/lines-view-contention-data.md)
