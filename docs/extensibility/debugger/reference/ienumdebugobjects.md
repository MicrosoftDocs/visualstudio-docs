---
description: "This interface represents a collection of objects implementing the IDebugObject interface."
title: IEnumDebugObjects
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugObjects
helpviewer_keywords:
- IEnumDebugObjects interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugObjects

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface represents a collection of objects implementing the [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface.

## Syntax

```
IEnumDebugObjects : IUnknown
```

## Notes for Implementers
 The expression evaluator implements this interface to provide sets of objects that implement the [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) interface. Note that this is not a standard COM enumeration due to the presence of the [GetCount](../../../extensibility/debugger/reference/ienumdebugobjects-getcount.md) method.

## Notes for Callers
- [GetElements](../../../extensibility/debugger/reference/idebugarrayobject-getelements.md) returns this interface.

## Methods in Vtable order
 This interface implements the following methods.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md)|Retrieves the next set of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects from the enumeration.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugobjects-skip.md)|Skips a specified number of entries.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugobjects-reset.md)|Resets the enumeration to the first entry.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugobjects-clone.md)|Retrieves a copy of the current enumeration.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugobjects-getcount.md)|Retrieves the number of entries in the enumeration.|

## Remarks
 This interface allows a debug engine to enumerate over a set of objects in an array.

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [GetElements](../../../extensibility/debugger/reference/idebugarrayobject-getelements.md)
