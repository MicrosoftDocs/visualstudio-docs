---
title: Command Window
description: Learn how you can use the Command window to execute commands or aliases directly in the Visual Studio IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.CommandWindow
helpviewer_keywords:
- IDE, Command window
- Mark mode in Command window
- Command window
- Command mode in Command window
- IDE Command window
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Command Window

The **Command** window is used to execute commands or aliases directly in the Visual Studio integrated development environment (IDE). You can execute both menu commands and commands that do not appear on any menu. To display the **Command** window, choose **Other Windows** from the **View** menu, and select **Command Window**.

## Displaying the Values of Variables
To check the value of a variable `varA`, use the [Print Command](../../ide/reference/print-command.md):

```cmd
>Debug.Print varA
```

The question mark (?) is an alias for `Debug.Print`, so this command can also be written:

```cmd
>? varA
```

Both versions of this command will return the value of the variable `varA`.

## Entering Commands
The greater than symbol (`>`) appears at the left edge of the Command window as a prompt for new lines. Use the UP ARROW and DOWN ARROW keys to scroll through previously issued commands.

|Task|Solution|Example|
|----------|--------------|-------------|
|Evaluate an expression.|Preface the expression with a question mark (`?`).|`? myvar`|
|Switch to an Immediate window.|Enter `immed` into the window without the greater than sign (>)|`immed`|
|Switch back to the Command window from an Immediate window.|Enter `cmd` into the window.|`>cmd`|

The following shortcuts help you navigate while in Command mode.

|Action|Cursor location|Keybinding|
|------------| - |----------------|
|Cycle through the list of previously entered commands.|Input line|UP ARROW & DOWN ARROW|
|Scroll up the window.|Command window contents|CTRL+UP ARROW|
|Scroll down the window.|Command window contents|DOWN ARROW or CTRL+DOWN ARROW|

> [!TIP]
> You can copy all or part of a previous command to the input line by scrolling to it, highlighting all or part of it, and then pressing ENTER.

## Mark Mode
When you click on any previous line in the **Command** window, you shift automatically into Mark mode. This allows you to select, edit, and copy the text of previous commands as you would in any text editor, and paste them into the current line.

## The Equals (=) Sign
The window used to enter the `EvaluateStatement` command determines whether an equals sign (=) is interpreted as a comparison operator or as an assignment operator.

In the **Command** window, an equals sign (=) is interpreted as a comparison operator. You cannot use assignment operators in the **Command** window. So, for example, if the values of variables `varA` and `varB` are different, then the command `>Debug.EvaluateStatement(varA=varB)` will return a value of `False`.

In the **Immediate** window, by contrast, an equals sign (=) is interpreted as an assignment operator. So, for example, the command `>Debug.EvaluateStatement(varA=varB)` will assign to variable `varA` the value of variable `varB`.

## Parameters, Switches, and Values
Some Visual Studio commands have required and optional arguments, switches and values. Certain rules apply when dealing with such commands. The following is an example of a rich command to clarify the terminology.

```cmd
Edit.ReplaceInFiles /case /pattern:regex var[1-3]+ oldpar
```

In this example,

- `Edit.ReplaceInFiles` is the command

- `/case` and `/pattern:regex` are switches (prefaced with the slash [/] character)

- `regex` is the value of the `/pattern` switch; the `/case` switch has no value

- `var[1-3]+` and `oldpar` are parameters

    > [!NOTE]
    > Any command, parameter, switch, or value that contains spaces must have double quotation marks on either side.

The position of switches and parameters can be interchanged freely on the command line with the exception of the [Shell](../../ide/reference/shell-command.md) command, which requires its switches and parameters in a specific order.

Nearly every switch supported by a command has two forms: a short (one character) form and a long form. Multiple short-form switches can be combined into a group. For example, `/p /g /m` can be expressed alternately as `/pgm`.

If short-form switches are combined into a group and given a value, that value applies to every switch. For example, `/pgm:123` equates to `/p:123 /g:123 /m:123`. An error occurs if any of the switches in the group does not accept a value.

## Escape Characters
A caret (^) character in a command line means that the character immediately following it is interpreted literally, rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example,

```cmd
>Edit.Find ^^t /regex
```

A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it is ignored. The example shown here demonstrates how to search for the pattern "^t".

## Use Quotes for Path Names with Spaces
If, for example, you want to open a file that has a path containing spaces, you must put double quotes around the path or path segment that contains spaces: **C:\\"Program Files"** or **"C:\Program Files"**.

## See also

- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
