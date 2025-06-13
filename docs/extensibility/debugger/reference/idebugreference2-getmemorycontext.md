---
description: "Gets a memory context of a reference."
title: IDebugReference2::GetMemoryContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::GetMemoryContext
helpviewer_keywords:
- IDebugReference2::GetMemoryContext
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::GetMemoryContext

Gets a memory context of a reference. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryContext ( 
   out IDebugMemoryContext2 ppMemory
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryContext ( 
   IDebugMemoryContext2** ppMemory
);
```
---

## Parameters
`ppMemory`\
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object that represents the memory associated with the value of the reference.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
