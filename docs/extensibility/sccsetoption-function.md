---
title: SccSetOption Function
description: "This function sets options that control the behavior of the source control plug-in."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccSetOption
helpviewer_keywords:
- SccSetOption function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccSetOption Function

This function sets options that control the behavior of the source control plug-in.

## Syntax

```cpp
SCCRTN SccSetOption(
   LPVOID pvContext,
   LONG   nOption,
   LONG   dwVal
);
```

#### Parameters
 pvContext

[in] The source control plug-in context structure.

 nOption

[in] The option that is being set.

 dwVal

[in] Settings for the option.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The option was successfully set.|
|SCC_I_SHARESUBPROJOK|Returned if `nOption` was `SCC_OPT_SHARESUBPROJ` and the source control plug-in allows the IDE to set the destination folder.|
|SCC_E_OPNOTSUPPORTED|The option was not set and should not be relied upon.|

## Remarks
 The IDE calls this function to control the behavior of the source control plug-in. The first parameter, `nOption`, indicates the value that is being set, while the second, `dwVal`, indicates what to do with that value. The plug-in stores this information associated with a `pvContext``,` so the IDE must call this function after calling the [SccInitialize](../extensibility/sccinitialize-function.md) (but not necessarily after each call to the [SccOpenProject](../extensibility/sccopenproject-function.md)).

 Summary of the options and their values:

|`nOption`|`dwValue`|Description|
|---------------|---------------|-----------------|
|`SCC_OPT_EVENTQUEUE`|`SCC_OPT_EQ_DISABLE`<br /><br /> `SCC_OPT_EQ_ENABLE`|Enables/disables background event queuing.|
|`SCC_OPT_USERDATA`|Arbitrary value|Specifies a user value to be passed to the [OPTNAMECHANGEPFN](../extensibility/optnamechangepfn.md) callback function.|
|`SCC_OPT_HASCANCELMODE`|`SCC_OPT_HCM_NO`<br /><br /> `SCC_OPT_HCM_YES`|Indicates whether the IDE currently supports canceling an operation.|
|`SCC_OPT_NAMECHANGEPFN`|Pointer to the [OPTNAMECHANGEPFN](../extensibility/optnamechangepfn.md) callback function|Sets a pointer to a name-change callback function.|
|`SCC_OPT_SCCCHECKOUTONLY`|`SCC_OPT_SCO_NO`<br /><br /> `SCC_OPT_SCO_YES`|Indicates whether the IDE allows the checking out of its files manually (through the source control user interface) or whether they must be checked out only through the source control plug-in.|
|`SCC_OPT_SHARESUBPROJ`|N/A|If the source control plug-in allows the IDE to specify the local project folder, the plug-in returns `SCC_I_SHARESUBPROJOK`.|

## SCC_OPT_EVENTQUEUE
 If `nOption` is `SCC_OPT_EVENTQUEUE`, the IDE is disabling (or re-enabling) background processing. For instance, during a compile, the IDE might instruct the source control plug-in to stop on-idle processing of any kind. After the compile, it would re-enable background processing to keep the plug-in's event queue up to date. Corresponding to the `SCC_OPT_EVENTQUEUE` value of `nOption`, there are two possible values for `dwVal`, namely, `SCC_OPT_EQ_ENABLE` and `SCC_OPT_EQ_DISABLE`.

## SCC_OPT_HASCANCELMODE
 If the value for `nOption` is `SCC_OPT_HASCANCELMODE`, the IDE allows users to cancel long operations. Setting `dwVal` to `SCC_OPT_HCM_NO` (the default) indicates that the IDE has no cancel mode. The source control plug-in must offer its own Cancel button if it wants the user to be able to cancel. `SCC_OPT_HCM_YES` indicates that the IDE provides the ability to cancel an operation, so the SCC plug-in does not need to display its own Cancel button. If the IDE sets `dwVal` to `SCC_OPT_HCM_YES`, it is prepared to respond to `SCC_MSG_STATUS` and `DOCANCEL` messages sent to the `lpTextOutProc` callback function (see [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)). If the IDE does not set this variable, the plug-in should not send these two messages.

## SCC_OPT_NAMECHANGEPFN
 If nOption is set to `SCC_OPT_NAMECHANGEPFN`, and both the source control plug-in and the IDE allow it, the plug-in can actually rename or move a file during a source control operation. The `dwVal` will be set to a function pointer of type [OPTNAMECHANGEPFN](../extensibility/optnamechangepfn.md). During a source control operation, the plug-in can call this function, passing in three parameters. These are the old name (with fully qualified path) of a file, the new name (with fully qualified path) of that file, and a pointer to information that has relevance to the IDE. The IDE sends in this last pointer by calling `SccSetOption` with `nOption` set to `SCC_OPT_USERDATA`, with `dwVal` pointing to the data. Support for this function is optional. A VSSCI plug-that uses this ability must initialize its function pointer and user data variables to `NULL`, and it must not call a rename function unless it has been given one. It should also be prepared to hold the value it was given or to change it in response to a new call to `SccSetOption`. This will not happen in the middle of a source control command operation, but it may happen between commands.

## SCC_OPT_SCCCHECKOUTONLY
 If nOption is set to `SCC_OPT_SCCCHECKOUTONLY`, the IDE is indicating that the files in the currently open project should never be checked out manually through the source control system's user interface. Instead, the files should be checked out only through the source control plug-in under IDE control. If `dwValue` is set to `SCC_OPT_SCO_NO`, it means that the files should be treated normally by the plug-in and can be checked out through the source control UI. If `dwValue` is set to `SCC_OPT_SCO_YES`, then only the plug-in is allowed to check out files, and the source control system's UI should not be invoked. This is for situations where the IDE might have "pseudo-files" that make sense to check out only through the IDE.

## SCC_OPT_SHARESUBPROJ
 If `nOption` is set to `SCC_OPT_SHARESUBPROJ`, the IDE is testing whether the source control plug-in can use a specified local folder when adding files from source control. The value of the `dwVal` parameter does not matter in this case. If the plug-in allows the IDE to specify the local destination folder where the files will be added from source control when the [SccAddFromScc](../extensibility/sccaddfromscc-function.md) is called, then the plug-in must return `SCC_I_SHARESUBPROJOK` when the `SccSetOption` function is called. The IDE then uses the `lplpFileNames` parameter of the `SccAddFromScc` function to pass in the destination folder. The plug-in uses that destination folder to place the files added from source control. If the plug-in does not return `SCC_I_SHARESUBPROJOK` when the `SCC_OPT_SHARESUBPROJ` option is set, the IDE assumes that the plug-in is able to add files only in the current local folder.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccInitialize](../extensibility/sccinitialize-function.md)
- [SccOpenProject](../extensibility/sccopenproject-function.md)
- [SccAddFromScc](../extensibility/sccaddfromscc-function.md)
- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)
- [OPTNAMECHANGEPFN](../extensibility/optnamechangepfn.md)
