---
description: "Determines that the function at the specified debug address is deleted."
title: IDebugComPlusSymbolProvider::IsFunctionDeleted
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider::IsFunctionDeleted
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::IsFunctionDeleted

Determines that the function at the specified debug address is deleted.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsFunctionDeleted(
    IDebugAddress pAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsFunctionDeleted(
    IDebugAddress* pAddress
);
```
---

## Parameters
`pAddress`\
[in] The debug address represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface. This address must be a METHOD_ADDRESS.

## Return Value
If the function is deleted, returns `S_OK`. If the function is exists, returns `S_FALSE`.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::IsFunctionDeleted(
    IDebugAddress* pAddress
)
{
    HRESULT hr = S_OK;
    CDEBUG_ADDRESS address;
    CComPtr<CModule> pModule;

    ASSERT(IsValidObjectPtr(this, CDebugSymbolProvider));
    ASSERT(IsValidInterfacePtr(pAddress, IDebugAddress));

    METHOD_ENTRY( CDebugSymbolProvider::IsFunctionDeleted );

    IfFalseGo( pAddress, S_FALSE );
    IfFailGo( pAddress->GetAddress( &address ) );

    ASSERT(address.addr.dwKind == ADDRESS_KIND_METADATA_METHOD);
    IfFalseGo( address.addr.dwKind == ADDRESS_KIND_METADATA_METHOD, S_FALSE );

    IfFailGo( GetModule( address.GetModule(), &pModule) );

    if (!pModule->IsFunctionDeleted( address.addr.addr.addrMethod.tokMethod,
                                     address.addr.addr.addrMethod.dwVersion,
                                     address.addr.addr.addrMethod.dwOffset ))
    {

        // S_FALSE indicates the function is not deleted

        hr = S_FALSE;
    }

Error:

    METHOD_EXIT( CDebugSymbolProvider::IsFunctionDeleted, hr );

    if (!SUCCEEDED(hr))
    {
        hr = S_FALSE;
    }

    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
