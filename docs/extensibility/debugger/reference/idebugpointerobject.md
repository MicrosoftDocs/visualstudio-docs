---
description: "This interface represents a pointer object."
title: IDebugPointerObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPointerObject
helpviewer_keywords:
- IDebugPointerObject interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugPointerObject

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface represents a pointer object.

## Syntax

```
IDebugPointerObject : IDebugObject
```

## Notes for Implementers
 The expression evaluator implements this interface to represent a pointer object.

## Notes for Callers
 The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface can obtain this interface by using [QueryInterface](/cpp/atl/queryinterface) if the `IDebugObject` represents a pointer.

## Methods in Vtable Order
 In addition to the methods inherited from [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md), the `IDebugPointerObject` interface exposes the following methods.

|Method|Description|
|------------|-----------------|
|[Dereference](../../../extensibility/debugger/reference/idebugpointerobject-dereference.md)|Gets the object to which the interface points.|
|[GetBytes](../../../extensibility/debugger/reference/idebugpointerobject-getbytes.md)|Gets the value to which the interface points as a series of consecutive bytes.|
|[SetBytes](../../../extensibility/debugger/reference/idebugpointerobject-setbytes.md)|Sets the value to which the interface points from a series of consecutive bytes.|

## Remarks
 An expression evaluator uses this interface to represent a pointer in a parse tree.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
