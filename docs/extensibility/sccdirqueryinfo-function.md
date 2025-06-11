---
description: "This function examines a list of fully qualified directories for their current status."
title: SccDirQueryInfo Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccDirQueryInfo
helpviewer_keywords:
- SccDirQueryInfo function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccDirQueryInfo function

This function examines a list of fully qualified directories for their current status.

## Syntax

```cpp
SCCRTN SccDirQueryInfo(
LPVOID  pContext,
LONG    nDirs,
LPCSTR* lpDirNames,
LPLONG  lpStatus
);
```

### Parameters
 pContext

[in] The source control plug-in context structure.

 nDirs

[in] The number of directories selected to be queried.

 lpDirNames

[in] An array of fully qualified paths of the directories to be queried.

 lpStatus

[in, out] An array structure for the source control plug-in to return the status flags (see [Directory status code](../extensibility/directory-status-code-enumerator.md) for details).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The query was successful.|
|SCC_E_OPNOTSUPPORTED|The source code control system does not support this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|Nonspecific failure.|

## Remarks
 The function fills the return array with a bitmask of bits from the `SCC_DIRSTATUS` family (see [Directory status code](../extensibility/directory-status-code-enumerator.md)), one entry for each directory given. The status array is allocated by the caller.

 The IDE uses this function before a directory is renamed to check whether the directory is under source control by querying whether it has a corresponding project. If the directory is not under source control, the IDE can provide the proper warning to the user.

> [!NOTE]
> If a source control plug-in chooses to not implement one or more of the status values, unimplemented bits should be set to zero.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [Directory status code](../extensibility/directory-status-code-enumerator.md)
