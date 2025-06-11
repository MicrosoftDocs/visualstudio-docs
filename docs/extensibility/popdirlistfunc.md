---
title: POPDIRLISTFUNC
description: Learn about the POPDIRLISTFUNC callback function, which is passed to update directories to find out which are under source control.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- POPLISTFUNC
helpviewer_keywords:
- POPDIRLISTFUNC callback function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# POPDIRLISTFUNC

This is a callback function given to the [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md) function to update a collection of directories and (optionally) file names to find out which are under source control.

 The `POPDIRLISTFUNC` callback should be called only for those directories and file names (in the list given to the `SccPopulateDirList` function) that are actually under source control.

## Signature

```cpp
typedef BOOL (*POPDIRLISTFUNC)(
   LPVOID pvCallerData,
   BOOL bFolder,
   LPCSTR lpDirectoryOrFileName
);
```

## Parameters
 pvCallerData

[in] User value given to [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md).

 bFolder

[in] `TRUE` if the name in `lpDirectoryOrFileName` is a directory; otherwise the name is a file name.

 lpDirectoryOrFileName

[in] Full local path to a directory or file name that is under source code control.

## Return value
 The IDE returns an appropriate error code:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Continue processing.|
|SCC_I_OPERATIONCANCELED|Stop processing.|
|SCC_E_xxx|Any appropriate source control error should stop processing.|

## Remarks
 If the `fOptions` parameter of the `SccPopulateDirList` function contains the `SCC_PDL_INCLUDEFILES` flag, then the list will possibly contain file names as well as directory names.

## See also
- [Callback functions implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)
- [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md)
- [Error codes](../extensibility/error-codes.md)
