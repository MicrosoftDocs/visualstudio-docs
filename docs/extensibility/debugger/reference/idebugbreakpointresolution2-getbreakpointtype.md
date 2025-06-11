---
description: "Gets the type of the breakpoint represented by this resolution."
title: IDebugBreakpointResolution2::GetBreakpointType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBreakpointResolution2::GetBreakpointType
helpviewer_keywords:
- IDebugBreakpointResolution2::GetBreakpointType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBreakpointResolution2::GetBreakpointType

Gets the type of the breakpoint represented by this resolution.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetBreakpointType( 
    out enum_ BP_TYPE pBPType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetBreakpointType( 
    BP_TYPE* pBPType
);
```
---

## Parameters
`pBPType`\
[out] Returns a value from the [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md) enumeration that specifies the type of this breakpoint.

## Return Value
If successful, returns `S_OK`; otherwise returns an error code. Returns E_FAIL if the `bpResLocation` field in the associated [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structure is not valid.

## Remarks
The breakpoint may be a code or a data breakpoint, for example.

## Example
The following example shows how to implement this method for a simple `CDebugBreakpointResolution` object that exposes the [IDebugBreakpointResolution2](../../../extensibility/debugger/reference/idebugbreakpointresolution2.md) interface.

```
HRESULT CDebugBreakpointResolution::GetBreakpointType(BP_TYPE* pBPType)
{
    HRESULT hr;

    if (pBPType)
    {
        // Set default BP_TYPE.
        *pBPType = BPT_NONE;

        // Check if the BPRESI_BPRESLOCATION flag is set in BPRESI_FIELDS.
        if (IsFlagSet(m_bpResolutionInfo.dwFields, BPRESI_BPRESLOCATION))
        {
            // Set the new BP_TYPE.
            *pBPType = m_bpResolutionInfo.bpResLocation.bpType;
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
- [IDebugBreakpointResolution2](../../../extensibility/debugger/reference/idebugbreakpointresolution2.md)
- [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md)
- [BPRESI_FIELDS](../../../extensibility/debugger/reference/bpresi-fields.md)
- [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)
- [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)
