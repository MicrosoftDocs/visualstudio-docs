---
title: -Edit (devenv.exe)
ms.date: 12/10/2018
ms.prod: visual-studio-dev15
ms.topic: reference
helpviewer_keywords:
  - "Edit Devenv switch"
  - "Devenv, /Edit switch"
  - "/Edit Devenv switch"
ms.assetid: 02b3d6e7-a2b1-4d83-a747-aa8c2fb758b7
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /Edit (devenv.exe)

Opens the specified file in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

## Syntax

```shell
devenv /Edit [File1[ FileN]...]
```

## Arguments

*File1*<br/>
Optional. The file to open in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. If no instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] exists, a new instance is created with a simplified window layout, and *File1* is opened in the new instance.

*FileN*<br/>
 Optional. One or more additional files to open in the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

## Remarks

If no file is specified, and there's an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] receives focus. If no file is specified, and no existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] exists, a new instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is created with a simplified window layout.

If the existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is in a modal state (such as when the [Options dialog box](../../ide/reference/options-dialog-box-visual-studio.md) is open), the file opens in the existing instance when [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] exits the modal state.

## Example

The first example opens the file `MyFile.cs` in an existing instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] or opens the file in a new instance of [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] if one doesn't already exist. The second example is similar except that it opens three files instead of just one file.

```shell
devenv /edit MyFile.cs

devenv /edit MyFile1.cs MyFile2.cs MyFile3.cs
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)