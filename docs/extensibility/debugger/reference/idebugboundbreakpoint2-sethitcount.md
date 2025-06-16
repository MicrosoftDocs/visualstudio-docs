---
description: "Sets the hit count for the bound breakpoint."
title: IDebugBoundBreakpoint2::SetHitCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2::SetHitCount
helpviewer_keywords:
- SetHitCount method
- IDebugBoundBreakpoint2::SetHitCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBoundBreakpoint2::SetHitCount

Sets the hit count for the bound breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetHitCount( 
   uint dwHitCount
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetHitCount( 
   DWORD dwHitCount
);
```
---

## Parameters
`dwHitCount`\
[in] The hit count to set.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).

## Remarks
 The hit count is the number of times this breakpoint has fired during the current run of the session.

 This method is typically called by the debug engine to update the current hit count on this breakpoint.

## See also
- [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
