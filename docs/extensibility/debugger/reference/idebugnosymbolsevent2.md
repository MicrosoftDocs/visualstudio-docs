---
description: "Signals the Visual Studio debugger UI to warn the user that symbols could not be located for the launched executable."
title: IDebugNoSymbolsEvent2 | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugNoSymbolsEvent2 interface
ms.assetid: f6fb6388-47f6-4385-9ad5-95d62f9a7592
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# IDebugNoSymbolsEvent2
Signals the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] debugger UI to warn the user that symbols could not be located for the launched executable.

## Syntax

```
IDebugNoSymbolsEvent2 : IUnknown
```

## Notes for Implementers
 Implemented by debug engines and consumed by the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] debugger UI.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
