---
description: "Gets the state of the pending breakpoint."
title: IDebugPendingBreakpoint2::GetState
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2::GetState
helpviewer_keywords:
- GetState method
- IDebugPendingBreakpoint2::GetState method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPendingBreakpoint2::GetState

Gets the state of the pending breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetState( 
   PENDING_BP_STATE_INFO[] pState
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetState( 
   PENDING_BP_STATE_INFO* pState
);
```
---

## Parameters
`pState`\
[in, out] A [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md) structure that is filled in with a description of this pending breakpoint.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md)
