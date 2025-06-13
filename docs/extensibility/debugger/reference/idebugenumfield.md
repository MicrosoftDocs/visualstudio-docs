---
description: "This interface represents an enumeration type."
title: IDebugEnumField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField
helpviewer_keywords:
- IDebugEnumField interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugEnumField

This interface represents an enumeration type.

## Syntax

```
IDebugEnumField : IDebugContainerField
```

## Notes for Implementers
 A symbol provider implements this interface to represent an enumeration.

## Notes for Callers
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface if [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) returns `FIELD_TYPE_ENUM`.

## Methods in VTable order
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetUnderlyingSymbol](../../../extensibility/debugger/reference/idebugenumfield-getunderlyingsymbol.md)|Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the name for this enumeration type.|
|[GetStringFromValue](../../../extensibility/debugger/reference/idebugenumfield-getstringfromvalue.md)|Returns the name of the enumeration constant associated with the given value.|
|[GetValueFromString](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstring.md)|Returns the value associated with the given enumeration constant name|
|[GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md)|Returns the value associated with the given enumeration constant name but ignoring case.|

## Remarks
 It is the underlying symbol that is actually bound to a location with [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md).

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)
