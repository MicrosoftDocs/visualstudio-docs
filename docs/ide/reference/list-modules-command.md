---
title: List Modules Command
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "debug.listmodules"
helpviewer_keywords:
  - "Debug.ListModules command"
  - "ListModules command"
  - "list modules command"
ms.assetid: 3cb73774-6ac0-43b2-b781-75ed47175bfd
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# List Modules Command
Lists the modules for the current process.

## Syntax

```
Debug.ListModules [/Address:yes|no] [/Name:yes|no] [/Order:yes|no]
[/Path:yes|no] [/Process:yes|no] [/SymbolFile:yes|no]
[/SymbolStatus:yes|no] [/Timestamp:yes|no] [/Version:yes|no]
```

#### Parameters
/Address:`yes|no`

Optional. Specifies whether to show the memory addresses of the modules. Default value is `yes`.

/Name:`yes|no`

Optional. Specifies whether to show the names of the modules. Default value is `yes`.

/Order:`yes|no`

Optional. Specifies whether to show the order of the modules. Default value is `no`.

/Path:`yes|no`

Optional. Specifies whether to show the paths of the modules. Default value is `yes`.

/Process:`yes|no`

Optional. Specifies whether to show the processes of the modules. Default value is `no`.

/SymbolFile:`yes|no`

Optional. Specifies whether to show the symbol files of the modules. Default value is `no`.

/SymbolStatus:`yes|no`

Optional. Specifies whether to show the symbol statuses of the modules. Default value is `yes`.

/Timestamp:`yes|no`

Optional. Specifies whether to show the timestamps of the modules. Default value is `no`.

/Version:`yes|no`

Optional. Specifies whether to show the versions of the modules. Default value is `no`.

## Example
This example lists the module names, addresses, and timestamps for the current process.

```
Debug.ListModules /Address:yes /Name:yes /Order:no /Path:no /Process:no /SymbolFile:no /SymbolStatus:no /Timestamp:yes /Version:no
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [How to: Use the Modules Window](../../debugger/how-to-use-the-modules-window.md)