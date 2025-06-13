---
description: "This interface represents a type of a variable."
title: IDebugDynamicField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDynamicField
helpviewer_keywords:
- IDebugDynamicField interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDynamicField

This interface represents a type of a variable.

## Syntax

```
IDebugDynamicField : IDebugField
```

## Notes for Implementers
 This interface is implemented by symbol providers as a base class for any type that can be determined at run time. This is for managed code only.

## Notes for Callers
 This interface represents a base class from which more specialized interfaces can be derived.

## Methods in Vtable order
 This interface does not supply any methods other than those inherited from `IDebugField`.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
