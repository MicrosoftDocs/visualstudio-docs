---
description: "This function deletes files from the source control system."
title: SccRemove Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccRemove
helpviewer_keywords:
- SccRemove function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccRemove Function

This function deletes files from the source control system.

## Syntax

```cpp
SCCRTN SccRemove(
   LPVOID    pvContext,
   HWND      hWnd,
   LONG      nFiles,
   LPCSTR*   lpFileNames,
   LPCSTR    lpComment,
   LONG      fOptions,
   LPCMDOPTS pvOptions
);
```

#### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 nFiles

[in] Number of files specified in the `lpFileNames` array.

 lpFileNames

[in] Array of fully qualified local path names of files to be removed.

 lpComment

[in] The comment to be applied to each file being removed.

 fOptions

[in] Command flags (unused).

 pvOptions

[in] Source control plug-in-specific options.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Removal was successful.|
|SCC_E_FILENOTCONTROLLED|The selected file is not under source control.|
|SCC_E_OPNOTSUPPORTED|The source control system does not support this operation.|
|SCC_E_ISCHECKEDOUT|Cannot remove a file because a user currently has it checked out.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure; file was not removed.|
|SCC_I_OPERATIONCANCELED|The operation was cancelled before completion.|

## Remarks
 This function removes the files from the source control system but does not delete them from the user's local hard drive.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
