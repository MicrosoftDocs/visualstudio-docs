---
description: "Sets or changes the pass count associated with the pending breakpoint."
title: IDebugPendingBreakpoint2::SetPassCount
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2::SetPassCount
helpviewer_keywords:
- SetPassCount method
- IDebugPendingBreakpoint2::SetPassCount method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPendingBreakpoint2::SetPassCount

Sets or changes the pass count associated with the pending breakpoint.

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
[in] A [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) structure that contains the pass count.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.

## Remarks
 Any pass count that was previously associated with the pending breakpoint is lost. All breakpoints bound from this pending breakpoint are called to set their pass count to the `bpPassCount` parameter.

## See also
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
- [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)
