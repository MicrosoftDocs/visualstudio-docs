---
title: -SafeMode (devenv.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "/SafeMode Devenv switch"
  - "Devenv, /SafeMode switch"
  - "SafeMode switch"
ms.assetid: b191f6a5-8f12-47ec-bcc7-b68149a22aa8
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# /SafeMode (devenv.exe)
Starts [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] in safe mode, loading only the default environment and services.

## Syntax

```cmd
devenv /SafeMode
```

## Remarks
 This switch prevents all third-party VSPackages from loading when [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] starts, thus ensuring stable execution.

## Description
 The following example starts [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] in safe mode.

## Code

```cmd
Devenv.exe /SafeMode
```

## See Also

- [Devenv Command Line Switches](../../ide/reference/devenv-command-line-switches.md)