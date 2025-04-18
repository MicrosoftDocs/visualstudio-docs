---
title: -Edit (devenv.exe)
description: Learn how to use the Edit devenv command-line switch to open a specified file in an existing instance of Visual Studio.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- Edit Devenv switch
- Devenv, /Edit switch
- /Edit Devenv switch
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /Edit (devenv.exe)

Opens the specified file in an existing instance of Visual Studio.

## Syntax

```shell
devenv /Edit [File1[ FileN]...]
```

## Arguments

- *File1*

  Optional. The file to open in an existing instance of Visual Studio. If no instance of Visual Studio exists, a new instance is created with a simplified window layout, and the tool opens *File1* in the new instance.

- *FileN*

  Optional. One or more additional files to open in the existing instance of Visual Studio.

## Remarks

When a file isn't specified, an existing Visual Studio instance receives focus. If no file is specified and no instance of Visual Studio exists, the tool creates an instance with a simplified window layout.

If the existing Visual Studio instance is in a modal state, the file opens in the existing instance when Visual Studio exits the modal state. For example, this situation may occur when the [Options dialog box](../../ide/reference/options-dialog-box-visual-studio.md) is open.

If more than one instance of Visual Studio is open, the file is opened in the most recently opened instance.

## Example

The first example opens the file `MyFile.cs` in an existing instance of Visual Studio. If a Visual Studio instance doesn't exist, the tool opens the file in a new instance. The second example is similar except that it opens three files instead of just one file.

```shell
devenv /edit MyFile.cs

devenv /edit MyFile1.cs MyFile2.cs MyFile3.cs
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
