---
title: MSBuild Response Files
description: Learn about MSBuild response or .rsp files, text files that contain MSBuild.exe command-line switches.
ms.date: 02/09/2024
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- response files, MSBuild
- MSBuild, response files
- MSBuild, .rsp files
- .rsp files
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild response files

Response (`.rsp`) files are text files that contain *MSBuild.exe* command-line switches. Each switch can be on a separate line or all switches can be on one line. Comment lines are prefaced with a **#** symbol. The **@** switch is used to pass another response file to *MSBuild.exe*.

## MSBuild.rsp

The autoresponse file is a special `.rsp` file that *MSBuild.exe* automatically uses when building a project. This file, *MSBuild.rsp*, must be in the same directory as *MSBuild.exe*, otherwise it isn't found. You can edit this file to specify default command-line switches to *MSBuild.exe*. For example, if you use the same logger every time you build a project, you can add the **-logger** switch to *MSBuild.rsp*, and *MSBuild.exe* uses the logger every time a project is built.

## Directory.Build.rsp

In version 15.6 and later, MSBuild searches parent directories of the project for a file named *Directory.Build.rsp*. This file can be helpful in a source code repository to provide default arguments during command-line builds.  It can also be used to specify the command-line arguments of hosted builds.

You can use the syntax `%MSBuildThisFileDirectory%` in a *Directory.Build.rsp* file, to refer to the directory that contains the *Directory.Build.rsp* file. This syntax requires percent signs on all operating systems, like [Environment.ExpandEnvironmentVariables](/dotnet/api/system.environment.expandenvironmentvariables), even though `MSBuildThisFileDirectory` isn't an environment variable.

> [!NOTE] Visual Studio (the IDE) **does not apply** `.rsp` response files—such as `MSBuild.rsp` or `Directory.Build.rsp`—when building within the IDE. These files are only processed when you run MSBuild via the **`msbuild.exe`** or **`dotnet build`** command‑line tools :contentReference[oaicite:2]{index=2}.


## Disabling response files

To disable automatically processing the default response files *MSBuild.rsp* and *Directory.Build.rsp* in a particular invocation of MSBuild, use the command-line option `-noAutoResponse`. Any response files referenced explicitly using the @-syntax on the command-line are still processed. See [MSBuild command line reference](msbuild-command-line-reference.md). 

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Command-line reference](../msbuild/msbuild-command-line-reference.md)
