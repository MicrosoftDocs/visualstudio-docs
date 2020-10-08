---
title: "-Setup (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "setup Devenv switch"
  - "/setup Devenv switch"
  - "Devenv, /setup switch"
ms.assetid: 87608b7f-a156-400c-80f5-fc823f843e61
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Setup (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Forces [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] to merge the resource metadata that describes menus, toolbars, and command groups, from all available VSPackages.

## Syntax

```
devenv /setup
```

## Remarks
 This switch takes no arguments. The `devenv /setup` command is typically given as the last step of the installation process. Use of the `/setup` switch does not start [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].

 You must run `devenv` as an administrator in order to use the [/setup (devenv.exe)](../../ide/reference/setup-devenv-exe.md) and [/InstallVSTemplates (devenv.exe)](../../ide/reference/installvstemplates-devenv-exe.md) switches.

## Example
 This example shows the last step in the installation of a version of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] that includes VSPackages.

```
devenv /setup
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
