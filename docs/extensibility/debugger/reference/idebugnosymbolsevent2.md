---
description: "Signals the Visual Studio debugger UI to warn the user that symbols could not be located for the launched executable."
title: IDebugNoSymbolsEvent2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugNoSymbolsEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugNoSymbolsEvent2

Signals the Visual Studio debugger UI to warn the user that symbols could not be located for the launched executable.

## Syntax

```
IDebugNoSymbolsEvent2 : IUnknown
```

## Notes for Implementers
 Implemented by debug engines and consumed by the Visual Studio debugger UI.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
