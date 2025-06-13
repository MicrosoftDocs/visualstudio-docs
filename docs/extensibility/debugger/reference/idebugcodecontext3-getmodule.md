---
description: "Retrieves a reference to the interface of the debug module."
title: IDebugCodeContext3::GetModule
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugCodeContext3::GetModule
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCodeContext3::GetModule

Retrieves a reference to the interface of the debug module.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetModule(
    out IDebugModule2 ppModule
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetModule(
    IDebugModule2 **ppModule
);
```
---

## Parameters
`ppModule`\
[out] Reference to the debug module interface.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugCodeContext** object that exposes the [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md) interface.

```cpp
HRESULT CDebugCodeContext::GetModule(IDebugModule2** ppModule)
{
    HRESULT hr = S_OK;
    CComPtr<CModule> pModule;

    IfFalseGo( ppModule, E_INVALIDARG );
    *ppModule = NULL;

    IfFailGo( this->GetModule(&pModule) );
    IfFailGo( pModule->QueryInterface(IID_IDebugModule2, (void**) ppModule) );

Error:

    return hr;
}
```

## See also
- [IDebugCodeContext3](../../../extensibility/debugger/reference/idebugcodecontext3.md)
