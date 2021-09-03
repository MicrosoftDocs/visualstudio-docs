---
title: Creating Parent Container Folders for Solutions | Microsoft Docs
description: Learn how to use the Source Control Plug-in API Version 1.2 to specify a single root source control destination for all web projects within a solution.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- solutions, creating parent containers
- source control plug-ins, creating parent containers
ms.assetid: 961e68ed-2603-4479-a306-330eda2b2efa
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Create parent container folders for solutions
In the Source Control Plug-in API Version 1.2, a user can specify a single root source control destination for all web projects within the solution. This single root is called a Super Unified Root (SUR).

 In the Source Control Plug-in API Version 1.1, if the user added a multiproject solution to source control, the user was prompted to specify one source control destination for each web project.

## New capability flags
 `SCC_CAP_CREATESUBPROJECT`

 `SCC_CAP_GETPARENTPROJECT`

## New functions
- [SccCreateSubProject](../../extensibility/scccreatesubproject-function.md)

- [SccGetParentProjectPath](../../extensibility/sccgetparentprojectpath-function.md)

 The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] IDE almost always creates an SUR folder when adding a solution to source control. Specifically, it does so in the following cases:

- The project is a file share web project.

- There are different drives for the project and the solution file.

- There are different shares for the project and the solution file.

- Projects were added separately (in a source-controlled solution).

In [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], it is suggested that the name for the SUR folder be the same as the solution name without the extension. The following table summarizes the behavior in the two versions.

|Feature|Source Control Plug-in API Version 1.1|Source Control Plug-in API Version 1.2|
|-------------| - | - |
|Add solution to SCC|SccInitialize()<br /><br /> SccGetProjPath()<br /><br /> SccGetProjPath()<br /><br /> SccOpenProject()|SccInitialize()<br /><br /> SccGetProjPath()<br /><br /> SccCreateSubProject()<br /><br /> SccCreateSubProject()<br /><br /> SccOpenProject()|
|Add project to source-controlled solution|SccGetProjPath()<br /><br /> OpenProject()|SccGetParentProjectPath()<br /><br /> SccOpenProject()<br /><br />  **Note:**  Visual Studio assumes that a solution is a direct child of the SUR.|

## Examples
 The following table lists two examples. In both cases, the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] user is prompted for a destination location for the solution under source control until the  *user_choice* is specified as a destination. When the user_choice is specified, the solution and two projects are added without prompting the user for source control destinations.

|Solution contains|On disk locations|Database default structure|
|-----------------------|-----------------------|--------------------------------|
|*sln1.sln*<br /><br /> Web1<br /><br /> Web2|*C:\Solutions\sln1*<br /><br /> *C:\Inetpub\wwwroot\Web1*<br /><br /> \\\server\wwwroot$\Web2|$/<user_choice>/sln1<br /><br /> $/<user_choice>/C/Web1<br /><br /> $/<user_choice>/Web2|
|*sln1.sln*<br /><br /> Web1<br /><br /> Win1|*C:\Solutions\sln1*<br /><br /> *D:\Inetpub\wwwroot\Web1*<br /><br /> *C:\solutions\sln1\Win1*|$/<user_choice>/sln1<br /><br /> $/<user_choice>/D/web1<br /><br /> $/<user_choice>/sln1/win1|

 The SUR folder and subfolders are created regardless of whether the operation is canceled or fails due to an error. They are not automatically removed in cancel or error conditions.

 [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] defaults to Version 1.1 behavior if the source control plug-in does not return `SCC_CAP_CREATESUBPROJECT` and `SCC_CAP_GETPARENTPROJECT` capability flags. Additionally, users of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] can choose to revert to the Version 1.1 behavior by setting the value of the following key to *dword:00000001*:

 **[HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl] DoNotCreateSolutionRootFolderInSourceControl** = *dword:00000001*

## See also
- [What's new in the Source Control Plug-in API Version 1.2](../../extensibility/internals/what-s-new-in-the-source-control-plug-in-api-version-1-2.md)
