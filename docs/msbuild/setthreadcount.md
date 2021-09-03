---
title: "SetThreadCount | Microsoft Docs"
description: Learn how MSBuild uses SetThreadCount to set the global thread count, and assign that count to the current thread.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
apiname:
  - "SetThreadCount"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "SetThreadCount"
ms.assetid: 335335a5-8ca0-4e18-95f5-62aa6a691386
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# SetThreadCount

Sets the global thread count, and assigns that count to the current thread.

## Syntax

```cmd
HRESULT WINAPI SetThreadCount(int threadCount);
```

#### Parameters

[in] `threadCount`

 The number of threads to use.

## Return value

 An **HRESULT** with the **SUCCEEDED** bit set if the thread count was updated.

## Requirements

 **Header:** *FileTracker.h*