---
description: "Sets or changes the pass count associated with this bound breakpoint."
title: IDebugBoundBreakpoint2::SetPassCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2::SetPassCount
helpviewer_keywords:
- SetPassCount method
- IDebugBoundBreakpoint2::SetPassCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBoundBreakpoint2::SetPassCount

Sets or changes the pass count associated with this bound breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetPassCount( 
   BP_PASSCOUNT bpPassCount
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetPassCount( 
   BP_PASSCOUNT bpPassCount
);
```
---

## Parameters
`bpPassCount`\
[in] The [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) structure that specifies the pass count.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).

## Remarks
 The pass count determines when the breakpoint is fired. The current pass or hit count can be obtained by calling the [GetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-gethitcount.md) method.

 Any pass count that was previously associated with this breakpoint is lost.

## See also
- [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [GetHitCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-gethitcount.md)
- [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)
- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
