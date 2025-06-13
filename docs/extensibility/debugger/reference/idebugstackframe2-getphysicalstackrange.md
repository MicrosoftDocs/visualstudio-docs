---
description: "Gets a machine-dependent representation of the range of physical addresses associated with a stack frame."
title: IDebugStackFrame2::GetPhysicalStackRange
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetPhysicalStackRange
helpviewer_keywords:
- IDebugStackFrame2::GetPhysicalStackRange
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetPhysicalStackRange

Gets a machine-dependent representation of the range of physical addresses associated with a stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPhysicalStackRange ( 
   out ulong paddrMin,
   out ulong paddrMax
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPhysicalStackRange ( 
   UINT64* paddrMin,
   UINT64* paddrMax
);
```
---

## Parameters
`paddrMin`\
[out] Returns the lowest physical address associated with this stack frame.

`paddrMax`\
[out] Returns the highest physical address associated with this stack frame.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The information returned by this method is used by the session debug manager (SDM) to sort stack frames.

 It is assumed that the call stack grows down, that is, that new stack frames are added at increasingly lower memory addresses. A run-time architecture must provide physical stack ranges that match this assumption.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
