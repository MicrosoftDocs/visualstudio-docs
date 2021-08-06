---
title: "SuspendTracking | Microsoft Docs"
description: Learn syntax, requirements, and return value for MSBuild SuspendTracking, which suspends tracking in the current context.
ms.custom: SEO-VS-2020
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
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
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