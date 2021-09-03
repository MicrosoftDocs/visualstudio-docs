---
title: "StartTrackingContextWithRoot | Microsoft Docs"
description: Learn to use MSBuild StartTrackingContextWithRoot to start a tracking context using a response file specifying a root marker.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "StartTrackingContextWithRoot"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "StartTrackingContextWithRoot"
ms.assetid: f6ef2b76-8035-4a14-8195-aa221c46ef48
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# StartTrackingContextWithRoot

Starts a tracking context using a response file specifying a root marker.

## Syntax

```cpp
HRESULT WINAPI StartTrackingContextWithRoot(LPCTSTR intermediateDirectory, LPCTSTR taskName, LPCTSTR rootMarkerResponseFile);
```

#### Parameters

[in] `intermediateDirectory`

 The directory in which to store the tracking log.

[in] `taskName`

 Identifies the tracking context. This name is used to create the log file name.

[in] `rootMarkerResponseFile`

 The pathname of a response file containing a root marker. The root name is used to group all tracking for a context together.

## Return value

 An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was created.

## Requirements

 **Header:** *FileTracker.h*

## See also

- [StartTrackingContext](../msbuild/starttrackingcontext.md)