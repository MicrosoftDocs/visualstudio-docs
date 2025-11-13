---
description: "This interface represents a function."
title: IDebugFunctionObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionObject
helpviewer_keywords:
- IDebugFunctionObject interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugFunctionObject

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface represents a function.

## Syntax

```
IDebugFunctionObject : IDebugObject
```

## Notes for Implementers
 An expression evaluator implements this interface to represent a function.

## Notes for Callers
 This interface is a specialization of the [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface and is obtained using [QueryInterface](/cpp/atl/queryinterface) on the `IDebugObject` interface.

## Methods in Vtable Order
 In addition to the methods inherited from [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md), the `IDebugFunctionObject` interface exposes the following methods.

|Method|Description|
|------------|-----------------|
|[CreatePrimitiveObject](../../../extensibility/debugger/reference/idebugfunctionobject-createprimitiveobject.md)|Creates a primitive data object.|
|[CreateObject](../../../extensibility/debugger/reference/idebugfunctionobject-createobject.md)|Creates an object using a constructor.|
|[CreateObjectNoConstructor](../../../extensibility/debugger/reference/idebugfunctionobject-createobjectnoconstructor.md)|Creates an object with no constructor.|
|[CreateArrayObject](../../../extensibility/debugger/reference/idebugfunctionobject-createarrayobject.md)|Creates an array object.|
|[CreateStringObject](../../../extensibility/debugger/reference/idebugfunctionobject-createstringobject.md)|Creates a string object.|
|[Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md)|Calls the function and returns the resulting value as an object.|

## Remarks
 This interface enables the expression evaluator to represent functions in a parse tree. The `Create` methods in this interface are used to construct objects representing the input parameters to the method. The function can then be executed by calling the [Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md) method, which returns an object representing the return value of the function.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
