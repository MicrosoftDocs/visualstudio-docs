---
title: "-InstallVSTemplates (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /InstallVSTemplates switch"
  - "/InstallVSTemplates Devenv switch"
  - "InstallVSTemplates switch"
ms.assetid: 1fb466f6-7955-4535-a840-d93eb8aaa492
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# /InstallVSTemplates (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Registers project or item templates that are located in *\<Visual Studio installation path>*\Common7\IDE\ProjectTemplates\ or *\<Visual Studio installation path>*\Common7\IDE\ItemTemplates\ so that they can be accessed through the **New Project** and **Add New Item** dialog boxes.

> [!WARNING]
> This switch is supported only for Visual Studio partner development, and is not available in Express editions. You must run devenv as an administrator in order to use the [/Setup (devenv.exe)](../../ide/reference/setup-devenv-exe.md) and [/InstallVSTemplates (devenv.exe)](../../ide/reference/installvstemplates-devenv-exe.md) switches. For more information, see [User Permissions](../../ide/user-permissions-and-visual-studio.md).

## Syntax

```
devenv.exe /InstallVSTemplates
```

## Remarks

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
