---
description: "Represents a debug optional modifier."
title: IDebugModOpt
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugModOpt interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugModOpt

Represents a debug optional modifier.

## Syntax

```
IDebugModOpt : IUnknown
```

## Notes for Callers
 Obtained from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that represents a class or method.

## Methods
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetModOpts](../../../extensibility/debugger/reference/idebugmodopt-getmodopts.md)|Retrieves a list of optional modifiers.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
