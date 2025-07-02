---
title: -Command (devenv.exe)
description: Learn how to use the Command devenv command-line switch to execute a specified command after launching the Visual Studio IDE.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Devenv, /Command switch
- /Command Devenv switch
- Command Devenv switch
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Command (devenv.exe)

Executes the specified command after launching the Visual Studio IDE.

## Syntax

```shell
devenv /Command CommandName
```

## Arguments

*CommandName*

Required. The complete name of a Visual Studio command or its alias, enclosed in double quotation marks. For more information about command and alias syntax, see [Visual Studio Commands](../../ide/reference/visual-studio-commands.md).

## Remarks

After startup is complete, the IDE executes the named command.

If an add-in exposes a command, you can use this switch to launch the add-in from the command line. For more information, see [How to: Control add-ins by using the add-in manager](/previous-versions/xwdatdwh(v=vs.140)).

## Example

The first example launches Visual Studio and automatically runs the macro Open Favorite Files.

The second example opens a web browsing tab within the IDE and navigates to the Microsoft Learn site.

The third example creates a new file called `some_file.cs` and opens it in a code editor.

```shell
devenv /command "Macros.MyMacros.Module1.OpenFavoriteFiles"

devenv /command "nf some_file.cs"
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
- [Command window](command-window.md)
