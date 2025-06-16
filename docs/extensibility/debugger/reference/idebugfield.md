---
description: "This interface represents a field, that is, a description of a symbol or type."
title: IDebugField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField
helpviewer_keywords:
- IDebugField interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugField

This interface represents a field, that is, a description of a symbol or type.

## Syntax

```
IDebugField : IUnknown
```

## Notes for Implementers
 A symbol provider implements this interface as the base class for all fields.

## Notes for Callers
 This interface is the base class for all fields. Based on the return value of [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md), this interface may return more specialized interfaces by using [QueryInterface](/cpp/atl/queryinterface). In addition, many interfaces return `IDebugField` objects from various methods.

## Methods in Vtable Order
 The following table shows the methods of `IDebugField`.

|Method|Description|
|------------|-----------------|
|[GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md)|Gets displayable information about the symbol or type.|
|[GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md)|Gets the kind of field.|
|[GetType](../../../extensibility/debugger/reference/idebugfield-gettype.md)|Gets the type of field.|
|[GetContainer](../../../extensibility/debugger/reference/idebugfield-getcontainer.md)|Gets the container of the field.|
|[GetAddress](../../../extensibility/debugger/reference/idebugfield-getaddress.md)|Gets the address of the field.|
|[GetSize](../../../extensibility/debugger/reference/idebugfield-getsize.md)|Gets the size of a field, in bytes.|
|[GetExtendedInfo](../../../extensibility/debugger/reference/idebugfield-getextendedinfo.md)|Gets extended information about a field.|
|[Equal](../../../extensibility/debugger/reference/idebugfield-equal.md)|Compares two fields.|
|[GetTypeInfo](../../../extensibility/debugger/reference/idebugfield-gettypeinfo.md)|Gets type-independent information about the symbol or type.|

## Remarks
 A type is equivalent to a C language `typedef`.

 In the following C++ language example, `weather` is a class type, and `sunny` and `stormy` are symbols:

```cpp
class weather;
weather sunny;
weather stormy;
```

 Whether a field represents a symbol or type can be determined by calling [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) and examining the [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) result. If the `FIELD_KIND_TYPE` bit is set, the field is a type, and if the `FIELD_KIND_SYMBOL` bit is set, it is a symbol.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
