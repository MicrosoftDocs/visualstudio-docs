---
title: Set Current Process
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Debug.SetCurrentProcess command"
  - "Set Current Process command"
ms.assetid: 1e016ebd-aadd-411f-a606-03bf69d3f8aa
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Set Current Process
Sets the specified process as the active process in the debugger.

## Syntax

```cmd
Debug.SetCurrentProcess index
```

## Arguments
`index`

Required. The index of the process.

## Remarks
You can attach to multiple processes when you are debugging, but only one process is active in the dubber at any given time. You can use the `SetCurrentProcess` command to set the active process.

## Example

```cmd
>Debug.SetCurrentProcess 1
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)