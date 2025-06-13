---
description: "Determines the existence of a custom attribute for this field and, if it exists, returns the attribute information."
title: IDebugCustomAttributeQuery2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2
helpviewer_keywords:
- IDebugCustomAttributeQuery interface
- IDebugCustomAttributeQuery2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCustomAttributeQuery2

Determines the existence of a custom attribute for this field and, if it exists, returns the attribute information.

## Syntax

```
IDebugCustomAttributeQuery2 : IDebugCustomAttributeQuery
```

## Notes for Implementers
 A symbol provider implements this interface on the same object that implements [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) in order to support custom attributes.

## Notes for Callers
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.

## Methods in Vtable Order
 The following table shows the methods of the **IDebugCustomAttributeQuery** interface.

|Method|Description|
|------------|-----------------|
|[IsCustomAttributeDefined](../../../extensibility/debugger/reference/idebugcustomattributequery2-iscustomattributedefined.md)|Determines whether a custom attribute exists by name.|
|[GetCustomAttributeByName](../../../extensibility/debugger/reference/idebugcustomattributequery2-getcustomattributebyname.md)|Gets the attribute information for the given custom attribute.|

 In addition to the **IDebugCustomAttributeQuery** methods, `IDebugCustomAttributeQuery2` implements the following method:

|Method|Description|
|------------|-----------------|
|[EnumCustomAttributes](../../../extensibility/debugger/reference/idebugcustomattributequery2-enumcustomattributes.md)|Gets an enumerator for all custom attributes attached to this field.|

## Remarks
 The [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md) method can return an enumerator for all custom attributes defined for this field.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
