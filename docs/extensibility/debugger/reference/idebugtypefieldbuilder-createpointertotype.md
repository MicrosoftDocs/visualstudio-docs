---
description: "Creates a pointer to the specified type."
title: IDebugTypeFieldBuilder::CreatePointerToType
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CreatePointerToType
- IDebugTypeFieldBuilder::CreatePointerToType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugTypeFieldBuilder::CreatePointerToType

Creates a pointer to the specified type.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreatePointerToType(
   IDebugField     pTypeField,
   out IDebugField pPtrToTypeField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreatePointerToType(
   IDebugField*  pTypeField,
   IDebugField** pPtrToTypeField
);
```
---

## Parameters
`pTypeField`\
[in] Type to point to. It is represented by the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.

`pPtrToTypeField`\
[out] Returns the pointer represented by a new **IDebugField** object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugTypeFieldBuilder](../../../extensibility/debugger/reference/idebugtypefieldbuilder.md)
