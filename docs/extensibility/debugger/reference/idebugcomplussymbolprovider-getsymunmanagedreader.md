---
description: "Retrieves the symbol reader to be used by unmanaged code."
title: IDebugComPlusSymbolProvider::GetSymUnmanagedReader
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider::GetSymUnmanagedReader
- GetSymUnmanagedReader
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::GetSymUnmanagedReader

Retrieves the symbol reader to be used by unmanaged code.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSymUnmanagedReader(
    uint       ulAppDomainID,
    Guid       guidModule,
    out object ppSymUnmanagedReader
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSymUnmanagedReader(
    ULONG32    ulAppDomainID,
    GUID       guidModule,
    IUnknown** ppSymUnmanagedReader
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier of the application domain.

`guidModule`\
[in] Unique identifier of the module.

`ppSymUnmanagedReader`\
[out] Returns the object that represents the symbol reader.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::GetSymUnmanagedReader(
    ULONG32 ulAppDomainID,
    GUID guidModule,
    IUnknown ** ppSymUnmanagedReader
)
{
    HRESULT hr = S_OK;
    CComPtr<CModule> pModule;
    Module_ID idModule(ulAppDomainID, guidModule);

    METHOD_ENTRY( CDebugSymbolProvider::GetSymUnmanagedReader );

    IfFailGo( GetModule( idModule, &pModule ) );
    IfFailGo( pModule->GetSymReader((ISymUnmanagedReader**) ppSymUnmanagedReader) );

Error:

    METHOD_EXIT( CDebugSymbolProvider::GetSymUnmanagedReader, hr );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
