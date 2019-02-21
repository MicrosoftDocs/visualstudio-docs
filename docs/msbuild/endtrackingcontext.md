---
title: "EndTrackingContext | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "EndTrackingContext"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "EndTrackingContext"
ms.assetid: c2c5d794-8dc8-4594-8717-70dc79a0e75d
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# EndTrackingContext
End the current tracking context.

## Syntax

```cpp
HRESULT WINAPI EndTrackingContext();
```

## Return value
An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was ended.

## Requirements
**Header:** *FileTracker.h*

## See also
- [StartTrackingContext](../msbuild/starttrackingcontext.md)
