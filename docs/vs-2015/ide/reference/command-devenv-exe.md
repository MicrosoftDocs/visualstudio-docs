---
title: "-Command (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /command switch"
  - "/command Devenv switch"
ms.assetid: 13c20cd6-f09d-400a-8b7b-ecc266a32cef
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Command (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Executes the specified command after launching the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] integrated development environment (IDE).

## Syntax

```
devenv /command CommandName
```

## Arguments
 `CommandName`
 Required. The complete name of a [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../../ide/reference/visual-studio-commands.md).

## Remarks
 After startup is complete, the IDE executes the named command. If you use this switch, the IDE does not display the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] Start Page on startup.

 If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [How to: Control Add-Ins By Using the Add-In Manager](https://msdn.microsoft.com/library/4f60444a-cb48-4cdb-8df4-941f6419aeeb).

## Example
 This example launches [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and automatically runs the macro Open Favorite Files.

```
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
 [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
