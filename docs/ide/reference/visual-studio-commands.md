---
title: Commands
description: Learn about the various commands you have access to in Visual Studio.
ms.date: 03/10/2022
ms.topic: reference
helpviewer_keywords:
- Visual Studio, commands
- commands, Visual Studio
- command syntax
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Visual Studio commands

You can enter Visual Studio commands in the [**Command** window](../../ide/reference/command-window.md), [**Immediate** window](../../ide/reference/immediate-window.md), or **Find/Command** box. In each case, the greater than sign (`>`) indicates that a command, rather than a search or debug operation, follows.

You can find a complete list of commands and their syntax on the **Keyboard** page in **Tools** > **Options** > **Environment**.

In localized versions of the IDE, command names can be entered either in the native language of the IDE or in English. For example, you can type either `File.NewFile` or `Fichier.NouveauFichier` in the French IDE to execute the same command.

Many commands have aliases. For a list of command aliases, see [Command aliases](../../ide/reference/visual-studio-command-aliases.md). For command keyboard shortcuts, see [Default keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md).

## Escape character

The escape character for Visual Studio commands is a caret (^). The escape character means that the character immediately following it is interpreted literally rather than as a control character. This can be used to embed straight quotation marks ("), spaces, leading slashes, carets, or any other literal characters in a parameter or switch value, with the exception of switch names. For example:

```
>Edit.Find ^^t /regex
```

A caret functions the same whether it is inside or outside quotation marks. If a caret is the last character on the line, it's ignored.

## Commands with arguments

The following commands take arguments or switches:

| Command Name | Description |
| - | - |
| [Add Existing Item](../../ide/reference/add-existing-item-command.md) | Adds an existing file to the current solution and opens it. |
| [Add Existing Project](../../ide/reference/add-existing-project-command.md) | Adds an existing project to the current solution. |
| [Alias](../../ide/reference/alias-command.md) | Creates a new alias for a complete command, complete command and arguments, or even another alias. |
| [Evaluate Statement](../../ide/reference/evaluate-statement-command.md) | Evaluates and displays the given statement. |
| [Find](../../ide/reference/find-command.md) | Searches files using a subset of the options available on the **Find and Replace** control. |
| [Find in Files](../../ide/reference/find-in-files-command.md) | Searches files using a subset of the options available on the [Find in Files](../../ide/find-in-files.md). |
| [Go To](../../ide/reference/go-to-command.md) | Moves the cursor to the specified line. |
| [List Call Stack](../../ide/reference/list-call-stack-command.md) | Displays the current call stack. |
| [List Disassembly](../../ide/reference/list-disassembly-command.md) | Begins the debug process and allows you to specify how errors are handled. |
| [List Memory](../../ide/reference/list-memory-command.md) | Displays the contents of the specified range of memory. |
| [List Modules](../../ide/reference/list-modules-command.md) | Lists the modules for the current process. |
| [List Registers](../../ide/reference/list-registers-command.md) | Displays a list of registers. |
| [List Source](../../ide/reference/list-source-command.md) | Displays the specified lines of source code. |
| [List Threads](../../ide/reference/list-threads-command.md) | Displays a list of the threads in the current program. |
| [Log Command Window Output](../../ide/reference/log-command-window-output-command.md) | Copies all input and output from the Command window into a file. |
| [New File](../../ide/reference/new-file-command.md) | Creates a new file and adds it to the currently selected project. |
| [Open File](../../ide/reference/open-file-command.md) | Opens an existing file and allows you to specify an editor. |
| [Open Project](../../ide/reference/open-project-command.md) | Opens an existing project and allows you to add the project to the current solution. |
| [Print](../../ide/reference/print-command.md) | Evaluates the expression and displays the results or the specified text. |
| [Quick Watch Command](../../ide/reference/quick-watch-command.md) | Displays the selected or specified text in the **Expression** field of the **Quick Watch** dialog box. |
| [Replace](../../ide/reference/replace-command.md) | Replaces text in files using a subset of the options available on the **Find and Replace** control. |
| [Replace in Files](../../ide/reference/replace-in-files-command.md) | Replaces text in files using a subset of the options available in the [Replace in Files](../../ide/replace-in-files.md). |
| [Set Current Stack Frame](../../ide/reference/set-current-stack-frame-command.md) | Allows you to view a particular stack frame. |
| [Set Current Thread](../../ide/reference/set-current-thread-command.md) | Allows you to view a particular thread. |
| [Set Radix](../../ide/reference/set-radix-command.md) | Determines the number of bytes to view. |
| [Shell](../../ide/reference/shell-command.md) | Launches programs from within Visual Studio as though the command has been executed from the command prompt. |
| [ShowWebBrowser Command](../../ide/reference/showwebbrowser-command.md) | Displays the URL you specify in a web browser window either within the integrated development environment (IDE) or external to the IDE. |
| [Start](../../ide/reference/start-command.md) | Begins the debug process and allows you to specify how errors are handled. |
| [Path](../../ide/reference/symbol-path-command.md) | Sets the list of directories for the debugger to search for symbols. |
| [Toggle Breakpoint](../../ide/reference/toggle-breakpoint-command.md) | Turns the breakpoint either on or off, depending on its current state, at the current location in the file. |
| [Watch Command](../../ide/reference/watch-command.md) | Creates and opens a specified instance of a **Watch** window. |

## See also

- [Command window](../../ide/reference/command-window.md)
- [Find/Command box](../../ide/find-command-box.md)
- [Visual Studio command aliases](../../ide/reference/visual-studio-command-aliases.md)
