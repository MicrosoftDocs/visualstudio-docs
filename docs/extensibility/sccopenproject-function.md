---
title: SccOpenProject Function
description: "This function opens an existing source control project or creates a new one."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccOpenProject
helpviewer_keywords:
- SccOpenProject function
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccOpenProject Function

This function opens an existing source control project or creates a new one.

## Syntax

```cpp
SCCRTN SccOpenProject (
   LPVOID        pvContext,
   HWND          hWnd,
   LPSTR         lpUser,
   LPCSTR        lpProjName,
   LPCSTR        lpLocalProjPath,
   LPSTR         lpAuxProjPath,
   LPCSTR        lpComment,
   LPTEXTOUTPROC lpTextOutProc,
   LONG          dwFlags
);
```

#### Parameters
 pvContext

[in] The source control plug-in context structure.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpUser

[in, out] The name of the user (not to exceed SCC_USER_SIZE, including the NULL terminator).

 lpProjName

[in] The string identifying the name of the project.

 lpLocalProjPath

[in] The path to the working folder for the project.

 lpAuxProjPath

[in, out]An optional auxiliary string identifying the project (not to exceed SCC_AUXPATH_SIZE, including the NULL terminator).

 lpComment

[in] Comment to a new project that is being created.

 lpTextOutProc

[in] An optional callback function to display text output from the source control plug-in.

 dwFlags

[in] Signals whether a new project needs to be created if the project is unknown to the source control plug-in. Value can be a combination of `SCC_OP_CREATEIFNEW` and `SCC_OP_SILENTOPEN.`

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Success in opening the project.|
|SCC_E_INITIALIZEFAILED|Project could not be initialized.|
|SCC_E_INVALIDUSER|The user could not log in to the source control system.|
|SCC_E_COULDNOTCREATEPROJECT|The project did not exist prior to the call;  the `SCC_OPT_CREATEIFNEW` flag was set, but the project could not be created.|
|SCC_E_PROJSYNTAXERR|Invalid project syntax.|
|SCC_E_UNKNOWNPROJECT|The project is unknown to the source control plug-in, and the `SCC_OPT_CREATEIFNEW` flag was not set.|
|SCC_E_INVALIDFILEPATH|Invalid or unusable file path.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_NONSPECFICERROR|A nonspecific failure; the source control system was not initialized.|

## Remarks
 The IDE may pass in a user name (`lpUser`), or it may simply pass in a pointer to an empty string. If there is a user name, the source control plug-in should use it as a default. However, if no name was passed, or if the login failed with the given name, the plug-in should prompt the user to log in and will return the valid name in `lpUser` when it receives a valid login`.` Because the plug-in may change the user name string, the IDE will always allocate a buffer of size (`SCC_USER_LEN`+1 or SCC_USER_SIZE, which includes space for the null terminator).

> [!NOTE]
> The first action the IDE may be required to perform may be a call to the `SccOpenProject` function or the [SccGetProjPath](../extensibility/sccgetprojpath-function.md). For this reason, both of them have an identical `lpUser` parameter.

 `lpAuxProjPath` and `lpProjName` are read from the solution file, or they are returned from a call to the `SccGetProjPath` function. These parameters contain the strings that the source control plug-in associates with the project and are meaningful only to the plug-in. If no such strings are in the solution file and the user has not been prompted to browse (which would return a string through the `SccGetProjPath` function), the IDE passes empty strings for both `lpAuxProjPath` and `lpProjName`, and expects these values to be updated by the plug-in when this function returns.

 `lpTextOutProc` is a pointer to a callback function provided by the IDE to the source control plug-in for the purpose of displaying command result output. This callback function is described in detail in [LPTEXTOUTPROC](../extensibility/lptextoutproc.md).

> [!NOTE]
> If the source control plug-in intends to take advantage of this, it must have set the `SCC_CAP_TEXTOUT` flag in the [SccInitialize](../extensibility/sccinitialize-function.md). If that flag was not set, or if the IDE does not support this feature, `lpTextOutProc` will be `NULL`.

 The `dwFlags` parameter controls the outcome in the event that the project being opened does not currently exist. It consists of two bitflags, `SCC_OP_CREATEIFNEW` and `SCC_OP_SILENTOPEN`. If the project being opened already exists, the function simply opens the project and returns `SCC_OK`. If the project does not exist and if the `SCC_OP_CREATEIFNEW` flag is on, the source control plug-in can create the project in the source control system, open it, and return `SCC_OK`. If the project does not exist, and if the `SCC_OP_CREATEIFNEW` flag is off, the plug-in should then check for the `SCC_OP_SILENTOPEN` flag. If that flag is not on, the plug-in may prompt the user for a project name. If that flag is on, the plug-in should simply return `SCC_E_UNKNOWNPROJECT`.

## Calling Order
 In the normal course of events, the [SccInitialize](../extensibility/sccinitialize-function.md) would be called first to open a source control session. A session may consist of a call to `SccOpenProject`, followed by other Source Control Plug-in API function calls, and will terminate with a call to the [SccCloseProject](../extensibility/scccloseproject-function.md). Such sessions may be repeated several times before the [SccUninitialize](../extensibility/sccuninitialize-function.md) is called.

 If the source control plug-in sets the `SCC_CAP_REENTRANT` bit in `SccInitialize`, then the above session sequence may be repeated many times in parallel. Different `pvContext` structures track the different sessions, in which each `pvContext` is associated with one open project at a time. Based on the `pvContext` parameter, the plug-in can determine which project is referenced in any particular call. If the capability bit `SCC_CAP_REENTRANT` is not set, nonreentrant source control plug-ins are limited in their ability to work with multiple projects.

> [!NOTE]
> The `SCC_CAP_REENTRANT` bit was introduced in version 1.1 of the Source Control Plug-in API. It is not set or is ignored in version 1.0, and all version 1.0 source control plug-ins are assumed to be nonreentrant.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccCloseProject](../extensibility/scccloseproject-function.md)
- [SccGetProjPath](../extensibility/sccgetprojpath-function.md)
- [SccInitialize](../extensibility/sccinitialize-function.md)
- [SccUninitialize](../extensibility/sccuninitialize-function.md)
- [Restrictions on String Lengths](../extensibility/restrictions-on-string-lengths.md)
- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)
