---
description: "This method converts either an object location or a memory address to a memory context."
title: IDebugBinder::GetMemoryContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::GetMemoryContext
helpviewer_keywords:
- IDebugBinder::GetMemoryContext method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder::GetMemoryContext

This method converts either an object location or a memory address to a memory context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryContext(
   IDebugField              pField,
   uint                     dwConstant,
   out IDebugMemoryContext2 ppMemCxt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryContext( 
   IDebugField*           pField,
   DWORD                  dwConstant,
   IDebugMemoryContext2** ppMemCxt
);
```
---

## Parameters
`pField`\
[in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the object to locate. If `NULL`, then use `dwConstant` instead.

`dwConstant`\
[in] A constant memory address, such as 0x5000.

`ppMemCxt`\
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
