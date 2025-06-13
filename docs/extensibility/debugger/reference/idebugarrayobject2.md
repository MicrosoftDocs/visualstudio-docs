---
description: "Represents a managed array object, and allows an expression evaluator (EE) to determine the base index (lower bounds) for the array."
title: IDebugArrayObject2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugArrayObject2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugArrayObject2

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Represents a managed array object, and allows an expression evaluator (EE) to determine the base index (lower bounds) for the array.

## Syntax

```
IDebugArrayObject2 : IDebugArrayObject
```

## Notes for Implementers
 This is implemented by the managed debug engine (DE).

## Methods
 In addition to the methods on the [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md) interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetBaseIndices](../../../extensibility/debugger/reference/idebugarrayobject2-getbaseindices.md)|Retrieves the base indices (lower bounds) for each index given the number of dimensions in the array.|
|[HasBaseIndices](../../../extensibility/debugger/reference/idebugarrayobject2-hasbaseindices.md)|Determines if the array has base indices (lower bounds) defined.|

## Remarks
 An expression evaluator uses this interface to represent managed arrays in a parse tree.

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
