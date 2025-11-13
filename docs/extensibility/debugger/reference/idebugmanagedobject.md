---
description: "This interface enables the expression evaluator (EE) to call properties or methods on value class instances (for example, System.Decimal) and to set their value without calling Evaluate on the program being debugged."
title: IDebugManagedObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugManagedObject
helpviewer_keywords:
- IDebugManagedObject interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugManagedObject

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface enables the expression evaluator (EE) to call properties or methods on value class instances (for example, `System.Decimal`) and to set their value without calling [Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md) on the program being debugged.

## Syntax

```
IDebugManagedObject : IDebugObject
```

## Notes for Implementers
 An expression evaluator implements this interface to represent a managed code object such as a variable.

## Notes for Callers
 To obtain this interface, call [GetManagedDebugObject](../../../extensibility/debugger/reference/idebugobject-getmanageddebugobject.md) on an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) that represents an instance of a value class.

## Methods in Vtable Order
 In addition to the methods inherited from [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md), the `IDebugManagedObject` interface exposes the following methods.

|Method|Description|
|------------|-----------------|
|[GetManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject-getmanagedobject.md)|Returns an interface that represents the managed code object and from which any appropriate managed code interface can be obtained.|
|[SetFromManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject-setfrommanagedobject.md)|Sets the value of this object to the value of a specified managed code object.|

## Remarks
 An expression evaluator uses this interface to store a managed code object in a parse tree.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md)
