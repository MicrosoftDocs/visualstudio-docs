---
description: "Gets the reason the breakpoint was unbound."
title: IDebugBreakpointUnboundEvent2::GetReason
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointUnboundEvent2::GetReason
helpviewer_keywords:
- IDebugBreakpointUnboundEvent2::GetReason
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointUnboundEvent2::GetReason

Gets the reason the breakpoint was unbound.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetReason(
    out enum_ BP_UNBOUND_REASON pdwUnboundReason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetReason(
    BP_UNBOUND_REASON* pdwUnboundReason
);
```
---

## Parameters
`pdwUnboundReason`\
[out] Returns a value from the [BP_UNBOUND_REASON](../../../extensibility/debugger/reference/bp-unbound-reason.md) enumeration specifying the reason the breakpoint was unbound.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
Reasons include a breakpoint being rebound to a different location after an edit-and-continue operation, or a determination that a breakpoint was bound in error.

## Example
The following example shows how to implement this method for a **CBreakpointUnboundDebugEventBase** object that exposes the [IDebugBreakpointUnboundEvent2](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2.md) interface.

```cpp
STDMETHODIMP CBreakpointUnboundDebugEventBase::GetReason(
    BP_UNBOUND_REASON* pdwUnboundReason)
{
    HRESULT hRes = E_FAIL;

    if ( EVAL(pdwUnboundReason) )
    {
        *pdwUnboundReason = m_dwReason;

        hRes = S_OK;
    }
    else
        hRes = E_INVALIDARG;

    return ( hRes );
}
```

## See also
- [IDebugBreakpointUnboundEvent2](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2.md)
