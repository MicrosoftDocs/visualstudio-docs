---
title: "IDebugComPlusSymbolProvider::ReplaceSymbols | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "ReplaceSymbols"
  - "IDebugComPlusSymbolProvider::ReplaceSymbols"
ms.assetid: 82fbc8db-c4b1-432f-bec9-1a9dc09570be
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugComPlusSymbolProvider::ReplaceSymbols
Replaces the current debug symbols with those in the specified data stream.

## Syntax

```cpp
HRESULT ReplaceSymbols(
    ULONG32  ulAppDomainID,
    GUID     guidModule,
    IStream* pStream
);
```

```csharp
int ReplaceSymbols(
    uint    ulAppDomainID,
    Guid    guidModule,
    IStream pStream
);
```

## Parameters
`ulAppDomainID`\
[in] Identifier of the application domain.

`guidModule`\
[in] Unique identifier of the module.

`pStream`\
[in] Data stream that contains the new symbols.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::ReplaceSymbols(
    ULONG32 ulAppDomainID,
    GUID guidModule,
    IStream* pStream
)
{
    HRESULT hr = S_OK;
    CComPtr<CModule> pModule;
    Module_ID idModule(ulAppDomainID, guidModule);

    METHOD_ENTRY( CDebugSymbolProvider::ReplaceSymbols );

    IfFailGo( GetModule( idModule, &pModule ) );
    IfFailGo( pModule->ReplaceSymbols( pStream ) );

Error:

    METHOD_EXIT( CDebugSymbolProvider::ReplaceSymbols, hr );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
