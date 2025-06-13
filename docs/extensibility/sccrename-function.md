---
description: "This function renames a file in the source control system."
title: SccRename Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccRename
helpviewer_keywords:
- SccRename function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccRename Function

This function renames a file in the source control system.

## Syntax

```cpp
SCCRTN SccRename(
   LPVOID pvContext,
   HWND   hWnd,
   LPCSTR lpFileName,
   LPCSTR lpNewName
);
```

#### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpFileName

[in] The fully qualified file name of the file being renamed.

 lpNewName

[in] The fully qualified new name. If the directory path is different, then the file has moved from one subdirectory to another.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The renaming operation completed successfully.|
|SCC_E_PROJNOTOPEN|The project is not open under source control.|
|SCC_E_FILENOTCONTROLLED|The file is not under source control.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|
|SCC_E_NOTAUTHORIZED|The user is not authorized to complete this operation.|
|SCC_E_COULDNOTCREATEPROJECT|The project could not be created as part of the renaming process.|
|SCC_E_OPNOTPERFORMED|The operation was not performed.|
|SCC_E_NONSPECIFICERROR|An unspecified or general error occurred.|

## Remarks
 This function can be used to rename a file or move it from one location to another in the source control system. The source control plug-in should not attempt to access the file on disk. It is the IDE's responsibility to rename the local file.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
