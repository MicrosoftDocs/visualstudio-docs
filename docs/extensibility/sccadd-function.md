---
description: "This function adds new files to the source control system."
title: SccAdd Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccAdd
helpviewer_keywords:
- SccAdd function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccAdd function

This function adds new files to the source control system.

## Syntax

```cpp
SCCRTN SccAdd(
   LPVOID    pvContext,
   HWND      hWnd,
   LONG      nFiles,
   LPCSTR*   lpFileNames,
   LPCSTR    lpComment,
   LONG*     pfOptions,
   LPCMDOPTS pvOptions
);
```

### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 nFiles

[in] Number of files selected to be added to the current project as given in the `lpFileNames` array.

 lpFileNames

[in] Array of fully qualified local names of files to be added.

 lpComment

[in] The comment to be applied to all of the files being added.

 pfOptions

[in] Array of command flags, provided on a per-file basis.

 pvOptions

[in] Source control plug-in-specific options.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The add operation was successful.|
|SCC_E_FILEALREADYEXISTS|The selected file is already under source control.|
|SCC_E_TYPENOTSUPPORTED|The type of the file (for example, binary) is not supported by the source control system.|
|SCC_E_OPNOTSUPPORTED|The source control system does not support this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure; add not performed.|
|SCC_I_OPERATIONCANCELED|The operation was cancelled before completion.|
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|
|SCC_E_FILENOTEXIST|Local file was not found.|

## Remarks
 The usual `fOptions` are replaced here by an array, `pfOptions`, with one `LONG` option specification per file. This is because the file type may vary from file to file.

> [!NOTE]
> It is invalid to specify both `SCC_FILETYPE_TEXT` and `SCC_FILETYPE_BINARY` options for the same file, but it is valid to specify neither. Setting neither is the same as setting `SCC_FILETYPE_AUTO`, in which case the source control plug-in autodetects the file type.

 Below is the list of flags used in the `pfOptions` array:

|Option|Value|Meaning|
|------------|-----------|-------------|
|SCC_FILETYPE_AUTO|0x00|The source control plug-in should detect the file type.|
|SCC_FILETYPE_TEXT|0x01|Indicates an ASCII text file.|
|SCC_FILETYPE_BINARY|0x02|Indicates a file type other than ASCII text.|
|SCC_ADD_STORELATEST|0x04|Stores only the latest copy of the file, no deltas.|
|SCC_FILETYPE_TEXT_ANSI|0x08|Treats the file as ANSI text.|
|SCC_FILETYPE_UTF8|0x10|Treats the file as Unicode text in UTF8 format.|
|SCC_FILETYPE_UTF16LE|0x20|Treats the file as Unicode text in UTF16 Little Endian format.|
|SCC_FILETYPE_UTF16BE|0x40|Treats the file as Unicode text in UTF16 Big Endian format.|

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
