---
description: "Gets the current hit count for this bound breakpoint."
title: IDebugBoundBreakpoint2::GetHitCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2::GetHitCount
helpviewer_keywords:
- GetHitCount method
- IDebugBoundBreakpoint2::GetHitCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBoundBreakpoint2::GetHitCount

Gets the current hit count for this bound breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetHitCount( 
   out uint pdwHitCount
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetHitCount( 
   DWORD* pdwHitCount
);
```
---

## Parameters
`pdwHitCount`\
[out] Returns the hit count.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the state of the bound breakpoint object is set to `BPS_DELETED` (part of the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration).

## Remarks
 The hit count is the number of times this breakpoint has fired during the current run of the session.

## See also
- [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
