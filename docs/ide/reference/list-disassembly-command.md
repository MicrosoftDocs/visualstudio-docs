---
title: List Disassembly Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.listdisassembly"
helpviewer_keywords:
  - "Debug.ListDisassembly command"
  - "list disassembly command"
ms.assetid: eb363e35-e86a-4121-966f-991210c27e2a
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
---
# List Disassembly Command
Begins the debug process and allows you to specify how errors are handled.

## Syntax

```cmd
Debug.ListDisassembly [/count:number] [/endaddress:expression]
[/codebytes:yes|no] [/source:yes|no] [/symbolnames:yes|no]
[/linenumbers:yes|no]
```

## Switches
Each switch can be invoked using either its complete form or a short form.

/count: `number` [or] /c: `number` [or] /length: `number` [or] /l: `number`

Optional. Number of instructions to display. Default value is 8.

/endaddress: `expression` [or] /e: `expression`

Optional. Address at which to stop disassembly.

/codebytes:`yes`&#124;`no` [or] /bytes:`yes`&#124;`no` [or] /b:`yes`&#124;`no`

Optional. Indicates whether to display code bytes. Default value is `no`.

/source:`yes`&#124;`no` [or] /s:`yes`&#124;`no`

Optional. Indicates whether to display source code. Default value is `no`.

/symbolnames:`yes`&#124;`no` [or] /names:`yes`&#124;`no` [or] /n:`yes`&#124;`no`

Optional. Indicates whether to display symbols names. Default value is `yes`.

 [/linenumbers:`yes`&#124;`no`]

Optional. Enables the viewing of line numbers associated with the source code. The /source switch must have a value of `yes` to use the /linenumbers switch.

## Example

```cmd
>Debug.ListDisassembly
```

## See also

- [List Call Stack Command](../../ide/reference/list-call-stack-command.md)
- [List Threads Command](../../ide/reference/list-threads-command.md)
- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)