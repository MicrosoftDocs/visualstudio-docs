---
description: "This method gets the debug address of a field."
title: IDebugField::GetAddress
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetAddress
helpviewer_keywords:
- IDebugField::GetAddress method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetAddress

This method gets the debug address of a field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAddress(
   out IDebugAddress ppAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAddress( 
   IDebugAddress** ppAddress
);
```
---

## Parameters
`ppAddress`\
[out] Returns the address as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, return an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
