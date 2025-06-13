---
description: "Determines if the specified debug address is a sequence point."
title: IDebugComPlusSymbolProvider2::IsAddressSequencePoint
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider2::IsAddressSequencePoint
- IsAddressSequencePoint
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider2::IsAddressSequencePoint

Determines if the specified debug address is a sequence point.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsAddressSequencePoint(
    IDebugAddress pAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsAddressSequencePoint(
    IDebugAddress* pAddress
);
```
---

## Parameters
`pAddress`\
[in] Debug address that is represented by the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

## Return Value
If the debug address is a sequence point, returns `S_OK`; otherwise, returns `S_FALSE`.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider2](../../../extensibility/debugger/reference/idebugcomplussymbolprovider2.md) interface.

```cpp
HRESULT CDebugSymbolProvider::IsAddressSequencePoint(
    IDebugAddress* pAddress
)
{
    HRESULT hr = S_OK;
    CDEBUG_ADDRESS address;
    CComPtr<CModule> pModule;

    METHOD_ENTRY( CDebugSymbolProvider::LoadSymbol );

    IfFalseGo( pAddress, E_INVALIDARG );

    IfFailGo( pAddress->GetAddress( &address ) );

    ASSERT(address.addr.dwKind == ADDRESS_KIND_METADATA_METHOD);
    IfFalseGo( address.addr.dwKind == ADDRESS_KIND_METADATA_METHOD, S_FALSE );

    IfFailGo( GetModule( address.GetModule(), &pModule) );

    if (!pModule->IsSequencePoint( address.addr.addr.addrMethod.tokMethod,
                                   address.addr.addr.addrMethod.dwVersion,
                                   address.addr.addr.addrMethod.dwOffset ))
    {

        // S_FALSE indicates this is not a sequence point

        hr = S_FALSE;
    }

Error:

    METHOD_EXIT( CDebugSymbolProvider::LoadSymbol, hr );

    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider2](../../../extensibility/debugger/reference/idebugcomplussymbolprovider2.md)
