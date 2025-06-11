---
description: "Represents a function and enhances the IDebugFunctionObject interface."
title: IDebugFunctionObject2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugFunctionObject2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugFunctionObject2

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Represents a function and enhances the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.

## Syntax

```
IDebugFunctionObject2 : IUnknown
```

## Notes for Implementers
 An expression evaluator (EE) implements this interface to represent a function.

## Notes for Callers
 Methods of this interface defer those of **IDebugFunctionObject** in the following ways:

- The **IDebugEvaluate** method takes flags.

- The **CreateObject** method takes flags and a timeout.

- The **CreateStringObjectWithLength** method takes a length.

## Methods
 This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[CreateObject](../../../extensibility/debugger/reference/idebugfunctionobject2-createobject.md)|Creates an object that uses a constructor given evaluation flag settings and a timeout value.|
|[CreateStringObjectWithLength](../../../extensibility/debugger/reference/idebugfunctionobject2-createstringobjectwithlength.md)|Creates a string object that has the specified length.|
|[Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject2-evaluate.md)|Calls the function and returns the resulting value as an object.|

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
