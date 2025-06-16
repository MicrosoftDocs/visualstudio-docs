---
description: "Gets the breakpoint type."
title: IDebugErrorBreakpointResolution2::GetBreakpointType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorBreakpointResolution2::GetBreakpointType
helpviewer_keywords:
- IDebugErrorBreakpointResolution2::GetBreakpointType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugErrorBreakpointResolution2::GetBreakpointType

Gets the breakpoint type.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetBreakpointType(
    out enum_BP_TYPE pBPType
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
[out] Returns a value from the [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md) enumeration that describes the type of breakpoint.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
This method returns the type of the breakpoint that failed to bind, thus requiring an error breakpoint event.

## Example
The following example shows how to implement this method for a simple `CDebugErrorBreakpointResolution` object that exposes the [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md) interface.

```
HRESULT CDebugErrorBreakpointResolution::GetBreakpointType(BP_TYPE* pBPType)
{
    HRESULT hr;

    if (pBPType)
    {
        // Set default BP_TYPE.
        *pBPType = BPT_NONE;

        // Check if the BPERESI_BPRESLOCATION flag is set in BPERESI_FIELDS.
        if (IsFlagSet(m_bpErrorResolutionInfo.dwFields, BPERESI_BPRESLOCATION))
        {
            // Set the new BP_TYPE.
            *pBPType = m_bpErrorResolutionInfo.bpResLocation.bpType;
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
- [IDebugErrorBreakpointResolution2](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md)
- [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md)
