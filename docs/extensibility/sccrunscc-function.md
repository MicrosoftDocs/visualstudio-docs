---
description: "This function invokes the source control administration tool."
title: SccRunScc Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccRunScc
helpviewer_keywords:
- SccRunScc function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccRunScc Function

This function invokes the source control administration tool.

## Syntax

```cpp
SCCRTN SccRunScc(
   LPVOID  pvContext,
   HWND    hWnd,
   LONG    nFiles,
   LPCSTR* lpFileNames
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

[in] Array of selected file names.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The source control administration tool was successfully invoked.|
|SCC_I_OPERATIONCANCELED|The operation was cancelled.|
|SCC_E_INITIALIZEFAILED|Failed to initialize the source control system.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|
|SCC_E_CONNECTIONFAILURE|Failed to connect to the source control system.|
|SCC_E_FILENOTCONTROLLED|The selected file is not under source control.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|

## Remarks
 This function allows the caller to access the full range of features of the source control system through an external administration tool. If the source control system has no user interface, the source control plug-in can implement an interface to perform necessary administration functions.

 This function is called with a count and an array of file names for the currently selected files. If the administration tool supports it, the list of files can be used to preselect files in the administration interface; otherwise, the list can be ignored.

 This function is typically invoked when the user selects the **Launch \<Source Control Server>** from the **File** -> **Source Control** menu. This **Launch** menu option can be always disabled or even hidden by setting a registry entry. See [How to: Install a Source Control Plug-in](../extensibility/internals/how-to-install-a-source-control-plug-in.md) for details. This function is called only if [SccInitialize](../extensibility/sccinitialize-function.md) returns the `SCC_CAP_RUNSCC` capability bit (see [Capability Flags](../extensibility/capability-flags.md) for details on this and other capability bits).

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [How to: Install a Source Control Plug-in](../extensibility/internals/how-to-install-a-source-control-plug-in.md)
- [Capability Flags](../extensibility/capability-flags.md)
- [SccInitialize](../extensibility/sccinitialize-function.md)
