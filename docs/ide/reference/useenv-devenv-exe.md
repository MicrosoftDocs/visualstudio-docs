---
title: -UseEnv (devenv.exe)
description: Learn how to use the UseEnv devenv command-line switch to start Visual Studio and load certain environment variables for compilation.
ms.date: 01/10/2019
ms.topic: reference
f1_keywords:
- VC.Project.UseEnvVars.ExcludePath
- VC.Project.UseEnvVars.LibraryPath
- VC.Project.UseEnvVars.SourcePath
- VC.Project.UseEnvVars.Include
- VC.Project.UseEnvVars.Path
- VC.Project.UseEnvVars.ReferencePath
helpviewer_keywords:
- UseEnv switch
- /UseEnv Devenv switch
- Devenv, /UseEnv
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /UseEnv (devenv.exe)

Starts Visual Studio and loads certain environment variables for compilation.

> [!NOTE]
> This switch is installed with the **Desktop development with C++** workload.

## Syntax

```shell
devenv /UseEnv {SolutionName|ProjectName}
```

## Arguments

- *SolutionName*

  The full path and name of a solution file.

- *ProjectName*

  The full path and name of a project file.

## Remarks

This switch affects the Visual Studio IDE in the project properties for **VC++ Directories**. If you specify the `/UseEnv` switch, the **VC++ Directories** node shows the values for the PATH, INCLUDE, LIBPATH, and LIB environment variables. (It also shows values for **Source Directories** and **Exclude Directories**.) Otherwise, the node replaces the environment variables with five directory values: **Executable Directories**, **Include Directories**, **Reference Directories**, **Library Directories**, and **Library WinRT Directories**.

> [!TIP]
> You access the project properties by right-clicking a C++ project and selecting **Properties**. In the **Property Pages** dialog box, select **Configuration Properties** and then **VC++ Directories**.

When a project name is specified with this switch, the tool displays the environment variables for all projects within the project's parent solution.

## Example

The following example starts Visual Studio and loads environment variables into the property pages of the `MySolution` solution.

```shell
devenv.exe /useenv "%USERPROFILE%\source\repos\MySolution\MySolution.sln"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [VC++ Directories Property Page (Windows)](/cpp/build/reference/vcpp-directories-property-page)
