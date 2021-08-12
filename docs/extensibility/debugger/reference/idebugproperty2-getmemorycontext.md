---
description: "Gets the memory context of the property value."
title: IDebugProperty2::GetMemoryContext | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetMemoryContext
helpviewer_keywords:
- IDebugProperty2::GetMemoryContext
ms.assetid: 91793d25-790f-4881-a5c0-d0458e534514
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
# IDebugProperty2::GetMemoryContext
Gets the memory context of the property value.

## Syntax

```cpp
HRESULT GetMemoryContext ( 
   IDebugMemoryContext2** ppMemory
);
```

```csharp
int GetMemoryContext(
   out IDebugMemoryContext2 ppMemory
);
```

## Parameters
`ppMemory`\
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object that represents the memory associated with this property.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETMEMORYCONTEXT_NO_MEMORY_CONTEXT` if there is no memory context to retrieve.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
