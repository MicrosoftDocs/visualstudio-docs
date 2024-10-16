---
title: SccGetParentProjectPath Function
description: "This function determines the parent project path of a specified project."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetParentProjectPath
helpviewer_keywords:
- SccGetParentProjectPath function
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGetParentProjectPath function

This function determines the parent project path of a specified project. This function is called when the user is adding a Visual Studio project to source control.

## Syntax

```cpp
SCCRTN SccGetParentProjectPath(
   LPVOID pContext,
   HWND   hWnd,
   LPSTR  lpUser,
   LPCSTR lpProjPath,
   LPSTR  lpAuxProjPath,
   LPSTR  lpParentProjPath
);
```

### Parameters
 pContext

[in] The source control plug-in context pointer.

 hWnd

[in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.

 lpUser

[in, out] The user name (up to SCC_USER_SIZE, including the NULL terminator).

 lpProjPath

[in] String identifying the project path (up to SCC_PRJPATH_SIZE, including the NULL terminator).

 lpAuxProjPath

[in, out] Auxiliary string identifying the project (up to SCC_PRJPATH_SIZE, including the NULL terminator).

 lpParentProjPath

[in, out] Output string identifying the parent project path (up to SCC_PRJPATH_SIZE, including the NULL terminator).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Parent project path was successfully obtained.|
|SCC_E_INITIALIZEFAILED|Project could not be initialized.|
|SCC_E_INVALIDUSER|The user could not log in to the source control plug-in.|
|SCC_E_UNKNOWNPROJECT|Project is unknown to the source control plug-in.|
|SCC_E_INVALIDFILEPATH|Invalid or unusable file path.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|
|SCC_E_PROJSYNTAXERR|Invalid project syntax.|
|SCC_E_CONNECTIONFAILURE|Store connection problem.|
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|Nonspecific failure.|

## Remarks
 This function returns a success or failure code and, if successful, fills the variable `lpParentProjPath` with the full project path to the specified project.

 This function returns the parent project path of an existing project. For the root project, the function returns the project path that was passed in (that is, the same root project path). Note that a project path is a string that is meaningful only to the source control plug-in.

 The IDE is prepared to accept changes to the `lpUser` and `lpAuxProjPath` parameters as well. The IDE will persist these strings and pass them to the [SccOpenProject](../extensibility/sccopenproject-function.md) when the user opens this project in the future. These strings, therefore, provide a way for the source control plug-in to track information it needs to associate with a project.

 This function is similar to the [SccGetProjPath](../extensibility/sccgetprojpath-function.md), except that it does not prompt the user to select a project. It also never creates a new project but works only with an existing project.

 When `SccGetParentProjectPath` is called, `lpProjPath` and `lpAuxProjPath` will not be empty and will correspond to a valid project. These strings are usually received by the IDE from a previous call to the `SccGetProjPath` function.

 The `lpUser` argument is the user name. The IDE will pass in the same user name that it had previously received from the `SccGetProjPath` function, and the source control plug-in should use the name as a default. If the user already has an open connection with the plug-in, then the plug-in should try to eliminate any prompts to make sure the function works silently. However, if the login fails, the plug-in should prompt the user for a login and, when it receives a valid login, pass the name back in `lpUser`. Because the plug-in may change this string, the IDE will always allocate a buffer of size (`SCC_USER_LEN`+1). If the string is changed, the new string must be a valid login name (at least as valid as the old string).

## Technical notes for SccCreateSubProject and SccGetParentProjectPath
 Adding solutions and projects to source control has been simplified in Visual Studio to minimize the number of times a user is prompted to select locations in the source control system. These changes are activated by Visual Studio if a source control plug-in supports both of the new functions, the [SccCreateSubProject](../extensibility/scccreatesubproject-function.md) and the `SccGetParentProjectPath` function. However, the following registry entry can be used to disable these changes and revert to the previous Visual Studio (Source Control Plug-in API Version 1.1) behavior:

 **[HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl] "DoNotCreateSolutionRootFolderInSourceControl"=dword:00000001**

 If this registry entry does not exist or is set to dword:00000000, Visual Studio attempts to use the new functions, `SccCreateSubProject` and `SccGetParentProjectPath`.

 If the registry entry is set to dword:00000001, Visual Studio does not attempt to use these new functions, and the operations of adding to source control work as they did in prior versions of Visual Studio.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccCreateSubProject](../extensibility/scccreatesubproject-function.md)
- [SccGetProjPath](../extensibility/sccgetprojpath-function.md)
