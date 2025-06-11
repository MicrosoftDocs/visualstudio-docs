---
description: "This function checks in previously checked-out files to the source control system, storing the changes and creating a new version."
title: SccCheckin Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccCheckin
helpviewer_keywords:
- SccCheckin function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccCheckin function

This function checks in previously checked-out files to the source control system, storing the changes and creating a new version. This function is called with a count and an array of names of the files to be checked in.

## Syntax

```cpp
SCCRTN SccCheckin (
   LPVOID    pvContext,
   HWND      hWnd,
   LONG      nFiles,
   LPSTR*    lpFileNames,
   LPCSTR    lpComment,
   LONG      fOptions,
   LPCMDOPTS pvOptions
);
```

### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the SCC plug-in can use as a parent for any dialog boxes that it provides.

 nFiles

[in] Number of files selected to be checked in.

 lpFileNames

[in] Array of fully qualified local path names of files to be checked in.

 lpComment

[in] Comment to be applied to each of the selected files being checked in. This parameter is `NULL` if the source control plug-in should prompt for a comment.

 fOptions

[in] Command flags, either 0 or `SCC_KEEP_CHECKEDOUT`.

 pvOptions

[in] SCC plug-in-specific options.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|File was successfully checked in.|
|SCC_E_FILENOTCONTROLLED|The selected file is not under source code control.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure. File was not checked in.|
|SCC_E_NOTCHECKEDOUT|The user has not checked out the file, so cannot check it in.|
|SCC_E_CHECKINCONFLICT|Checkin could not be performed because:<br /><br /> -   Another user has checked in ahead and `bAutoReconcile` was false.<br /><br /> -or-<br /><br /> -   The auto-merge cannot be done (for example, when files are binary).|
|SCC_E_VERIFYMERGE|File has been auto-merged but has not been checked in pending user verification.|
|SCC_E_FIXMERGE|File has been auto-merged but has not been checked in due to a merge conflict that must be manually resolved.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_I_OPERATIONCANCELED|Operation was canceled before completion.|
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|
|SCC_E_FILENOTEXIST|Local file was not found.|

## Remarks
 The comment applies to all files being checked in. The comment argument can be a `null` string, in which case the source control plug-in can prompt the user for a comment string for each file.

 The `fOptions` argument can be given a value of the `SCC_KEEP_CHECKEDOUT` flag to indicate the user's intent to check the file in and check it out again.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
