---
description: "This function determines which directories and (optionally) files are stored in source control, given a list of directories to examine."
title: SccPopulateDirList Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccPopulateDirList
helpviewer_keywords:
- SccPopulateDirList function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccPopulateDirList Function

This function determines which directories and (optionally) files are stored in source control, given a list of directories to examine.

## Syntax

```cpp
SCCRTN SccPopulateDirList(
   LPVOID        pContext,
   LONG          nDirs,
   LPCSTR*       lpDirPaths,
   POPDIRLISTFUNCpfnPopulate,
   LPVOID        pvCallerData,
   LONG          fOptions
);
```

#### Parameters
 pContext

[in] The source control plug-in context pointer.

 nDirs

[in] Number of directory paths in the `lpDirPaths` array.

 lpDirPaths

[in] Array of directory paths to examine.

 pfnPopulate

[in] Callback function to call for each directory path and (optionally) filename in `lpDirPaths` (see [POPDIRLISTFUNC](../extensibility/popdirlistfunc.md) for details).

 pvCallerData

[in] Value that is to be passed unchanged to the callback function.

 fOptions

[in] A combination of values that control how the directories are processed (see the "PopulateDirList flags" section of [Bitflags Used by Specific Commands](../extensibility/bitflags-used-by-specific-commands.md) for possible values).

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Successfully completed the operation.|
|SCC_E_UNKNOWNERROR|An error occurred.|

## Remarks
 Only those directories and (optionally) file names that are actually in the source control repository are passed to the callback function.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [Bitflags Used by Specific Commands](../extensibility/bitflags-used-by-specific-commands.md)
- [POPDIRLISTFUNC](../extensibility/popdirlistfunc.md)
- [Error Codes](../extensibility/error-codes.md)
