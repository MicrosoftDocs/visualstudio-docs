---
title: Error Codes
description: This article contains a list of error codes, values, and descriptions for Source Control Plug-in API functions.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- error codes, source control plug-ins
- source control plug-ins, error codes
- errors [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Error codes

When a Source Control Plug-in API function returns an error, it is expected to be one of the following error codes. All errors are negative, warnings or informational error codes are positive, and success is 0.

|Error Code|Value|Description|
|----------------|-----------|-----------------|
|`SCC_I_SHARESUBPROJOK`|7|Plug-in supports adding files from source control in two steps. For more information, see [SccSetOption](../extensibility/sccsetoption-function.md).|
|`SCC_I_FILEDIFFERS`|6|The local file is different from the file in the source control database (for example, [SccDiff](../extensibility/sccdiff-function.md) may return this value).|
|`SCC_I_RELOADFILE`|5|Local file was changed during the source control operation; the IDE should reload the file if possible.|
|`SCC_I_FILENOTAFFECTED`|4|The file is not affected.|
|`SCC_I_PROJECTCREATED`|3|The Project was created during the source control operation (for example, during a call to [SccOpenProject](../extensibility/sccopenproject-function.md) when `SCC_OP_CREATEIFNEW` flag is specified).|
|`SCC_I_OPERATIONCANCELED`|2|Operation was cancelled.|
|`SCC_I_ADV_SUPPORT`|1|Plug-in supports advanced options for the specified command. For more information, see [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md).|
|`SCC_OK`|0|Success.|
|`SCC_E_INITIALIZEFAILED`|-1|Error: initialization failed.|
|`SCC_E_UNKNOWNPROJECT`|-2|Error: project is unknown.|
|`SCC_E_COULDNOTCREATEPROJECT`|-3|Error: project could not be created.|
|`SCC_E_NOTCHECKEDOUT`|-4|Error: the file is not checked out.|
|`SCC_E_ALREADYCHECKEDOUT`|-5|Error: the file is already checked out.|
|`SCC_E_FILEISLOCKED`|-6|Error: the file is locked.|
|`SCC_E_FILEOUTEXCLUSIVE`|-7|Error: the file is exclusively checked out.|
|`SCC_E_ACCESSFAILURE`|-8|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|`SCC_E_CHECKINCONFLICT`|-9|Error: there was a conflict during check in.|
|`SCC_E_FILEALREADYEXISTS`|-10|Error: the file already exists.|
|`SCC_E_FILENOTCONTROLLED`|-11|Error: the file is not under source control.|
|`SCC_E_FILEISCHECKEDOUT`|-12|Error: the file is checked out.|
|`SCC_E_NOSPECIFIEDVERSION`|-13|Error: there is no specified version.|
|`SCC_E_OPNOTSUPPORTED`|-14|Error: the operation is not supported.|
|`SCC_E_NONSPECIFICERROR`|-15|Nonspecific error.|
|`SCC_E_OPNOTPERFORMED`|-16|Error, the operation was not performed.|
|`SCC_E_TYPENOTSUPPORTED`|-17|Error: the type of the file, for example, binary, is not supported by the source code control system.|
|`SCC_E_VERIFYMERGE`|-18|File has been auto-merged but has not been checked because it is pending user verification.|
|`SCC_E_FIXMERGE`|-19|File has been auto-merged but has not been checked in due to a merge conflict that must be manually resolved.|
|`SCC_E_SHELLFAILURE`|-20|Error due to a shell failure.|
|`SCC_E_INVALIDUSER`|-21|Error: the user is invalid.|
|`SCC_E_PROJECTALREADYOPEN`|-22|Error: the project is already open.|
|`SCC_E_PROJSYNTAXERR`|-23|Project syntax error.|
|`SCC_E_INVALIDFILEPATH`|-24|Error: the file path is invalid.|
|`SCC_E_PROJNOTOPEN`|-25|Error: the project is not open.|
|`SCC_E_NOTAUTHORIZED`|-26|Error: the user is not authorized to perform this operation.|
|`SCC_E_FILESYNTAXERR`|-27|File syntax error.|
|`SCC_E_FILENOTEXIST`|-28|Error, the local file does not exist.|
|`SCC_E_CONNECTIONFAILURE`|-29|Error: there was a connection failure.|
|`SCC_E_UNKNOWNERROR`|-30|Unknown error.|
|`SCC_E_BACKGROUNDGETINPROGRESS`|-31|Background get operation is currently in progress.|

## Macros provided for quick checking

```cpp
IS_SCC_ERROR(rtn) (((rtn) < 0) ? TRUE : FALSE)
IS_SCC_SUCCESS(rtn) (((rtn) == SCC_OK) ? TRUE : FALSE)
IS_SCC_WARNING(rtn) (((rtn) > 0) ? TRUE : FALSE)
```

## Remarks
 All Source Control Plug-in API functions (except the [SccAdd](../extensibility/sccadd-function.md), [SccCheckin](../extensibility/scccheckin-function.md), and [SccDiff](../extensibility/sccdiff-function.md)) are expected to succeed when the local files that are passed as arguments do not exist in the working folder. For example, the IDE may issue a call to the [SccCheckout](../extensibility/scccheckout-function.md) or [SccUncheckout](../extensibility/sccuncheckout-function.md) on a file that does not exist in the working folder, but exists in the source control system. This call would succeed. Only when there is no file in the working folder or in the source control system is the function expected to fail.

 Certain functions, such as `SccAdd` and `SccCheckin`, should specifically return `SCC_E_FILENOTEXIST` when the file in the working folder does not exist. Other functions are expected to succeed when the working file does not exist, if the functions operate on a valid file name in the source control system.

 The source control plug-in should make no assumptions regarding privileges on a file in the working folder, even if the plug-in had marked the file read-only during some operation. A file in the working folder can be moved, deleted, and changed outside the plug-in's control.

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
