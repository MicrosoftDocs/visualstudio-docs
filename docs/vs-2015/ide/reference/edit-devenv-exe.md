---
title: "-Edit (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Devenv, /edit switch"
  - "/Edit Devenv swtich"
ms.assetid: 02b3d6e7-a2b1-4d83-a747-aa8c2fb758b7
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Edit (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Opens the specified file in an existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].

## Syntax

```
Devenv /edit [file1[ file2]]
```

## Arguments
 `file1`
 Optional. The file to open in an existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. If no instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] exists, a new instance is created with a simplified window layout, and `file1` is opened in the new instance.

 `file2`
 Optional. One or more additional files to open in the existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].

## Remarks
 If no file is specified and there is an existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], the existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] receives focus. If no file is specified and there is no existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], a new instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] is created with a simplified window layout.

 If the existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] is in a modal state, for example, if the [Options dialog box](../../ide/reference/options-dialog-box-visual-studio.md) is open, the file will open in the existing instance when [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] exits the modal state.

## Example
 This example opens the file `MyFile.cs` in an existing instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] or opens the file in a new instance of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] if one does not already exist.

```
devenv /edit MyFile.cs
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
