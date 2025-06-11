---
description: "This function displays the history of the specified files."
title: SccHistory Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccHistory
helpviewer_keywords:
- SccHistory function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccHistory Function

This function displays the history of the specified files.

## Syntax

```cpp
SCCRTN SccHistory(
   LPVOID    pvContext,
   HWND      hWnd,
   LONG      nFiles,
   LPCSTR*   lpFileNames,
   LONG      fOptions,
   LPCMDOPTS pvOptions
);
```

#### Parameters
 `pvContext`

[in] The source control plug-in context structure.

 `hWnd`

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 `nFiles`

[in] Number of files specified in the `lpFileName` array.

 `lpFileName`

[in] Array of fully qualified names of files.

 `fOptions`

[in] Command flags (currently not used).

 `pvOptions`

[in] Source control plug-in-specific options.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Version history was successfully obtained.|
|SCC_I_RELOADFILE|The source control system actually modified the file on disk while fetching the history (for instance, by getting an old version of it), so the IDE should reload this file.|
|SCC_E_FILENOTCONTROLLED|The file is not under source control.|
|SCC_E_OPNOTSUPPORTED|The source control system does not support this operation.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_PROJNOTOPEN|The project is has not been opened.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure. File history could not be obtained.|

## Remarks
 The source control plug-in can display its own dialog box to show the history of each file, using `hWnd` as the parent window. Alternatively, the optional text output callback function supplied to the [SccOpenProject](../extensibility/sccopenproject-function.md) can be used, if it is supported.

 Note that under certain circumstances, the file being examined may change during the execution of this call. For example, the Visual SourceSafe history command gives the user a chance to get an old version of the file. In such a case, the source control plug-in returns `SCC_I_RELOAD` to warn the IDE that it needs to reload the file.

> [!NOTE]
> If the source control plug-in does not support this function for an array of files, only the file history for the first file can be displayed.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccOpenProject](../extensibility/sccopenproject-function.md)
