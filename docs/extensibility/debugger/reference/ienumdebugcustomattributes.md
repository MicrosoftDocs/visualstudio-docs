---
description: "Enumerates custom attributes."
title: IEnumDebugCustomAttributes
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumCustomAttributes
helpviewer_keywords:
- IEnumDebugCustomAttributes interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IEnumDebugCustomAttributes

Enumerates custom attributes.

## Syntax

```
IEnumCustomAttributes : IUnknown
```

## Notes for Implementers
 A symbol provider implements this interface to support custom attributes (through the [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md) interface).

## Notes for Callers
- [EnumCustomAttributes](../../../extensibility/debugger/reference/idebugcustomattributequery2-enumcustomattributes.md) returns this interface.

## Methods in Vtable Order
 The following table shows the methods of `IEnumDebugCustomAttributes`.

|Method|Description|
|------------|-----------------|
|[Next](../../../extensibility/debugger/reference/ienumdebugcustomattributes-next.md)|Retrieves a specified number of custom attributes in an enumeration sequence.|
|[Skip](../../../extensibility/debugger/reference/ienumdebugcustomattributes-skip.md)|Skips a specified number of custom attributes in an enumeration sequence.|
|[Reset](../../../extensibility/debugger/reference/ienumdebugcustomattributes-reset.md)|Resets an enumeration sequence to the beginning.|
|[Clone](../../../extensibility/debugger/reference/ienumdebugcustomattributes-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|
|[GetCount](../../../extensibility/debugger/reference/ienumdebugcustomattributes-getcount.md)|Gets the number of custom attributes in an enumerator.|

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [EnumCustomAttributes](../../../extensibility/debugger/reference/idebugcustomattributequery2-enumcustomattributes.md)
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)
