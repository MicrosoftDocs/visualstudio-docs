---
description: "This method returns an IDebugField that represents the name of the enumeration."
title: IDebugEnumField::GetUnderlyingSymbol
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEnumField::GetUnderlyingSymbol
helpviewer_keywords:
- IDebugEnumField::GetUnderlyingSymbol method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEnumField::GetUnderlyingSymbol

This method returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the name of the enumeration.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetUnderlyingSymbol(
   out IDebugField ppField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetUnderlyingSymbol(
   IDebugField** ppField
);
```
---

## Parameters
`ppField`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the name of this enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name of the enumeration also contains the type of the enumeration, which is bound to a memory location by using [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md).

## See also
- [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)
