---
description: "Retrieves a reference to the interface of the debug process."
title: IDebugCodeContext3::GetProcess
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugCodeContext3::GetProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCodeContext3::GetProcess

Retrieves a reference to the interface of the debug process.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetProcess(
    out IDebugProcess2 ppProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProcess(
    IDebugProcess2 **ppProcess
);
```
---

## Parameters
`ppProcess`\
[out] Reference to the debug process interface.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugCodeContext** object that exposes the [IDebugBeforeSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugbeforesymbolsearchevent2.md) interface.

```cpp
HRESULT CDebugCodeContext::GetProcess(IDebugProcess2** ppProcess)
{
    HRESULT hr = S_OK;
    CComPtr<CDebugEngine> pEngine;
    CComPtr<IDebugPort2> pPort2;

    IfFalseGo( ppProcess, E_INVALIDARG );
    *ppProcess = NULL;

    IfFalseGo( m_pProgram, E_FAIL );
    IfFailGo( ((CDebugProgram *)m_pProgram)->GetEngine(&pEngine) );
    IfFailGo( pEngine->GetSDMProcess(ppProcess) );

Error:

    return hr;
}
```

## See also
- [IDebugCodeContext3](../../../extensibility/debugger/reference/idebugcodecontext3.md)
