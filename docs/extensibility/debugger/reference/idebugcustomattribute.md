---
description: "This interface represents a custom attribute, and it can provide the name, parent, and class type of the attribute."
title: IDebugCustomAttribute
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttribute
helpviewer_keywords:
- IDebugCustomAttribute interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCustomAttribute

This interface represents a custom attribute, and it can provide the name, parent, and class type of the attribute.

## Syntax

```
IDebugCustomAttribute : IUnknown
```

## Notes for Implementers
 A symbol provider implements this interface in order to support custom attributes associated with a symbol. It is typically implemented on its own object.

## Notes for Callers
 A call to [Next](../../../extensibility/debugger/reference/ienumdebugcustomattributes-next.md) returns this interface. A call to the [EnumCustomAttributes](../../../extensibility/debugger/reference/idebugcustomattributequery2-enumcustomattributes.md) method returns the [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md) interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugCustomAttribute`.

|Method|Description|
|------------|-----------------|
|[GetParentField](../../../extensibility/debugger/reference/idebugcustomattribute-getparentfield.md)|Gets the field to which the current attribute is attached.|
|[GetAttributeTypeField](../../../extensibility/debugger/reference/idebugcustomattribute-getattributetypefield.md)|Gets the custom attribute class type.|
|[GetName](../../../extensibility/debugger/reference/idebugcustomattribute-getname.md)|Gets the name of the custom attribute.|
|[GetAttributeBytes](../../../extensibility/debugger/reference/idebugcustomattribute-getattributebytes.md)|Gets the attribute information as a blob of bytes.|

## Remarks
 A custom attribute is a structure for C# that supplies custom metadata associated with a particular class or method.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
