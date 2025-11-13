---
description: "Gets the pending breakpoint that caused the error."
title: IDebugErrorBreakpoint2::GetPendingBreakpoint
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorBreakpoint2::GetPendingBreakpoint
helpviewer_keywords:
- IDebugErrorBreakpoint2::GetPendingBreakpoint
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugErrorBreakpoint2::GetPendingBreakpoint

Gets the pending breakpoint that caused the error.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPendingBreakpoint ( 
   out IDebugPendingBreakpoint2 ppPendingBreakpoint
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPendingBreakpoint ( 
   IDebugPendingBreakpoint2** ppPendingBreakpoint
);
```
---

## Parameters
`ppPendingBreakpoint`\
[out] Returns an [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) object that represents the pending breakpoint that failed to be bound.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
