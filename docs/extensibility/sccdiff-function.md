---
description: "This function displays (or optionally just checks for) the differences between the current file (on the local disk) and its last checked-in version in the source control system."
title: SccDiff Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccDiff
helpviewer_keywords:
- SccDiff function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccDiff function

This function displays (or optionally just checks for) the differences between the current file (on the local disk) and its last checked-in version in the source control system.

## Syntax

```cpp
SCCRTN SccDiff(
   LPVOID    pvContext,
   HWND      hWnd,
   LPCSTR    lpFileName,
   LONG      fOptions,
   LPCMDOPTS pvOptions
);
```

### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpFileName

[in] File name for which the difference is requested.

 fOptions

[in] Command flags. See Remarks for details.

 pvOptions

[in] Source control plug-in-specific options.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The working copy and server version are identical.|
|SCC_I_FILESDIFFERS|The working copy differs from the version under source control.|
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|
|SCC_E_FILENOTCONTROLLED|The file is not under source control.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure; file difference was not obtained.|
|SCC_E_FILENOTEXIST|The local file was not found.|

## Remarks
 This function serves two different purposes. By default, it displays a list of changes to a file. The source control plug-in opens its own window, in whatever format it chooses, to display the differences between the user's file on disk and the latest version of the file under source control.

 Alternatively, the IDE may simply need to determine whether a file has changed. For example, the IDE may need to determine whether it is safe to check out a file without informing the user. In that case, the IDE passes in the `SCC_DIFF_CONTENTS` flag. The source control plug-in must check the file on disk, byte by byte, against the source-controlled file and return a value indicating whether the two files are different without displaying anything to the user.

 As a performance optimization, the source control plug-in may use an alternative based on a checksum or a timestamp instead of the byte-by-byte comparison called for by `SCC_DIFF_CONTENTS`: these forms of comparison are obviously faster but less reliable. Not all source control systems may support these alternative comparison methods, and the plug-in may have to fall back to a contents comparison. All source control plug-ins must, at a minimum, support a contents comparison.

> [!NOTE]
> The quick difference flags are mutually exclusive. It is valid to pass no flags, but it is not valid to simultaneously pass more than one. `SCC_DIFF_QUICK_DIFF`, which is a mask that combines all flags, can be used to test, but it should never be passed as a parameter.

|`fOption`|Meaning|
|---------------|-------------|
|SCC_DIFF_IGNORECASE|Case-insensitive comparison (may be used for either quick or visual difference).|
|SCC_DIFF_IGNORESPACE|Ignores white space (may be used for either quick or visual difference).|
|SCC_DIFF_QD_CONTENTS|Silently compares the file, byte by byte.|
|SCC_DIFF_QD_CHECKSUM|Silently compares the file via a checksum when supported. If not supported, falls back to a comparison of contents.|
|SCC_DIFF_QD_TIME|Silently compares the file via its timestamp when supported. If not supported, falls back to a comparison of contents.|

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
