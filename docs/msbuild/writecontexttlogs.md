---
title: "WriteContextTLogs | Microsoft Docs"
description: Learn syntax, requirements, and return value for WriteContextTLogs, which writes log files for the current context.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
apiname:
  - "WriteContextTLogs"
apilocation:
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords:
  - "WriteContextTLogs"
ms.assetid: ffc6c7be-3f22-4624-9ffc-0122fe72b6ec
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# WriteContextTLogs

Writes logs files for the current context.

## Syntax

```cpp
HRESULT WINAPI WriteContextTLogs(LPCTSTR intermediateDirectory, LPCTSTR tlogRootName);
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

- [WriteAllTLogs](../msbuild/writealltlogs.md)