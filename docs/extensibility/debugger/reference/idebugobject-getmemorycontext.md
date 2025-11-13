---
description: "Gets the memory context that represents the address of the value of the object."
title: IDebugObject::GetMemoryContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::GetMemoryContext
helpviewer_keywords:
- IDebugObject::GetMemoryContext method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::GetMemoryContext

Gets the memory context that represents the address of the value of the object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryContext(
   ref IDebugMemoryContext2 pContext
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryContext( 
   IDebugMemoryContext2** pContext
);
```
---

## Parameters
`pContext`\
[out] Returns an [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object representing the address of the value of the object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The returned memory context specifies the address of the value as represented by this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object.

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
