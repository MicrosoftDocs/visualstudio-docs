---
title: "WriteAllTLogs | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "WriteAllTLogs"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "WriteAllTLogs"
ms.assetid: 1fa3e10b-263c-4960-a9ad-485c02a7a872
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# WriteAllTLogs
Writes tracking logs for all threads and contexts.

## Syntax

```cpp
HRESULT WINAPI WriteAllTLogs(LPCTSTR intermediateDirectory, LPCTSTR tlogRootName);
```

#### Parameters
[in] `intermediateDirectory`

 The directory in which to store the tracking log.

[in] `tlogRootName`

 The root name of the log file name.

## Return value
 An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was created.

## Requirements
 **Header:** *FileTracker.h*

## See also
- [WriteContextTLogs](../msbuild/writecontexttlogs.md)