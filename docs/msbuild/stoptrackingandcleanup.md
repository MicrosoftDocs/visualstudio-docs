---
title: "StopTrackingAndCleanup | Microsoft Docs"
description: Learn how MSBuild uses StopTrackingAndCleanup to stop all tracking and free any memory used by the tracking session.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "StopTrackingAndCleanup"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "StopTrackingAndCleanup"
ms.assetid: 9f8c5994-2dfc-43c3-a5fb-89b2f8990429
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# StopTrackingAndCleanup

Stops all tracking and frees any memory used by the tracking session.

## Syntax

```cpp
HRESULT WINAPI StopTrackingAndCleanup(void);
```

## Return value

 Returns an **HRESULT** with the **SUCCEEDED** bit set if tracking was stopped.

## Requirements

 **Header:** *FileTracker.h*

## See also

- [StartTrackingContext](../msbuild/starttrackingcontext.md)