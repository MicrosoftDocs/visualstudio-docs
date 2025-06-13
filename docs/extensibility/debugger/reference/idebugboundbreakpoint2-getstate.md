---
description: "Gets the state of this bound breakpoint."
title: IDebugBoundBreakpoint2::GetState
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBoundBreakpoint2::GetState
helpviewer_keywords:
- GetState method
- IDebugBoundBreakpoint2::GetState method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBoundBreakpoint2::GetState

Gets the state of this bound breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetState( 
    out enum_BP_STATE pState
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetState( 
    BP_STATE* pState
);
```
---

## Parameters
`pState`\
[out] Returns a value from the [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) enumeration that describes the state of the breakpoint.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a simple `CBoundBreakpoint` object that exposes the [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md) interface.

```
HRESULT CBoundBreakpoint::GetState(BP_STATE* pState)
{
    HRESULT hr;

    // Check for a valid pointer to pState and assign the local state variable.
    if (pState)
    {
        *pState = m_state;
        hr = S_OK;
    }
    else
    {
        hr = E_INVALIDARG;
    }

    return hr;
}
```

## See also
- [IDebugBoundBreakpoint2](../../../extensibility/debugger/reference/idebugboundbreakpoint2.md)
- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md)
