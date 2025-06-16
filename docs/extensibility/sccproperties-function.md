---
description: "This function displays source control properties for a file or project."
title: SccProperties Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccProperties
helpviewer_keywords:
- SccProperties function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccProperties Function

This function displays source control properties for a file or project.

## Syntax

```cpp
SCCRTN SccProperties (
   LPVOID pvContext,
   HWND   hWnd,
   LPCSTR lpFileName
);
```

#### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpFileName

[in] The fully qualified path name of the file or project.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Properties were successfully displayed.|
|SCC_I_RELOADFILE|The version control system has modified the file properties, so the IDE should reload this file.|
|SCC_E_PROJNOTOPEN|The specified project has not been opened in source control.|
|SCC_E_NOTAUTHORIZED|The user is not authorized to view properties of this file or project.|
|SCC_E_FILENOTCONTROLLED|The specified file or project is not under source control.|
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|An unknown or general error occurred.|

## Remarks
 The source control plug-in displays the properties in its own dialog box.

 The properties are defined by the source control plug-in and may differ from plug-in to plug-in. If the plug-in allows the user to change the source control properties of a file, it should return `SCC_I_RELOAD` to signal the IDE that this file or project needs to be reloaded.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
