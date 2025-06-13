---
description: "This method gets the type of field."
title: IDebugField::GetType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetType
helpviewer_keywords:
- IDebugField::GetType method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetType

This method gets the type of field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetType(
   out IDebugField ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetType( 
   IDebugField** ppType
);
```
---

## Parameters
`ppType`\
[out] Returns the field type as another [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
