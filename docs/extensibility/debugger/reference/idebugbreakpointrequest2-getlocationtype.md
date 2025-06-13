---
title: IDebugBreakpointRequest2::GetLocationType
description: "Gets the breakpoint location type of this breakpoint request."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointRequest2::GetLocationType
helpviewer_keywords:
- IDebugBreakpointRequest2::GetLocationType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointRequest2::GetLocationType

Gets the breakpoint location type of this breakpoint request.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLocationType(
    out enum_BP_LOCATION_TYPE pBPLocationType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLocationType(
    BP_LOCATION_TYPE* pBPLocationType
);
```
---

## Parameters
`pBPLocationType`\
[out] Returns a value from the [BP_LOCATION_TYPE](../../../extensibility/debugger/reference/bp-location-type.md) enumeration that describes the location of this breakpoint request.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_FAIL` if the `bpLocation` field in the associated [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure is not valid.

## Example
The following example shows how to implement this method for a simple `CDebugBreakpointRequest` object that exposes the [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md) interface.

```
HRESULT CDebugBreakpointRequest::GetLocationType(BP_LOCATION_TYPE* pBPLocationType)
{
    HRESULT hr;

    if (pBPLocationType)
    {
        // Set default BP_LOCATION_TYPE.
        *pBPLocationType = BPLT_NONE;

        // Check if the BPREQI_BPLOCATION flag is set in BPREQI_FIELDS.
        if (IsFlagSet(m_bpRequestInfo.dwFields, BPREQI_BPLOCATION))
        {
            // Get the new BP_LOCATION_TYPE.
            *pBPLocationType = m_bpRequestInfo.bpLocation.bpLocationType;
            hr = S_OK;
        }
        else
        {
            hr = E_FAIL;
        }
    }
    else
    {
        hr = E_INVALIDARG;
    }

    return hr;
}
```

## See also
- [IDebugBreakpointRequest2](../../../extensibility/debugger/reference/idebugbreakpointrequest2.md)
- [BP_LOCATION_TYPE](../../../extensibility/debugger/reference/bp-location-type.md)
- [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md)
- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)
