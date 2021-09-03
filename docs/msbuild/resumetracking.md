---
title: "ResumeTracking | Microsoft Docs"
description: Learn syntax, requirements, and return value for MSBuild ResumeTracking, which resumes tracking in the current context.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "ResumeTracking"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "ResumeTracking"
ms.assetid: d637e019-7c50-4b0a-812e-bc822001e697
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# ResumeTracking

Resumes tracking in the current context.

## Syntax

```cpp
HRESULT WINAPI ResumeTracking();
```

## Return value

 An **HRESULT** with the **SUCCEEDED** bit set if tracking was resumed. **E_FAIL** is returned if tracking cannot be resumed because the context was not available.

## Requirements

 **Header:** *FileTracker.h*

## See also

- [SuspendTracking](../msbuild/suspendtracking.md)