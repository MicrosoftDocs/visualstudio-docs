---
description: "Subtracts the specified value from the current context and returns a new context."
title: IDebugMemoryContext2::Subtract
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryContext2::Subtract
helpviewer_keywords:
- Subtract method
- IDebugMemoryContext2::Subtract method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMemoryContext2::Subtract

Subtracts the specified value from the current context and returns a new context.

## Syntax

### [C#](#tab/csharp)
```csharp
int Subtract(
   ulong                    dwCount,
   out IDebugMemoryContext2 ppMemCxt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Subtract( 
   UINT64                 dwCount,
   IDebugMemoryContext2** ppMemCxt
);
```
---

## Parameters
`dwCount`\
[in] The number of memory bytes to decrement.

`ppMemCxt`\
[out] Returns a new [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A memory context is an address, so subtracting a value from an address produces a new address that requires a new context interface.

 This method must always produce a new context, even if the resulting address is outside the memory space associated with this context. The only exception to this is if no memory can be allocated for the new context or if `ppMemCxt` is a null value (which is an error).

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
