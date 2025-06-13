---
description: "This interface enumerates DEBUG_PROPERTY_INFO structures."
title: IEnumDebugPropertyInfo2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugPropertyInfo2
helpviewer_keywords:
- IEnumDebugPropertyInfo2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugPropertyInfo2

This interface enumerates [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures.

## Syntax

```
IEnumDebugPropertyInfo2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent information for a particular property.

## Notes for Callers
 Call [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) to obtain this interface representing the children of a particular property. Call [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md) to obtain this interface representing the properties of a particular stack frame.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugPropertyInfo2`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-next.md)|Retrieves a specified number of [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-skip.md)|Skips a specified number of [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugpropertyinfo2-getcount.md)|Gets the number of [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structures in an enumerator.|

## Remarks
 In general, a property is a hierarchy of information that can include a name, value, address, and type, as well as any other information appropriate to the associated property object or stack frame. See [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) for more details.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)
- [EnumProperties](../../../extensibility/debugger/reference/idebugstackframe2-enumproperties.md)
