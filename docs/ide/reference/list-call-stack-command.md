---
title: List Call Stack Command
description: Learn about the List Call Stack command and how it displays the current call stack.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.listcallstack"
helpviewer_keywords:
  - "list call stack command"
  - "Debug.ListCallStack command"
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# List Call Stack Command

Displays the current call stack.

## Syntax

```cmd
Debug.ListCallStack [/Count:number] [/ShowTypes:yes|no]
[/ShowNames:yes|no] [/ShowValues:yes|no] [/ShowModule:yes|no]
[/ShowLineOffset:yes|no] [/ShowByteOffset:yes|no]
[/ShowLanguage:yes|no] [/IncludeCallsAcrossThreads:yes|no]
[/ShowExternalCode:yes|no] [Thread:n] [index]
```

## Arguments

`index`\
Optional. Sets the current stack frame and displays no output.

## Switches
Each switch can be invoked using either its complete form or a short form.

/Count:`number` [or] /C:`number`

Optional. Maximum number of call stacks to display. The default value is unlimited.

/ShowTypes:`yes`&#124;`no` [or] /T:`yes`&#124;`no`

Optional. Specifies whether to display parameter types. Default value is `yes`.

/ShowNames:`yes`&#124;`no` [or] /N:`yes`&#124;`no`

Optional. Specifies whether to display parameter names. Default value is `yes`.

/ShowValues:`yes`&#124;`no` [or] /V:`yes`&#124;`no`

Optional. Specifies whether to display parameter values. Default value is `yes`.

/ShowModule:`yes`&#124;`no` [or] /M:`yes`&#124;`no`

Optional. Specifies whether to display the module name. Default value is `yes`.

/ShowLineOffset:`yes`&#124;`no` [or] /#:`yes`&#124;`no`

Optional. Specifies whether to display the line offset. Default value is `no`.

/ShowByteOffset:`yes`&#124;`no` [or] /B:`yes`&#124;`no`

Optional. Specifies whether to display the byte offset. Default value is `no`.

/ShowLanguage:`yes`&#124;`no` [or] /L:`yes`&#124;`no`

Optional. Specifies whether to display the language. Default value is `no`.

/IncludeCallsAcrossThreads:`yes`&#124;`no` [or] /I:`yes`&#124;`no`

Optional. Specifies whether to include calls to or from other threads. Default value is `no`.

/ShowExternalCode:`yes`&#124;`no`

Optional. Specifies whether to display Just My Code for the callstack. When Just My Code is off, all non-user code is displayed. When Just My Code is on, non-user code is displayed as `[external]` in the callstack output.

Thread:`n`

Optional. Displays the callstack for thread `n`. If no thread is specified, displays the callstack for the current thread.

## Remarks
Changes made to the arguments or switches apply to future invocations of this command. If you issue Debug.ListCallStackby itself, the entire call stack displays. If you specify an index, for example,

```cmd
Debug.ListCallStack 2
```

then the current stack frame is set to that frame (in this case, the second frame).

You can also write this command using its pre-defined alias, kb. For example, you can enter

```cmd
kb 2
```

to set the current stack frame to the second frame.

## Example

```cmd
>Debug.CallStack /Count:4 /ShowTypes:yes
```

## See also

- [List Disassembly Command](../../ide/reference/list-disassembly-command.md)
- [List Threads Command](../../ide/reference/list-threads-command.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)