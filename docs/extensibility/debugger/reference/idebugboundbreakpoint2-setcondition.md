---
description: "Sets or changes the condition associated with this bound breakpoint."
title: IDebugBoundBreakpoint2::SetCondition
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2::SetCondition
helpviewer_keywords:
- SetCondition method
- IDebugBoundBreakpoint2::SetCondition method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBoundBreakpoint2::SetCondition

Sets or changes the condition associated with this bound breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetCondition( 
   enum_BP_CONDITION bpCondition
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
[in] A value from the [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md) enumeration that describes the condition.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).

## Remarks
 Any condition that was previously associated with this breakpoint is lost.

## See also
- [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md)
- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
