---
description: "Creates an array of the specified type and size."
title: IDebugTypeFieldBuilder2::CreateArrayOfType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugTypeFieldBuilder2::CreateArrayOfType
- CreateArrayOfType
ms.assetid: 85166ac9-0bff-49a0-b2fd-ca7f7a8eae4b
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugTypeFieldBuilder2::CreateArrayOfType
Creates an array of the specified type and size.

## Syntax

```cpp
HRESULT CreateArrayOfType (
   IDebugField*  pTypeField,
   DWORD         rank,
   IDebugField** pArrayOfTypeField
);
```

```csharp
int CreateArrayOfType (
   IDebugField     pTypeField,
   uint            rank,
   out IDebugField pArrayOfTypeField
);
```

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
