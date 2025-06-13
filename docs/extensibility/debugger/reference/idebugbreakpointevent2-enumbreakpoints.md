---
description: "Creates an enumerator for all the breakpoints that fired at the current code location."
title: IDebugBreakpointEvent2::EnumBreakpoints
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointEvent2:::EnumBreakpoints
helpviewer_keywords:
- IDebugBreakpointEvent2:::EnumBreakpoints
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointEvent2::EnumBreakpoints

Creates an enumerator for all the breakpoints that fired at the current code location.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumBreakpoints(
  out IEnumDebugBoundBreakpoints2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumBreakpoints(
  IEnumDebugBoundBreakpoints2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugBoundBreakpoints2](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md) object that enumerates all the breakpoints associated with the current code location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Not all breakpoints at a particular location may fire at a particular time (for example, a breakpoint with a condition will not fire until that condition is met).

## See also
- [IDebugBreakpointEvent2](../../../extensibility/debugger/reference/idebugbreakpointevent2.md)
- [IEnumDebugBoundBreakpoints2](../../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md)
