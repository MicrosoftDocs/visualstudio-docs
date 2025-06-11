---
description: "This function adds a list of files from source control to the currently opened project."
title: SccAddFilesFromSCC Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccAddFilesFromSCC
helpviewer_keywords:
- SccAddFilesFromSCC function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccAddFilesFromSCC function

This function adds a list of files from source control to the currently opened project.

## Syntax

```cpp
SCCRTN SccAddFilesFromSCC(
   LPVOID  pContext,
   HWND    hWnd,
   LPSTR   lpUser,
   LPSTR   lpAuxProjPath,
   LONG    cFiles,
   LPCSTR* lpFilePaths,
   LPCSTR  lpDestination,
   LPCSTR  lpComment,
   LPBOOL  pbResults
);
```

### Parameters
 pContext

[in] The source control plug-in context pointer.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpUser

[in, out] The username (up to SCC_USER_SIZE, including the null terminator).

 lpAuxProjPath

[in, out] Auxiliary string identifying the project (up to `SCC_PRJPATH_`SIZE, including the null terminator).

 cFiles

[in] Number of files given by `lpFilePaths`.

 lpFilePaths

[in, out] Array of file names to add to the current project.

 lpDestination

[in] The destination path where the files are to be written.

 lpComment

[in] The comment to be applied to each of the files being added.

 pbResults

[in, out] Array of flags that are set to indicate success (nonzero or TRUE) or failure (zero or FALSE) for each file (size of the array must be at least `cFiles` long).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_E_PROJNOTOPEN|Project is not open.|
|SCC_E_OPNOTPERFORMED|Connection is not to the same project as specified by `lpAuxProjPath.`|
|SCC_E_NOTAUTHORIZED|User is not authorized to update the database.|
|SCC_E_NONSPECIFICERROR|Unknown error.|
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
