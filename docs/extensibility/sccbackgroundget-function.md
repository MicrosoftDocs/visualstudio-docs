---
description: "This function retrieves from source control each of the specified files with no user interaction."
title: SccBackgroundGet Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccBackgroundGet
helpviewer_keywords:
- SccBackgroundGet function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccBackgroundGet function

This function retrieves from source control each of the specified files with no user interaction.

## Syntax

```cpp
SCCRTN SccBackgroundGet(
   LPVOID  pContext,
   LONG    nFiles,
   LPCSTR* lpFileNames,
   LONG    dwFlags,
   LONG    dwBackgroundOperationID
);
```

### Parameters
 pContext

[in] The source control plug-in context pointer.

 nFiles

[in] Number of files specified in the `lpFileNames` array.

 lpFileNames

[in, out] Array of names of files to be retrieved.

> [!NOTE]
> The names must be fully qualified local filenames.

 dwFlags

[in] Command flags (`SCC_GET_ALL`, `SCC_GET_RECURSIVE`).

 dwBackgroundOperationID

[in] A unique value associated with this operation.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Operation completed successfully.|
|SCC_E_BACKGROUNDGETINPROGRESS|A background retrieval is already in progress (the source control plug-in should return this only if it does not support simultaneous batch operations).|
|SCC_I_OPERATIONCANCELED|Operation was canceled before being completed.|

## Remarks
 This function is always called on a thread different from the one that loaded the source control plug-in. This function is not expected to return until it is done; however, it can be called multiple times with multiple lists of files, all at the same time.

 The use of the `dwFlags` argument is the same as the [SccGet](../extensibility/sccget-function.md).

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccGet](../extensibility/sccget-function.md)
