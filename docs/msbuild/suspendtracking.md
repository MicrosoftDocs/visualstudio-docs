---
title: "SuspendTracking | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "SuspendTracking"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "SuspendTracking"
ms.assetid: f5e06e5a-8083-444c-99c1-07ba834226b5
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# SuspendTracking
Suspends tracking in the current context.

## Syntax

```cpp
HRESULT WINAPI SuspendTracking(void);
```

## Return value
 An **HRESULT** with the **SUCCEEDED** bit set if tracking was suspended.

## Requirements
 **Header:** *FileTracker.h*

## See also
- [ResumeTracking](../msbuild/resumetracking.md)