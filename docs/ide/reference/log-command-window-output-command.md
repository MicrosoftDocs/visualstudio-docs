---
title: Log Command Window Output Command
description: Learn about the Log Command Window Output command and how it copies all input and output from the Command window into a file.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- tools.logcommandwindowoutput
helpviewer_keywords:
- log Command window output command
- View.LogCommandWindowOutput command
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Log Command window output command

Copies all input and output from the **Command** window into a file.

## Syntax

```cmd
Tools.LogCommandWindowOutput [filename] [/on|/off] [/overwrite]
```

## Arguments

`filename`\
Optional. The name of the log file. By default, the file is created in the user's profile folder. If the file name already exists, the log is appended to the end of the existing file. If no file is specified, the last file specified is used. If no previous file exists, a default log file is created, called cmdline.log.

> [!TIP]
> To change the location where the log file is saved, enter the full path of the file, surrounded by quotation marks if the path contains any spaces.

## Switches

/on\
Optional. Starts the log for the **Command** window in the specified file and appends the file with the new information.

/off\
Optional. Stops the log for the **Command** window.

/overwrite\
Optional. If the file specified in the `filename` argument matches an existing file, the file is overwritten.

## Remarks

If no file is specified, the file cmdline.log is created by default. By default, the alias for this command is Log.

## Examples

This example creates a new log file, cmdlog, and starts the command log.

```cmd
>Tools.LogCommandWindowOutput cmdlog
```

This example stops logging commands.

```cmd
>Tools.LogCommandWindowOutput /off
```

This example resumes the logging of commands in the previously used log file.

```cmd
>Tools.LogCommandWindowOutput /on
```

## See also

- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)
- [Command window](../../ide/reference/command-window.md)
- [Find/Command box](../../ide/find-command-box.md)
- [Visual Studio command aliases](../../ide/reference/visual-studio-command-aliases.md)
