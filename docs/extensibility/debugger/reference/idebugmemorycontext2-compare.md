---
description: "Compares the memory context to each context in the given array in the manner indicated by compare flags, returning an index of the first context that matches."
title: IDebugMemoryContext2::Compare
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryContext2::Compare
helpviewer_keywords:
- IDebugMemoryContext2::Compare method
- Compare method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMemoryContext2::Compare

Compares the memory context to each context in the given array in the manner indicated by compare flags, returning an index of the first context that matches.

## Syntax

### [C#](#tab/csharp)
```csharp
int Compare(
   enum_CONTEXT_COMPARE   compare,
   IDebugMemoryContext2[] rgpMemoryContextSet,
   uint                   dwMemoryContextSetLen,
   out uint               pdwMemoryContext
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Compare( 
   CONTEXT_COMPARE        compare,
   IDebugMemoryContext2** rgpMemoryContextSet,
   DWORD                  dwMemoryContextSetLen,
   DWORD*                 pdwMemoryContext
);
```
---

## Parameters
`compare`\
[in] A value from the [CONTEXT_COMPARE](../../../extensibility/debugger/reference/context-compare.md) enumeration that determines the type of comparison.

`rgpMemoryContextSet`\
[in] An array of references to the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) objects to compare against.

`dwMemoryContextSetLen`\
[in] The number of contexts in the `rgpMemoryContextSet` array.

`pdwMemoryContext`\
[out] Returns the index of the first memory context that satisfies the comparison.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_COMPARE_CANNOT_COMPARE` if the two contexts cannot be compared.

## Remarks
 A debug engine (DE) does not have to support all types of comparisons, but it must support at least `CONTEXT_EQUAL`, `CONTEXT_LESS_THAN`, `CONTEXT_GREATER_THAN` and `CONTEXT_SAME_SCOPE`.

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
- [CONTEXT_COMPARE](../../../extensibility/debugger/reference/context-compare.md)
