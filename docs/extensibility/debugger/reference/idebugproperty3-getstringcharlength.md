---
description: "Returns the number of characters in the associated property's string."
title: IDebugProperty3::GetStringCharLength
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3::GetStringCharLength
helpviewer_keywords:
- IDebugProperty3::GetStringCharLength
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty3::GetStringCharLength

Returns the number of characters in the associated property's string.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetStringCharLength(
    out uint pLen
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetStringCharLength(
    ULONG *pLen
);
```
---

## Parameters

|Parameter|Description|
|---------------|-----------------|
|`pLen`|[out] Returns the number of characters in the property's string.|

## Return Value
If successful, returns `S_OK`; otherwise returns error code.

## Remarks
Typically, this method is used as a prelude to allocating a buffer for a call to the [GetStringChars](../../../extensibility/debugger/reference/idebugproperty3-getstringchars.md) method.

## Example
The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface.

```cpp
STDMETHODIMP CProperty::GetStringCharLength(ULONG *pLen)
{
    HRESULT hr = E_INVALIDARG;

    EVALFLAGS oldEVALFLAGS = m_EVALFLAGS;

    m_EVALFLAGS &= ~EVAL_NOFUNCEVAL;

    if (pLen)
    {
        DEBUG_PROPERTY_INFO dpInfo;
        dpInfo.bstrValue = NULL;
        ULONG ulen = 0;
        hr = GetPropertyInfo(DEBUGPROP_INFO_VALUE,10,DEFAULT_TIMEOUT,NULL,0,&dpInfo);
        if (hr == S_OK && dpInfo.bstrValue)
        {
            if (wcscmp(dpInfo.bstrValue,L"Nothing") == 0)
            {
                ulen = 0; //VSWhidbey#64815
            }
            else
            {
                ulen = ::SysStringLen(dpInfo.bstrValue);
                if( ulen > 2 &&
                    dpInfo.bstrValue[0] == L'"' &&
                    dpInfo.bstrValue[ulen-1] == L'"')
                {
                    ulen = ulen > 2 ? ulen - 2 : ulen; //remove two double quotes
                }
            }
        }
        ::SysFreeString(dpInfo.bstrValue);
        *pLen = ulen;
    }
    m_EVALFLAGS = oldEVALFLAGS;
    return hr;
}
```

## See also
- [GetStringChars](../../../extensibility/debugger/reference/idebugproperty3-getstringchars.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
