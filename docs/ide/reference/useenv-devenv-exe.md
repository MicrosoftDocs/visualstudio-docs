---
title: -UseEnv (devenv.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "VC.Project.UseEnvVars.ExcludePath"
  - "VC.Project.UseEnvVars.LibraryPath"
  - "VC.Project.UseEnvVars.SourcePath"
  - "VC.Project.UseEnvVars.Include"
  - "VC.Project.UseEnvVars.Path"
  - "VC.Project.UseEnvVars.ReferencePath"
helpviewer_keywords:
  - "UseEnv switch"
  - "/UseEnv Devenv switch"
  - "Devenv, /UseEnv"
ms.assetid: 2dd14603-a61b-42d2-ba31-427a0ee8a799
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /UseEnv (devenv.exe)

Starts Visual Studio and loads environmental variables into the **VC++ Directories** dialog box.

> [!NOTE]
> This switch is installed with the **Desktop development with C++** workload.

## Syntax

```shell
Devenv /useenv
```

## Example

The following example starts Visual Studio and loads environment variables into the **VC++ Directories** dialog box.

```shell
Devenv.exe /useenv
```

## See also

* [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)