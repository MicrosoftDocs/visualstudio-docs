---
description: "Creates an array of the specified type and size."
title: IDebugTypeFieldBuilder2::CreateArrayOfType
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugTypeFieldBuilder2::CreateArrayOfType
- CreateArrayOfType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugTypeFieldBuilder2::CreateArrayOfType

Creates an array of the specified type and size.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateArrayOfType (
   IDebugField     pTypeField,
   uint            rank,
   out IDebugField pArrayOfTypeField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateArrayOfType (
   IDebugField*  pTypeField,
   DWORD         rank,
   IDebugField** pArrayOfTypeField
);
```
---

## Parameters
`pTypeField`\
[in] Type of elements the array will hold.

`rank`\
[in] Number of elements in the array.

`pArrayOfTypeField`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) objects that represent the new array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugTypeFieldBuilder2](../../../extensibility/debugger/reference/idebugtypefieldbuilder2.md)
