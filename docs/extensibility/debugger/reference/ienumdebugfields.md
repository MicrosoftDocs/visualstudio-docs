---
description: "This interface represents a collection of objects implementing the IDebugField interface."
title: IEnumDebugFields
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugFields
helpviewer_keywords:
- IEnumDebugFields interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugFields

This interface represents a collection of objects implementing the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.

## Syntax

```
IEnumDebugFields : IUnknown
```

## Notes for Implementers
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface. Note that this is not a standard COM enumeration due to the presence of the [GetCount](../../../extensibility/debugger/reference/ienumdebugfields-getcount.md) method.

## Notes for Callers
 This interface is returned by [GetMethodFieldsByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getmethodfieldsbyname.md) and [GetNamespacesUsedAtAddress](../../../extensibility/debugger/reference/idebugsymbolprovider-getnamespacesusedataddress.md).

## Methods in Vtable order
 This interface implements the following methods.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugfields-next.md)|Retrieves the next set of [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) objects from the enumeration.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugfields-skip.md)|Skips a specified number of entries.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugfields-reset.md)|Resets the enumeration to the first entry.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugfields-clone.md)|Retrieves a copy of the current enumeration.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugfields-getcount.md)|Retrieves the number of entries in the enumeration.|

## Remarks

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [GetMethodFieldsByName](../../../extensibility/debugger/reference/idebugsymbolprovider-getmethodfieldsbyname.md)
- [GetNamespacesUsedAtAddress](../../../extensibility/debugger/reference/idebugsymbolprovider-getnamespacesusedataddress.md)
