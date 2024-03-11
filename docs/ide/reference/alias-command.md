---
title: Alias Command
description: Learn how to use the Alias command to create a new alias for a complete command, complete command and arguments, or another alias.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- tools.alias
helpviewer_keywords:
- aliases, Visual Studio commands
- commands, aliases
- Tools.Alias command
- command aliases
- alias command
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Alias Command

Creates a new alias for a complete command, complete command and arguments, or another alias.

> [!TIP]
> Typing `>alias` without any arguments displays the current list of aliases and their definitions.

## Syntax

```cmd
Tools.Alias [/delete] [/reset] [aliasname] [aliasstring]
```

## Arguments
`aliasname`\
Optional. The name for the new alias. If no value is supplied for `aliasname`, a list of the current aliases and their definitions appears.

`aliasstring`\
Optional. The complete command name or existing alias and any parameters that you want to create as an alias. If no value is supplied for `aliasstring`, the alias name and alias string for the specified alias displays.

## Switches
/delete or /del or /d\
Optional. Deletes the specified alias, removing it from autocompletion.

/reset\
Optional. Resets the list of pre-defined aliases to its original settings. That is, it restores all pre-defined aliases and removes all user-defined aliases.

## Remarks
Since aliases represent commands, they must be located at the beginning of the command line.

When issuing this command, you should include the switches immediately after the command, not after the aliases, otherwise the switch itself will be included as part of the alias string.

The `/reset` switch asks for a confirmation before the aliases are restored. There is no short form of `/reset`.

## Examples
This example creates a new alias, `upper`, for the complete command Edit.MakeUpperCase.

```cmd
>Tools.Alias upper Edit.MakeUpperCase
```

This example deletes the alias, `upper`.

```cmd
>Tools.alias /delete upper
```

This example displays a list of all current aliases and definitions.

```cmd
>Tools.Alias
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
