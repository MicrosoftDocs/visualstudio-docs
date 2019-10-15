---
title: "IDebugTypeFieldBuilder::CreatePointerToType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "CreatePointerToType"
  - "IDebugTypeFieldBuilder::CreatePointerToType"
ms.assetid: 73966e8a-b643-43e0-9b4e-0aa4b402ebbe
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugTypeFieldBuilder::CreatePointerToType
Creates a pointer to the specified type.

## Syntax

```cpp
HRESULT CreatePointerToType(
   IDebugField*  pTypeField,
   IDebugField** pPtrToTypeField
);
```

```csharp
int CreatePointerToType(
   IDebugField     pTypeField,
   out IDebugField pPtrToTypeField
);
```

## Parameters
`pTypeField`\
[in] Type to point to. It is represented by the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.

`pPtrToTypeField`\
[out] Returns the pointer represented by a new **IDebugField** object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugTypeFieldBuilder](../../../extensibility/debugger/reference/idebugtypefieldbuilder.md)