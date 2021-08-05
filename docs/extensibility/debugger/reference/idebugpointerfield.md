---
description: "This interface represents a pointer type."
title: IDebugPointerField | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPointerField
helpviewer_keywords:
- IDebugPointerField interface
ms.assetid: d51bd5b2-f18e-4e27-b4fb-e6f652fbf635
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# IDebugPointerField
This interface represents a pointer type.

## Syntax

```
IDebugPointerField : IDebugContainerField
```

## Notes for Implementers
 The symbol provider implements this interface to represent a pointer.

## Notes for Callers
 Use [QueryInterface](/cpp/atl/queryinterface) to obtain this interface from the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface if [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) returns `FIELD_TYPE_POINTER`.

## Methods in Vtable order
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetDereferencedField](../../../extensibility/debugger/reference/idebugpointerfield-getdereferencedfield.md)|Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the target of the pointer.|

## Remarks
 In C/C++, a pointer can be a container if it is used with array notation. For example, given `char *pString`, `pString` has a type of pointer to `char`. `pString[3]` has the type of a container that is a pointer to `char` that references the fourth element of that container.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
