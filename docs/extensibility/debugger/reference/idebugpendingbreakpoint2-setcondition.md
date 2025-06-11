---
description: "Sets or changes the condition associated with the pending breakpoint."
title: IDebugPendingBreakpoint2::SetCondition
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2::SetCondition
helpviewer_keywords:
- SetCondition method
- IDebugPendingBreakpoint2::SetCondition method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPendingBreakpoint2::SetCondition

Sets or changes the condition associated with the pending breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetCondition( 
   BP_CONDITION bpCondition
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetCondition( 
   BP_CONDITION bpCondition
);
```
---

## Parameters
`bpCondition`\
[in] A [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md) structure that specifies the condition to set.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Any condition that was previously associated with the pending breakpoint is lost. All breakpoints bound from this pending breakpoint are called to set their condition to the value specified in the `bpCondition` parameter.

## See also
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md)
