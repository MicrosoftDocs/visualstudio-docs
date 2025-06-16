---
description: "Retrieves the size, in bytes, of the memory represented by this IDebugMemoryBytes2 object."
title: IDebugMemoryBytes2::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryBytes2::GetSize
helpviewer_keywords:
- IDebugMemoryBytes2::GetSize method
- GetSize method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMemoryBytes2::GetSize

Retrieves the size, in bytes, of the memory represented by this [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize(
   out ulong pqwSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize( 
   UINT64* pqwSize
);
```
---

## Parameters
`pqwSize`\
[out] Returns the size, in bytes of the memory space.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md)
