---
title: List Registers Command
description: Learn about the List Registers command and how it displays the value of the selected registers and lets you modify the list of registers to show.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- debug.listregisters
helpviewer_keywords:
- list registers command
- Debug.ListRegisters command
- ListRegisters command
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# List Registers Command

Displays the value of the selected registers and lets you modify the list of registers to show.

## Syntax

```cmd
Debug.ListRegisters [/Display [{register|registerGroup}...]] [/List]
[/Watch [{register|registerGroup}...]]
[/Unwatch [{register|registerGroup}...]]
```

## Switches
/Display [{`register`&#124;`registerGroup`}...]

Displays the values of the specified `register` or `registerGroup`. If no `register` or `registerGroup` is specified, the default list of registers is displayed. If no switch is specified, the behavior is the same. For example:

`Debug.ListRegisters /Display eax`

is equivalent to

`Debug.ListRegisters eax`

/List

Displays all register groups in the list.

/Watch [{`register`&#124;`registerGroup`}...]

Adds one or more `register` or `registerGroup` values to the list.

/Unwatch [{`register`&#124;`registerGroup`}...]

Removes one or more `register` or `registerGroup` values from the list.

## Remarks
The alias `r` can be used in place of `Debug.ListRegisters`.

## Example
This example uses the `Debug.ListRegisters` alias `r` to display the values of the register group `Flags`.

```cmd
r /Display Flags
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Debugging Basics: Registers Window](../../debugger/debugging-basics-registers-window.md)
- [How to: Use the Registers Window](../../debugger/how-to-use-the-registers-window.md)
