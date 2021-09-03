---
title: StartTrackingContext | Microsoft Docs
description: Learn the parameters, requirements, and return value for MSBuild StartTrackingContext, which starts a tracking context.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
apiname:
- StartTrackingContext
apilocation:
- filetracker.dll
apitype: COM
helpviewer_keywords:
- StartTrackingContext
ms.assetid: 720cd295-38e7-4974-86db-b8106b1207ba
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# StartTrackingContext

Start a tracking context.

## Syntax

```cpp
HRESULT WINAPI StartTrackingContext(LPCTSTR intermediateDirectory, LPCTSTR taskName);
```

#### Parameters

[in] `intermediateDirectory`

 The directory in which to store the tracking log.

[in] `taskName`

 Identifies the tracking context. This name is used to create the log file name.

## Return value

 An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was created.

## Requirements

 **Header:** *FileTracker.h*
