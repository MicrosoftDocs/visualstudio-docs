---
title: Directory Status Code Enumerator
description: The SccDirStatus enumerator contains named constant values that specify the state of a directory in the source control system and is used by SccDirQueryInfo.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- directory status code enumerator
- source control plug-ins, directory status enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Directory status code enumerator

The `SccDirStatus` enumerator contains named constant values that specify the state of a directory in the source control system. This enumeration is used by the [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md). This was introduced in version 1.2 of the Source Control Plug-in API.

## Syntax

```
enum SccDirStatus {
   SCC_DIRSTATUS_INVALID       = -1L,
   SCC_DIRSTATUS_NOTCONTROLLED = 0x0000L,
   SCC_DIRSTATUS_CONTROLLED    = 0x0001L,
   SCC_DIRSTATUS_EMPTYPROJ     = 0x0002L
};
```

## Members
 SCC_DIRSTATUS_INVALID
 Status could not be obtained; do not rely on it.

 SCC_DIRSTATUS_NOTCONTROLLED
 Directory is not under source control.

 SCC_DIRSTATUS_CONTROLLED
 Directory is under source control.

 SCC_DIRSTATUS_EMPTYPROJ
 Project corresponding to this directory is empty.

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
- [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md)
