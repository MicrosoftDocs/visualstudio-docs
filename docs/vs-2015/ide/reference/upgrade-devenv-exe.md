---
title: "-Upgrade (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "/upgrade Devenv switch"
  - "Devenv, /upgrade switch"
  - "upgrade Devenv switch"
ms.assetid: 3468045c-5cc9-4157-9a9d-622452145d27
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Upgrade (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Updates the solution file and all of its project files, or the project file specified, to the current [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] formats for these files.

## Syntax

```
devenv SolutionFile | ProjectFile /upgrade
```

## Arguments
 `SolutionFile`
 Required if you are upgrading an entire solution and its projects. The path and name of a solution file. You can enter just the name of the solution file, or a full path and the name of the solution file. If the folder or file named does not yet exist, it will be created.

 `ProjectFile`
 Required if you are upgrading a single project. The path and name of a project file within the solution. You can enter just the name of the project file, or a full path and the name of the project file. If the folder or file named does not yet exist, it will be created.

## Remarks
 Backups are automatically created and copied to a directory named Backup that is created in the current directory.

 Source-controlled solutions or projects must be checked out before they can be upgraded.

 Using the `/upgrade` switch does not start [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. Results of the upgrade can be seen in the Upgrade Report for the development language of the solution or project. No error or usage info is returned. For more information on upgrading projects in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], see [How to: Troubleshoot Unsuccessful Visual Studio Project Upgrades](../../porting/how-to-troubleshoot-unsuccessful-visual-studio-project-upgrades.md).

## Example
 This example upgrades a solution file named "MyProject.sln" in your default folder for [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] solutions.

```
devenv "MyProject.sln" /upgrade
```

## See Also
 [How to: Troubleshoot Unsuccessful Visual Studio Project Upgrades](../../porting/how-to-troubleshoot-unsuccessful-visual-studio-project-upgrades.md)
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
