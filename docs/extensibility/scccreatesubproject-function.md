---
title: SccCreateSubProject Function
description: "This function creates a subproject with the given name under an existing parent project specified by the lpParentProjPath argument."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccCreateSubProject
helpviewer_keywords:
- SccCreateSubProject function
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccCreateSubProject function

This function creates a subproject with the given name under an existing parent project specified by the `lpParentProjPath` argument.

## Syntax

```cpp
SCCRTN SccCreateSubProject(
   LPVOID pContext,
   HWND   hWnd,
   LPSTR  lpUser,
   LPCSTR lpParentProjPath,
   LPCSTR lpSubProjName,
   LPSTR  lpAuxProjPath,
   LPSTR  lpSubProjPath
);
```

### Parameters
 pContext

[in] The source control plug-in context pointer.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpUser

[in, out] The username (up to SCC_USER_SIZE, including the NULL terminator).

 lpParentProjPath

[in] A string identifying the path of the parent project (up to SCC_PRJPATH_SIZE, including the NULL terminator).

 lpSubProjName

[in] The suggested subproject name (up to SCC_PRJPATH_SIZE, including the NULL terminator).

 lpAuxProjPath

[in, out] Auxiliary string identifying the project (up to SCC_PRJPATH_SIZE, including the NULL terminator).

 lpSubProjPath

[in, out] Output string identifying the path for the subproject (up to SCC_PRJPATH_SIZE, including the NULL terminator).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Subproject was successfully created.|
|SCC_E_INITIALIZEFAILED|Parent project could not be initialized.|
|SCC_E_INVALIDUSER|The user could not log in to the source control system.|
|SCC_E_COULDNOTCREATEPROJECT|Subproject cannot be created.|
|SCC_E_PROJSYNTAXERR|Invalid project syntax.|
|SCC_E_UNKNOWNPROJECT|The parent project is unknown to the source control plug-in.|
|SCC_E_INVALIDFILEPATH|Invalid or unusable file path.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_CONNECTIONFAILURE|There was a source control plug-in connection problem.|
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|Nonspecific failure.|

## Remarks
 If a subproject with the name already exists, the function can change the default name to create a unique one, for example by adding "_\<number>" to it. The caller must be prepared to accept changes to `lpUser`, `lpSubProjPath`, and `lpAuxProjPath`. The `lpSubProjPath` and `lpAuxProjPath` arguments are then used in a call to the [SccOpenProject](../extensibility/sccopenproject-function.md). They should not be modified by the caller upon return. These strings provide a way for the source control plug-in to track information that it needs to associate with a project. The caller IDE will not display these two parameters upon return, because the plug-in can use a formatted string that might not be suitable for viewing. The function returns a success or failure code and, if successful, fills the variable `lpSubProjPath` with the full project path to the new project.

 This function is similar to the [SccGetProjPath](../extensibility/sccgetprojpath-function.md), except that it silently creates a project rather than prompting the user to select one. When the `SccCreateSubProject` function is called, `lpParentProjName` and `lpAuxProjPath` will not be empty and will correspond to a valid project. These strings are usually received by the IDE from a previous call to the `SccGetProjPath` function or the [SccGetParentProjectPath](../extensibility/sccgetparentprojectpath-function.md).

 The `lpUser` argument is the user name. The IDE will pass in the same user name that it had previously received from `SccGetProjPath`, and the source control plug-in should use the name as a default. If the user already has an open connection with the plug-in, then the plug-in should try to eliminate any prompts to make sure the function works silently. However, if the login fails, the plug-in should prompt the user for a login and, when it receives a valid login, pass the name back in `lpUser`. Because the plug-in may change this string, the IDE will always allocate a buffer of size (SCC_USER_LEN+1 or SCC_USER_SIZE, which includes space for the null terminator). If the string is changed, the new string must be a valid login name (at least as valid as the old string).

## Technical notes for SccCreateSubProject and SccGetParentProjectPath
 Adding solutions and projects to source control has been simplified in Visual Studio to minimize the number of times a user is prompted to select locations in the source control system. These changes are activated by Visual Studio if a source control plug-in supports both of the new functions, `SccCreateSubProject` and `SccGetParentProjectPath`. However, the following registry entry can be used to disable these changes and revert to previous Visual Studio (Source Control Plug-in API Version 1.1) behavior:

 **[HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl] "DoNotCreateSolutionRootFolderInSourceControl"=dword:00000001**

 If this registry entry does not exist or is set to dword:00000000, Visual Studio attempts to use the new functions, `SccCreateSubProject` and `SccGetParentProjectPath`.

 If the registry entry is set to dword:00000001, Visual Studio does not attempt to use these new functions, and the operations of adding to source control work as they did in prior versions of Visual Studio.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccGetParentProjectPath](../extensibility/sccgetparentprojectpath-function.md)
- [SccGetProjPath](../extensibility/sccgetprojpath-function.md)
