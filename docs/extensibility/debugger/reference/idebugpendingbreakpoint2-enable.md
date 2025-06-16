---
description: "Toggles the enabled state of the pending breakpoint."
title: IDebugPendingBreakpoint2::Enable
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPendingBreakpoint2::Enable
helpviewer_keywords:
- IDebugPendingBreakpoint2::Enable method
- Enable method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPendingBreakpoint2::Enable

Toggles the enabled state of the pending breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int Enable(
    int fEnable
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Enable(
    BOOL fEnable
);
```
---

## Parameters
`fEnable`\
[in] Set to nonzero (`TRUE`) to enable a pending breakpoint, or to zero (`FALSE`) to disable.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_BP_DELETED` if the breakpoint has been deleted.

## Remarks
When a pending breakpoint is enabled or disabled, all breakpoints bound from it are set to the same state.

This method may be called as many times as necessary, even if the breakpoint is already enabled or disabled.

## Example
The following example shows how to implement this method for a simple `CPendingBreakpoint` object that exposes the [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) interface.

```cpp
HRESULT CPendingBreakpoint::Enable(BOOL fEnable)
{
    HRESULT hr;

    // Verify that the pending breakpoint has not been deleted. If deleted,
    // then return hr = E_BP_DELETED.
    if (m_state.state != PBPS_DELETED)
    {
        // If the bound breakpoint member variable is valid, then enable or
        // disable the bound breakpoint.
        if (m_pBoundBP)
        {
            m_pBoundBP->Enable(fEnable);
        }
        // Set the PENDING_BP_STATE in the PENDING_BP_STATE_INFO structure
        // to enabled or disabled depending on the passed BOOL condition.
        m_state.state = fEnable ? PBPS_ENABLED : PBPS_DISABLED;
        hr = S_OK;

    }
    else
    {
        hr = E_BP_DELETED;
    }

    return hr;
}
```

## See also
- [IDebugPendingBreakpoint2](../../../extensibility/debugger/reference/idebugpendingbreakpoint2.md)
