---
title: Shell Command
description: Learn about the Shell command and how it launches executable programs from within Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- tools.shell
helpviewer_keywords:
- exe files
- Shell command
- Tools.Shell command
- executables, running from Visual Studio
- .exe files
- Shell, launching exe files
- Visual Studio, executables from
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Shell Command

Launches executable programs from within Visual Studio.

## Syntax

```cmd
Tools.Shell [/command] [/output] [/dir:folder] path [args]
```

## Arguments
`path`

Required. The path and file name of the file to execute or the document to open. A full path is required if the specified file is not in one of the directories in the PATH environment variable.

`args`

Optional. Any arguments to pass to the invoked program.

## Switches
/commandwindow [or] /command [or] /c [or] /cmd

Optional. Specifies that the output for the executable is displayed in the **Command** window.

/dir:`folder` [or] /d: `folder`

Optional. Specifies the working directory to be set when the program is run.

/outputwindow [or] /output [or] /out [or] /o

Optional. Specifies that the output for the executable is displayed in the **Output** window.

## Remarks
The /dir /o /c switches must be specified immediately after `Tools.Shell`. Anything specified after the name of the executable is passed to it as command line arguments.

The predefined alias `Shell` can be used in place of `Tools.Shell`.

> [!CAUTION]
> If the `path` argument supplies the directory path as well as the file name, you should enclose the entire pathname in literal quotes ("""), as in the following:

```cmd
Tools.Shell """C:\Program Files\SomeFile.exe"""
```

Each set of three double quotes (""") is interpreted by the `Shell` processor as a single double quote character. Thus, the preceding example actually passes the following path string to the `Shell` command:

```cmd
"C:\Program Files\SomeFile.exe"
```

> [!CAUTION]
> If you do not enclose the path string in literal quotes ("""), Windows will use only the portion of the string up to the first space. For example, if the path string above were not quoted properly, Windows would look for a file named "Program" located in the C:\ root directory. If a C:\Program.exe executable file were actually available, even one installed by illicit tampering, Windows would attempt to execute that program in place of the desired "c:\Program Files\SomeFile.exe" program.

## Example
The following command uses xcopy.exe to copy the file `MyText.txt` into the `Text` folder. The output from xcopy.exe is displayed in both the **Command Window** and the **Output** window.

```cmd
>Tools.Shell /o /c xcopy.exe c:\MyText.txt c:\Text\MyText.txt
```

## See also

- [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
- [Command Window](../../ide/reference/command-window.md)
- [Output Window](../../ide/reference/output-window.md)
- [Find/Command Box](../../ide/find-command-box.md)
- [Visual Studio Command Aliases](../../ide/reference/visual-studio-command-aliases.md)
