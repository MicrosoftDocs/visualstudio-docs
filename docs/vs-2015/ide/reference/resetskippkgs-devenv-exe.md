---
title: "-ResetSkipPkgs (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "/ResetSkipPkgs Devenv switch"
  - "Devenv, /ResetSkipPkgs switch"
  - "ResetSkipPkgs switch"
ms.assetid: 7ece64f9-cfa4-4b34-b0d9-1c338b9557b3
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# /ResetSkipPkgs (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Clears all options to skip loading added to VSPackages by users wishing to avoid loading problem VSPackages, then starts [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].

## Syntax

```
Devenv /ResetSkipPkgs
```

## Remarks
 The presence of a SkipLoading tag disables the loading of a VSPackage; clearing the tag re-enables the loading of the VSPackage.

## Example
 The following example clears all SkipLoading tags.

```
Devenv.exe /ResetSkipPkgs
```

## See Also
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
