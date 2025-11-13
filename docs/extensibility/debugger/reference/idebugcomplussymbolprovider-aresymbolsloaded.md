---
description: "Determines if the debug symbols are loaded for the specified module given the application domain identifier."
title: IDebugComPlusSymbolProvider::AreSymbolsLoaded
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- AreSymbolsLoaded
- IDebugComPlusSymbolProvider::AreSymbolsLoaded
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::AreSymbolsLoaded

Determines if the debug symbols are loaded for the specified module given the application domain identifier.

## Syntax

### [C#](#tab/csharp)
```csharp
int AreSymbolsLoaded (
    uint ulAppDomainID,
    Guid guidModule
);
```
### [C++](#tab/cpp)
```cpp
HRESULT AreSymbolsLoaded (
    ULONG32 ulAppDomainID,
    GUID    guidModule
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier for the application domain.

`guidModule`\
[in] Unique identifier for the module.

## Return Value
If the debug symbols are loaded, returns `S_OK`; otherwise, returns `S_FALSE`.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::AreSymbolsLoaded(
    ULONG32 ulAppDomainID,
    GUID guidModule
)
{
    HRESULT hr = S_OK;
    CComPtr<CModule> pModule;
    Module_ID idModule(ulAppDomainID, guidModule);

    METHOD_ENTRY( CDebugSymbolProvider::AreSymbolsLoaded );

    IfFalseGo( GetModule( idModule, &pModule ) == S_OK, S_FALSE );
Error:

    METHOD_EXIT( CDebugSymbolProvider::AreSymbolsLoaded, hr );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
