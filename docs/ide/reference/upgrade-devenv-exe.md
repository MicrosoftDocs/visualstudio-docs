---
title: "-Upgrade (devenv.exe) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "/upgrade Devenv switch"
  - "Devenv, /upgrade switch"
  - "upgrade Devenv switch"
ms.assetid: 3468045c-5cc9-4157-9a9d-622452145d27
caps.latest.revision: 18
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# /Upgrade (devenv.exe)
Updates the solution file and all of its project files, or the project file specified, to the current [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] formats for these files.  
  
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
  
 Using the `/upgrade` switch does not start [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. Results of the upgrade can be seen in the Upgrade Report for the development language of the solution or project. No error or usage info is returned. For more information on upgrading projects in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], see [Port, Migrate, and Upgrade Visual Studio Projects](../../porting/port-migrate-and-upgrade-visual-studio-projects.md).  
  
## Example  
 This example upgrades a solution file named "MyProject.sln" in your default folder for [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] solutions.  
  
```  
devenv "MyProject.sln" /upgrade  
```  
  
## See Also  
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)