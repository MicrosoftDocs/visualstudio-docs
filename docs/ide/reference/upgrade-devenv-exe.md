---
title: -Upgrade (devenv.exe)
description: Learn how to use the Upgrade devenv command-line switch to update the solution file and all of its project files, or the project file specified, to the current Visual Studio formats for these files.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- /upgrade Devenv switch
- Devenv, /upgrade switch
- upgrade Devenv switch
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# /Upgrade (devenv.exe)

Updates the solution file and all of its project files, or the project file specified, to the current Visual Studio formats for these files.

## Syntax

```shell
devenv {SolutionFile|ProjectFile} /Upgrade [/Out OutputFilename]
```

## Arguments

- *SolutionFile*

  Required if you're upgrading an entire solution and its projects. The path and name of a solution file. You can enter just the name of the solution file, or a full path and the name of the solution file. If the folder or file named doesn't yet exist, it's created.

- *ProjectFile*

  Required if you're upgrading a single project. The path and name of a project file within the solution. You can enter just the name of the project file, or a full path and the name of the project file. If the folder or file named doesn't yet exist, it's created.

- `/Out` *OutputFilename*

  Optional. The name of a file that you want to send the tool's output to. If the file already exists, the tool appends the output to the end of the file.

## Remarks

Backups are automatically created and copied to a directory named Backup that's created in the current directory.

Source-controlled solutions or projects must be checked out before they can be upgraded.

Using the `/Upgrade` switch doesn't open Visual Studio. Results of the upgrade can be seen in the Upgrade Report for the development language of the solution or project. No error or usage info is returned. For more information on upgrading projects in Visual Studio, see [Port, Migrate, and Upgrade Visual Studio Projects](/visualstudio/releases/2022/port-migrate-and-upgrade-visual-studio-projects).

## Example

This example upgrades a solution file named "MyProject.sln".

```shell
devenv "%USERPROFILE%\source\repos\MyProject\MyProject.sln" /upgrade
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
