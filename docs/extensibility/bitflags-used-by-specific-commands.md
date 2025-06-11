---
title: Bitflags Used by Specific Commands
description: Learn about the bitflags used by the Source Control Plug-in API, organized by the function that uses them.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- source control plug-ins, bitflags used by specific commands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Bitflags used by specific commands

The behavior of a number of functions in the Source Control Plug-in API can be modified by setting one or more bits in a single value. These values are known as bitflags. The various bitflags used by the Source Control Plug-in API are detailed here, grouped by the function that uses them.

## Checked out flag
 This flag can be set for either the [SccAdd](../extensibility/sccadd-function.md) or [SccCheckin](../extensibility/scccheckin-function.md).

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_KEEP_CHECKEDOUT`|0x1000|Keep the file checked out.|

## Add flags
 These flags are used by the [SccAdd](../extensibility/sccadd-function.md).

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_FILETYPE_AUTO`|0x00|The source control plug-in is expected to automatically detect whether the file is text or binary.|
|`SCC_FILETYPE_TEXT`|0x01|File type is text.|
|`SCC_FILETYPE_BINARY`|0x04|File type is binary. **Note:**  `SCC_FILETYPE_TEXT` and `SCC_FILETYPE_BINARY` flags are mutually exclusive. Set exactly one or neither.|
|`SCC_ADD_STORELATEST`|0x02|Store latest version only (no deltas).|

## Diff flags
 The [SccDiff](../extensibility/sccdiff-function.md) uses these flags to define the scope of a diff operation. The `SCC_DIFF_QD_xxx` flags are mutually exclusive. If any one of them is specified, then no visual feedback is to be given. In a "quick diff" (QD), the plug-in does not determine how the file is different, only if it is different. If none of these flags is specified, a "visual diff" is done; detailed file differences are computed and displayed. If the requested QD is not supported, the plug-in moves to the next best one. For instance, if the IDE requests a checksum, and the plug-in does not support it, the plug-in does a full-contents check (still much faster than a visual display).

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_DIFF_IGNORECASE`|0x0002|Ignore case differences.|
|`SCC_DIFF_IGNORESPACE`|0x0004|Ignore white-space differences. **Note:**  The `SCC_DIFF_IGNORECASE` and `SCC_DIFF_IGNORESPACE` flags are optional bitflags.|
|`SCC_DIFF_QD_CONTENTS`|0x0010|QD by comparing entire file contents.|
|`SCC_DIFF_QD_CHECKSUM`|0x0020|QD by checksum.|
|`SCC_DIFF_QD_TIME`|0x0040|QD by file date/time stamp.|
|`SCC_DIFF_QUICK_DIFF`|0x0070|This is a mask used to check all the QD bitflags. It should not be passed into a function; the three QD bitflags are mutually exclusive. QD always means no display of UI.|

## PopulateList flag
 This flag is used by the [SccPopulateList](../extensibility/sccpopulatelist-function.md) in the `fOptions` parameter.

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_PL_DIR`|0x00000001L|The IDE is passing directories, not files.|

## PopulateDirList flags
 These flags are used by the [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md) in the `fOptions` parameter.

|Option Value|Value|Description|
|------------------|-----------|-----------------|
|SCC_PDL_ONELEVEL|0x0000|Examine only one level of directories for directories (this is the default).|
|SCC_PDL_RECURSIVE|0x0001|Recursively examine all directories under each given directory.|
|SCC_PDL_INCLUDEFILES|0x0002|Include file names in the examination process.|

## OpenProject flags
 These flags are used by the [SccOpenProject](../extensibility/sccopenproject-function.md) in the `dwFlags` parameter.

|Option Value|Value|Description|
|------------------|-----------|-----------------|
|SCC_OP_CREATEIFNEW|0x00000001L|If project doesn't exist in source control, create it. If this flag is not set, prompt user for project to create (unless `SCC_OP_SILENTOPEN` flag is specified).|
|SCC_OP_SILENTOPEN|0x00000002L|Do not prompt user to create a project; just return `SCC_E_UNKNOWNPROJECT`.|

## Get flags
 These flags are used by the [SccGet](../extensibility/sccget-function.md) and the [SccCheckout](../extensibility/scccheckout-function.md).

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_GET_ALL`|0x00000001L|The IDE is passing directories, not files: Get all files in these directories.|
|`SCC_GET_RECURSIVE`|0x00000002L|The IDE is passing directories: Get these directories and all their subdirectories.|

## nOption values
 These flags are used by the [SccSetOption](../extensibility/sccsetoption-function.md) in the `nOption` parameter.

|Flag|Value|Description|
|----------|-----------|-----------------|
|`SCC_OPT_EVENTQUEUE`|0x00000001L|Set status of the event queue.|
|`SCC_OPT_USERDATA`|0x00000002L|Specify user data for `SCC_OPT_NAMECHANGEPFN`.|
|`SCC_OPT_HASCANCELMODE`|0x00000003L|The IDE can handle cancel.|
|`SCC_OPT_NAMECHANGEPFN`|0x00000004L|Set a callback for name changes.|
|`SCC_OPT_SCCCHECKOUTONLY`|0x00000005L|Disable source control plug-in UI checkout and do not set working directory.|
|`SCC_OPT_SHARESUBPROJ`|0x00000006L|Add from the source control system to specify a working directory. Try to share into the associated project if it is a direct descendant.|

## dwVal bitflags
 These flags are used by the [SccSetOption](../extensibility/sccsetoption-function.md) in the `dwVal` parameter.

|Flag|Value|Description|Used by `nOption` value|
|----------|-----------|-----------------|-----------------------------|
|`SCC_OPT_EQ_DISABLE`|0x00L|Suspends event queue activity.|`SCC_OPT_EVENTQUEUE`|
|`SCC_OPT_EQ_ENABLE`|0x01L|Enables event queue logging.|`SCC_OPT_EVENTQUEUE`|
|`SCC_OPT_HCM_NO`|0L|(Default) Has no cancel mode; plug-in must supply if desired.|`SCC_OPT_HASCANCELMODE`|
|`SCC_OPT_HCM_YES`|1L|IDE handles cancel.|`SCC_OPT_HASCANCELMODE`|
|`SCC_OPT_SCO_NO`|0L|(Default) OK to check out from plug-in UI; working directory is set.|`SCC_OPT_SCCCHECKOUTONLY`|
|`SCC_OPT_SCO_YES`|1L|No plug-in UI checkout, no working directory.|`SCC_OPT_SCCCHECKOUTONLY`|

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
