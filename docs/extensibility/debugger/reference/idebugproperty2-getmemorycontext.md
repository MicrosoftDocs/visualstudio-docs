---
description: "Gets the memory context of the property value."
title: IDebugProperty2::GetMemoryContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetMemoryContext
helpviewer_keywords:
- IDebugProperty2::GetMemoryContext
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::GetMemoryContext

Gets the memory context of the property value.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryContext(
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
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object that represents the memory associated with this property.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETMEMORYCONTEXT_NO_MEMORY_CONTEXT` if there is no memory context to retrieve.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
