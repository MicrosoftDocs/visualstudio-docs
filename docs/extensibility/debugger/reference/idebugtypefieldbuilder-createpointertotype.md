---
description: "Creates a pointer to the specified type."
title: IDebugTypeFieldBuilder::CreatePointerToType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CreatePointerToType
- IDebugTypeFieldBuilder::CreatePointerToType
ms.assetid: 73966e8a-b643-43e0-9b4e-0aa4b402ebbe
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugTypeFieldBuilder::CreatePointerToType

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
