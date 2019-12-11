---
title: "IDebugErrorBreakpoint2::GetPendingBreakpoint | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugErrorBreakpoint2::GetPendingBreakpoint"
helpviewer_keywords:
  - "IDebugErrorBreakpoint2::GetPendingBreakpoint"
ms.assetid: 59d0defc-99fd-445c-bdac-8224d5dea3f9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugErrorBreakpoint2::GetPendingBreakpoint
Gets the pending breakpoint that caused the error.

## Syntax

```cpp
HRESULT GetPendingBreakpoint ( 
   IDebugPendingBreakpoint2** ppPendingBreakpoint
);
```

```csharp
int GetPendingBreakpoint ( 
   out IDebugPendingBreakpoint2 ppPendingBreakpoint
);
```

## Parameters
`ppPendingBreakpoint`\
[out] Returns an [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) object that represents the pending breakpoint that failed to be bound.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)