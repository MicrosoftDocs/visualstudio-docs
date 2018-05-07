---
title: -Command (devenv.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /command switch"
  - "/command Devenv switch"
ms.assetid: 13c20cd6-f09d-400a-8b7b-ecc266a32cef
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Command (devenv.exe)
Executes the specified command after launching the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE).

## Syntax

```cmd
devenv /command CommandName
```

## Arguments
 `CommandName`
 Required. The complete name of a [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../../ide/reference/visual-studio-commands.md).

## Remarks
 After startup is complete, the IDE executes the named command. If you use this switch, the IDE does not display the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Start Page on startup.

 If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [How to: Control Add-Ins By Using the Add-In Manager](http://msdn.microsoft.com/Library/4f60444a-cb48-4cdb-8df4-941f6419aeeb).

## Example
 This example launches [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] and automatically runs the macro Open Favorite Files.

```cmd
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"
```

## See Also

- [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)