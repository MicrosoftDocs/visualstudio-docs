---
description: "Retrieves the name of the module currently being debugged."
title: IDebugBeforeSymbolSearchEvent2::GetModuleName
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetModuleName
- IDebugBeforeSymbolSearchEvent2::GetModuleName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBeforeSymbolSearchEvent2::GetModuleName

Retrieves the name of the module currently being debugged.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetModuleName (
    string pbstrModuleName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetModuleName(
    BSTR *pbstrModuleName
);
```
---

## Parameters
`pbstrModuleName`\
[out] Name of the module.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugBeforeSymbolSearchEventBase** object that exposes the [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md) interface.

```cpp
STDMETHODIMP CDebugBeforeSymbolSearchEventBase::GetModuleName(BSTR *pbstrModuleName)
{
    HRESULT hRes = E_FAIL;

    if (m_bstrModuleName)
    {

        *pbstrModuleName = SysAllocString( m_bstrModuleName);

        if (*pbstrModuleName)
        {
            hRes = S_OK;
        }
    }

    return ( hRes );
}
```

## See also
- [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md)
