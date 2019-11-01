---
title: "-Updateconfiguration (devenv.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "/updateconfiguration Devenv switch"
  - "Devenv, /updateconfiguration switch"
  - "updateconfiguration Devenv switch"
ms.assetid: 9a1084cc-8b68-4ccc-aaea-f95939164338
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: jillfra
---
# /Updateconfiguration (devenv.exe)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Notifies [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] to merge the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] packages on the system and check the MEF cache for any changes.

## Syntax

```
devenv /updateconfiguration
```

## Remarks
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] runs this command automatically when you install a VSIX package. You should run `devenv.exe /updateconfiguration` after patching your files so that [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] updates the MEF cache. This enables you to evaluate whether your fix is adequate.

## Example
 The following command line causes [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] to merge the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] packages on the system and check the MEF cache for any changes.

```
Devenv.exe /updateconfiguration
```

## See Also
 [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3)
 [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)
