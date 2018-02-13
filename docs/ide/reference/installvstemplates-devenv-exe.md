---
title: "devenv.exe InstallVSTemplates switch | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Devenv, /InstallVSTemplates switch"
  - "/InstallVSTemplates Devenv switch"
  - "InstallVSTemplates switch"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# /InstallVSTemplates (devenv.exe)

The /InstallVSTemplates switch registers project or item templates that are located in *\<Visual Studio installation path>*\Common7\IDE\ProjectTemplates\ or *\<Visual Studio installation path>*\Common7\IDE\ItemTemplates\ so that they can be accessed through the **New Project** and **Add New Item** dialog boxes.

> [!WARNING]
> This switch is supported only for Visual Studio partner development. You must run devenv as an administrator in order to use the [/Setup (devenv.exe)](../../ide/reference/setup-devenv-exe.md) and [/InstallVSTemplates (devenv.exe)](../../ide/reference/installvstemplates-devenv-exe.md) switches. For more information, see [User Permissions](../../ide/user-permissions-and-visual-studio.md).

## Syntax

```
devenv.exe /InstallVSTemplates
```

## See also

[Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)