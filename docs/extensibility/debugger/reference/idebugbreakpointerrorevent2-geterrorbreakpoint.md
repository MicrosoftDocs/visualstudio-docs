---
title: "IDebugBreakpointErrorEvent2::GetErrorBreakpoint | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugBreakpointErrorEvent2::GetErrorBreakpoint"
helpviewer_keywords:
  - "IDebugBreakpointErrorEvent2::GetErrorBreakpoint"
ms.assetid: e5acfd19-ac17-47f3-a31a-b2aa8baca36d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugBreakpointErrorEvent2::GetErrorBreakpoint
Gets an [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) object that describes the reason why a breakpoint was not bound.

## Syntax

```cpp
HRESULT GetErrorBreakpoint( 
    IDebugErrorBreakpoint2** ppErrorBP
);
```

```csharp
int GetErrorBreakpoint( 
    out IDebugErrorBreakpoint2 ppErrorBP
);
```

## Parameters
`ppErrorBP`\
[out] Returns an [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) object that describes the warning or error.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
After the `IDebugErrorBreakpoint2` interface is obtained, call the [GetBreakpointResolution](../../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md) method to get an [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md) object. Then the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md) method can be used to determine an invalid location, an invalid expression, or reasons why the pending breakpoint was not bound, such as code not loaded yet, and so on.

## Example
The following example shows how to implement this method for a **CBreakpointSetDebugEventBase** object that exposes the [IDebugBreakpointErrorEvent2](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md) interface.

```cpp
STDMETHODIMP CBreakpointErrorDebugEventBase::GetErrorBreakpoint(
    IDebugErrorBreakpoint2 **ppbp)
{
    HRESULT hRes = E_FAIL;

    if ( ppbp )
    {
        if ( m_pError )
        {
            *ppbp = m_pError;

            m_pError->AddRef();

            hRes = S_OK;
        }
        else
            hRes = E_FAIL;
    }
    else
        hRes = E_INVALIDARG;

    return ( hRes );
}
```

## See also
- [IDebugBreakpointErrorEvent2](../../../extensibility/debugger/reference/idebugbreakpointerrorevent2.md)
- [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md)
- [IDebugErrorBreakpoint2](../../../extensibility/debugger/reference/idebugerrorbreakpoint2.md)
