---
description: "This interface provides additional information about an object."
title: IDebugObject2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2
helpviewer_keywords:
- IDebugObject2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugObject2

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface provides additional information about an object.

## Syntax

```
IDebugObject2 : IDebugObject
```

## Notes for Implementers
 The expression evaluator implements this interface to offer support for aliases and access to information about the object.

## Notes for Callers
 An [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface can obtain this interface by using [QueryInterface](/cpp/atl/queryinterface). Also, [GetObject](../../../extensibility/debugger/reference/idebugalias-getobject.md) returns this interface.

## Methods in Vtable order
 In addition to the methods on the [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface, the `IDebugObject2` interface implements the following:

|Method|Description|
|------------|-----------------|
|[GetBackingFieldForProperty](../../../extensibility/debugger/reference/idebugobject2-getbackingfieldforproperty.md)|Gets the field or variable (if any) that may be backing the property represented by this object.|
|[GetICorDebugValue](../../../extensibility/debugger/reference/idebugobject2-geticordebugvalue.md)|Gets the managed code object representing the value of this object.|
|[CreateAlias](../../../extensibility/debugger/reference/idebugobject2-createalias.md)|Creates a unique ID for this object or returns an existing alias.|
|[GetAlias](../../../extensibility/debugger/reference/idebugobject2-getalias.md)|Gets the alias associated with this object, if any.|
|[GetField](../../../extensibility/debugger/reference/idebugobject2-getfield.md)|Gets the type of this object.|
|[IsUserData](../../../extensibility/debugger/reference/idebugobject2-isuserdata.md)|Determines whether this object represents user data.|
|[IsEncOutdated](../../../extensibility/debugger/reference/idebugobject2-isencoutdated.md)|Determines whether the Edit and Continue state is no longer valid.<br /><br /> A custom expression evaluator does not implement this method (it should always return `E_NOTIMPL`).|

## Remarks
 See [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) for a discussion on aliases.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
- [GetObject](../../../extensibility/debugger/reference/idebugalias-getobject.md)
