---
description: "Retrieves the name of the assembly given its module and application domain."
title: IDebugComPlusSymbolProvider::GetAssemblyName
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider::GetAssemblyName
- GetAssemblyName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::GetAssemblyName

Retrieves the name of the assembly given its module and application domain.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAssemblyName(
    uint   ulAppDomainID,
    Guid   guidModule,
    string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAssemblyName(
    ULONG32 ulAppDomainID,
    GUID    guidModule,
    BSTR*   pbstrName
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier for the application domain.

`guidModule`\
[in] Unique identifier for the module.

`pbstrName`\
[out] Returns the name of the assembly.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::GetAssemblyName(
    ULONG32 ulAppDomainID,
    GUID guidModule,
    BSTR* pbstrName
)
{
    HRESULT hr = S_OK;
    Module_ID idModule(ulAppDomainID, guidModule);
    CComPtr<IMetaDataImport> pMetadata;

    METHOD_ENTRY( CDebugSymbolProvider::GetMetadataForModule );

    IfFalseGo( pbstrName, E_INVALIDARG );
    *pbstrName = NULL;

    IfFailGo( GetMetadata( idModule, &pMetadata ) );
    IfFailGo( GetAssemblyName( pMetadata, 0, pbstrName ) );

Error:

    METHOD_EXIT( CDebugSymbolProvider::GetMetadataForModule, hr );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
