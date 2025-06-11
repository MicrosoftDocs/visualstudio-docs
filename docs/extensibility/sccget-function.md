---
description: "This function retrieves a copy of one or more files for viewing and compiling but not for editing."
title: SccGet Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGet
helpviewer_keywords:
- SccGet function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGet function

This function retrieves a copy of one or more files for viewing and compiling but not for editing. In most systems, the files are tagged as read-only.

## Syntax

```cpp
SCCRTN SccGet(
   LPVOID    pvContext,
   HWND      hWnd,
   LONG      nFiles,
   LPCSTR*   lpFileNames,
   LONG      fOptions,
   LPCMDOPTS pvOptions
);
```

### Parameters
 pvContext

[in] The context structure of the source control plug-in.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 nFiles

[in] Number of files specified in the `lpFileNames` array.

 lpFileNames

[in] Array of fully qualified names of files to be retrieved.

 fOptions

[in] Command flags (`SCC_GET_ALL`, `SCC_GET_RECURSIVE`).

 pvOptions

[in] Source control plug-in-specific options.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Success of get operation.|
|SCC_E_FILENOTCONTROLLED|The file is not under source control.|
|SCC_E_OPNOTSUPPORTED|The source control system does not support this operation.|
|SCC_E_FILEISCHECKEDOUT|Cannot get the file that the user currently has checked out.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NOSPECIFIEDVERSION|Specified an invalid version or date/time.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure; file was not synchronized.|
|SCC_I_OPERATIONCANCELED|Operation cancelled before completion.|
|SCC_E_NOTAUTHORIZED|The user is not authorized to perform this operation.|

## Remarks
 This function is called with a count and an array of names of the files to be retrieved. If the IDE passes the flag `SCC_GET_ALL`, this means that the items in `lpFileNames` are not files but directories, and that all files under source control in the given directories are to be retrieved.

 The `SCC_GET_ALL` flag can be combined with the `SCC_GET_RECURSIVE` flag to retrieve all files in the given directories and all subdirectories as well.

> [!NOTE]
> `SCC_GET_RECURSIVE` should never be passed without `SCC_GET_ALL`. Also, note that if directories *C:\A* and *C:\A\B* are both passed on a recursive get, *C:\A\B* and all its subdirectories will actually be retrieved twice. It is the IDE's responsibility—and not the source control plug-in's—to make sure that duplicates such as this are kept out of the array.

 Finally, even if a source control plug-in specified the `SCC_CAP_GET_NOUI` flag on initialization, indicating that it does not have a user interface for a Get command, this function may still be called by the IDE to retrieve files. The flag simply means that the IDE does not display a Get menu item and that the plug-in is not expected to provide any UI.

## Rename files and SccGet
 Situation: a user checks out a file, for example, *a.txt*, and modifies it. Before *a.txt* can be checked in, a second user renames *a.txt* to *b.txt* in the source control database, checks out *b.txt*, makes some modifications to the file, and checks the file in. The first user wants the changes made by the second user so the first user renames their local version of *a.txt* file to *b.txt* and does a get on the file. However, the local cache that keeps track of version numbers still thinks the first version of *a.txt* is stored locally and so source control cannot resolve the differences.

 There are two ways to resolve this situation where the local cache of source control versions becomes out of sync with the source control database:

1. Do not allow renaming a file in the source control database that is currently checked out.

2. Do the equivalent of "delete old" followed by "add new". The following algorithm is one way to accomplish this.

    1. Call the [SccQueryChanges](../extensibility/sccquerychanges-function.md) function to learn about the renaming of *a.txt* to *b.txt* in the source control database.

    2. Rename the local *a.txt* to *b.txt*.

    3. Call the `SccGet` function for both *a.txt* and *b.txt*.

    4. Because *a.txt* does not exist in the source control database, the local version cache is purged of the missing *a.txt* version information.

    5. The *b.txt* file being checked out is merged with the contents of the local *b.txt* file.

    6. The updated *b.txt* file can now be checked in.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [Bitflags used by specific commands](../extensibility/bitflags-used-by-specific-commands.md)
