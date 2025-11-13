---
title: POPLISTFUNC
description: Learn about the POPLISTFUNC callback function, which is used by the source control plug-in to update a list of files or directories.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- POPDIRLISTFUNC
helpviewer_keywords:
- POPLISTFUNC callback function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# POPLISTFUNC

This callback is supplied to the [SccPopulateList](../extensibility/sccpopulatelist-function.md) by the IDE and is used by the source control plug-in to update a list of files or directories (also supplied to the `SccPopulateList` function).

 When a user chooses the **Get** command in the IDE, the IDE displays a list box of all files that the user can get. Unfortunately, the IDE does not know the exact list of all the files that the user might get; only the plug-in has this list. If other users have added files to the source code control project, these files should appear in the list, but the IDE does not know about them. The IDE builds a list of the files that it thinks the user can get. Before it displays this list to the user, it calls the [SccPopulateList](../extensibility/sccpopulatelist-function.md)`,` giving the source control plug-in a chance to add and delete files from the list.

## Signature
 The source control plug-in modifies the list by calling an IDE-implemented function with the following prototype:

```cpp
typedef BOOL (*POPLISTFUNC) (
   LPVOID pvCallerData,
   BOOL fAddRemove,
   LONG nStatus,
   LPSTR lpFileName
);
```

## Parameters
 pvCallerData
 The `pvCallerData` parameter passed by the caller (the IDE) to the [SccPopulateList](../extensibility/sccpopulatelist-function.md). The source control plug-in should assume nothing about the contents of this parameter.

 fAddRemove
 If `TRUE`, `lpFileName` is a file that should be added to the file list. If `FALSE`, `lpFileName` is a file that should be deleted from the file list.

 nStatus
 Status of `lpFileName` (a combination of the `SCC_STATUS` bits; see [File Status Code](../extensibility/file-status-code-enumerator.md) for details).

 lpFileName
 Full directory path of the file name to add or delete from the list.

## Return value

|Value|Description|
|-----------|-----------------|
|`TRUE`|The plug-in can continue calling this function.|
|`FALSE`|There has been a problem on the IDE side (such as an out of memory situation). The plug-in should stop operation.|

## Remarks
 For each file that the source control plug-in wants to add to or delete from the file list, it calls this function, passing in the `lpFileName`. The `fAddRemove` flag indicates a new file to add to the list or an old file to delete. The `nStatus` parameter gives the status of the file. When the SCC plug-in has finished adding and deleting files, it returns from the [SccPopulateList](../extensibility/sccpopulatelist-function.md) call.

> [!NOTE]
> The `SCC_CAP_POPULATELIST` capability bit is required for Visual Studio.

## See also
- [Callback functions implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
- [SccPopulateList](../extensibility/sccpopulatelist-function.md)
- [File status code](../extensibility/file-status-code-enumerator.md)
