---
description: "Represents a pointer in a parse tree, and extends the IDebugPointerObject interface."
title: IDebugPointerObject3
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPointerObject3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPointerObject3

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Represents a pointer in a parse tree, and extends the **IDebugPointerObject** interface.

## Syntax

```
IDebugPointerObject3 : IDebugPointerObject
```

## Notes for Implementers
 An expression evaluator (EE) implements this interface.

## Methods
 In addition to the methods on the [IDebugPointerObject](../../../extensibility/debugger/reference/idebugpointerobject.md) interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetPointerAddress](../../../extensibility/debugger/reference/idebugpointerobject3-getpointeraddress.md)|Retrieves the address of pointer.|

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
