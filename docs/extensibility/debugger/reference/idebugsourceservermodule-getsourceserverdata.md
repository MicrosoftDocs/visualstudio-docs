---
description: "Retrieves an array of source server information."
title: IDebugSourceServerModule::GetSourceServerData
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSourceServerModule::GetSourceServerData
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSourceServerModule::GetSourceServerData

Retrieves an array of source server information.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetSourceServerData(
    out uint  pDataByteCount,
    out int[] ppData
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSourceServerData(
    ULONG* pDataByteCount,
    BYTE** ppData
);
```
---

## Parameters
`pDataByteCount`\
[out] Number of bytes in the data array.

`ppData`\
[out] Reference to the data array.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CModule** object that exposes the [IDebugSourceServerModule](../../../extensibility/debugger/reference/idebugsourceservermodule.md) interface.

```cpp
HRESULT CModule::GetSourceServerData(ULONG* pDataByteCount, BYTE** ppData)
{
    HRESULT hr = S_OK;
    CComPtr<ISymUnmanagedReader> pSymReader;
    CComPtr<ISymUnmanagedSourceServerModule> pSourceServerModule;

    IfFalseGo( pDataByteCount && ppData, E_INVALIDARG );
    *pDataByteCount = 0;
    *ppData = NULL;

    IfFailGo( this->GetUnmanagedSymReader( &pSymReader ) );
    IfFailGo( pSymReader->QueryInterface( &pSourceServerModule ) );

    IfFailGo( pSourceServerModule->GetSourceServerData( pDataByteCount, ppData ) );

Error:

    return hr;
}
```

## See also
- [IDebugSourceServerModule](../../../extensibility/debugger/reference/idebugsourceservermodule.md)
