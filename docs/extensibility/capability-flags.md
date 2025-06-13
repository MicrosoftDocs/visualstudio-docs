---
title: Capability Flags
description: Learn about the SCC_CAP_xxx flags that indicate the capabilities of a source control plug-in and the SCC_EXCAP_xxx flags that indicate extended capabilities.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- source control plug-ins, capability flags
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Capability flags

The SCC_CAP_*xxx* flags are bit flags used to indicate the capabilities of a source control plug-in. The SCC_EXCAP_*xxx* flags are incremental flags that indicate extended capabilities and resolve to integer values.

|Capability Code|Value|Description|
|---------------------|-----------|-----------------|
|`SCC_CAP_REMOVE`|0x00000001L|Supports the [SccRemove](../extensibility/sccremove-function.md) and command.|
|`SCC_CAP_RENAME`|0x00000002L|Supports the [SccRename](../extensibility/sccrename-function.md) and command.|
|`SCC_CAP_DIFF`|0x00000004L|Supports the [SccDiff](../extensibility/sccdiff-function.md) and command.|
|`SCC_CAP_HISTORY`|0x00000008L|Supports the [SccHistory](../extensibility/scchistory-function.md) and command.|
|`SCC_CAP_PROPERTIES`|0x00000010L|Supports the [SccProperties](../extensibility/sccproperties-function.md) and command.|
|`SCC_CAP_RUNSCC`|0x00000020L|Supports the [SccRunScc](../extensibility/sccrunscc-function.md) and command.|
|`SCC_CAP_GETCOMMANDOPTIONS`|0x00000040L|Supports the [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) and command.|
|`SCC_CAP_QUERYINFO`|0x00000080L|Supports the [SccQueryInfo](../extensibility/sccqueryinfo-function.md) and command.|
|`SCC_CAP_GETEVENTS`|0x00000100L|Supports the [SccGetEvents](../extensibility/sccgetevents-function.md) and command.|
|`SCC_CAP_GETPROJPATH`|0x00000200L|Supports the [SccGetProjPath](../extensibility/sccgetprojpath-function.md) and command.|
|`SCC_CAP_ADDFROMSCC`|0x00000400L|Supports the [SccAddFromScc](../extensibility/sccaddfromscc-function.md) and command.|
|`SCC_CAP_COMMENTCHECKOUT`|0x00000800L|Supports a comment on checkout.|
|`SCC_CAP_COMMENTCHECKIN`|0x00001000L|Supports a comment on checkin.|
|`SCC_CAP_COMMENTADD`|0x00002000L|Supports a comment on Add.|
|`SCC_CAP_COMMENTREMOVE`|0x00004000L|Supports a comment on Remove.|
|`SCC_CAP_TEXTOUT`|0x00008000L|Writes text to an IDE-provided output function.|
|`SCC_CAP_ADD_STORELATEST`|0x00200000L|Supports storing files without deltas.|
|`SCC_CAP_HISTORY_MULTFILE`|0x00400000L|Supports multiple file history.|
|`SCC_CAP_IGNORECASE`|0x00800000L|Supports case-insensitive file comparison.|
|`SCC_CAP_IGNORESPACE`|0x01000000L|Supports file comparison that ignores white space.|
|`SCC_CAP_POPULATELIST`|0x02000000L|Supports finding extra files.|
|`SCC_CAP_COMMENTPROJECT`|0x04000000L|Supports comments on create project.|
|`SCC_CAP_DIFFALWAYS`|0x10000000L|Supports diff in all states if under control.|
|`SCC_CAP_GET_NOUI`|0x20000000L|Plug-in does not support a UI for Get, but IDE may still call [SccGet](../extensibility/sccget-function.md).|
|`SCC_CAP_REENTRANT`|0x40000000L|Plug-in is reentrant and thread-safe. In version 1.0, no plug-ins were assumed to be reentrant and thread-safe. If a 1.1 plug-in sets this bit, the host is allowed to open multiple projects in parallel.|

## Capability bits added in version 1.2

|Capability Code|Value|Description|
|---------------------|-----------|-----------------|
|`SCC_CAP_CREATESUBPROJECT`|0x00010000L|Supports the [SccCreateSubProject](../extensibility/scccreatesubproject-function.md).|
|`SCC_CAP_GETPARENTPROJECT`|0x00020000L|Supports the [SccGetParentProjectPath](../extensibility/sccgetparentprojectpath-function.md).|
|`SCC_CAP_BATCH`|0x00040000L|Supports the [SccBeginBatch](../extensibility/sccbeginbatch-function.md) and [SccEndBatch](../extensibility/sccendbatch-function.md).|
|`SCC_CAP_DIRECTORYSTATUS`|0x00080000L|Supports the [SccDirQueryInfo](../extensibility/sccdirqueryinfo-function.md).|
|`SCC_CAP_DIRECTORYDIFF`|0x00100000L|Supports the [SccDirDiff](../extensibility/sccdirdiff-function.md).|
|`SCC_CAP_MULTICHECKOUT`|0x08000000L|Supports multiple checkouts on a file and the [SccIsMultiCheckoutEnabled](../extensibility/sccismulticheckoutenabled-function.md).|
|`SCC_CAP_SCCFILE`|0x80000000L|Supports the *MSSCCPRJ.SCC* file (subject to user/administrator override) and the [SccWillCreateSccFile](../extensibility/sccwillcreatesccfile-function.md).|

## Capability bits added in version 1.3
 These flags are passed one at a time to the [SccGetExtendedCapabilities](../extensibility/sccgetextendedcapabilities-function.md) function to determine whether the capability is supported.

|Extended Capability Code|Value|Description|
|------------------------------|-----------|-----------------|
|`SCC_EXCAP_CHECKOUT_LOCALVER`|1|Supports the `SCC_CHECKOUT_LOCALVER` option for checkouts.|
|`SCC_EXCAP_BACKGROUND_GET`|2|Supports the [SccBackgroundGet](../extensibility/sccbackgroundget-function.md).|
|`SCC_EXCAP_ENUM_CHANGED_FILES`|3|Supports the [SccEnumChangedFiles](../extensibility/sccenumchangedfiles-function.md).|
|`SCC_EXCAP_POPULATELIST_DIR`|4|Supports finding extra directories.|
|`SCC_EXCAP_QUERYCHANGES`|5|Supports enumerating file changes.|
|`SCC_EXCAP_ADD_FILES_FROM_SCC`|6|Supports the [SccAddFilesFromSCC](../extensibility/sccaddfilesfromscc-function.md).|
|`SCC_EXCAP_GET_USER_OPTIONS`|7|Supports the [SccGetUserOption](../extensibility/sccgetuseroption-function.md).|
|`SCC_EXCAP_THREADSAFE_QUERY_INFO`|8|Supports calling SccQueryInfo on multiple threads.|
|`SCC_EXCAP_REMOVE_DIR`|9|Supports the SccRemoveDir function.|
|`SCC_EXCAP_DELETE_CHECKEDOUT`|10|Can delete checked-out files.|
|`SCC_EXCAP_RENAME_CHECKEDOUT`|11|Can rename checked-out files.|

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
