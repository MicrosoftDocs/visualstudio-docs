---
description: "Binds this pending breakpoint to one or more code locations."
title: IDebugPendingBreakpoint2::Bind
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2::Bind
helpviewer_keywords:
- Bind method
- IDebugPendingBreakpoint2::Bind method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPendingBreakpoint2::Bind

Binds this pending breakpoint to one or more code locations.

## Syntax

### [C#](#tab/csharp)
```csharp
int Bind();
```
### [C++](#tab/cpp)
```cpp
HRESULT Bind( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.

## Remarks
 When this method is called, a debug engine (DE) should attempt to bind this pending breakpoint to all code locations that match.

 After this method returns, the caller needs to wait for events indicating that the pending breakpoint has bound or is in error before assuming that calls to the [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md) or [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md).methods will enumerate all bound or error breakpoints, respectively.

## See also
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [IDebugBreakpointBoundEvent2](../../../extensibility/debugger/reference/idebugbreakpointboundevent2.md)
- [IDebugBreakpointErrorEvent2](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md)
- [EnumBoundBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)
- [EnumErrorBreakpoints](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md)
