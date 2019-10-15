---
title: "IDebugComPlusSymbolProvider::GetArrayTypeFromAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "GetArrayTypeFromAddress"
  - "IDebugComPlusSymbolProvider::GetArrayTypeFromAddress"
ms.assetid: cc0c53f1-8c0f-49fa-8dbe-bc155e9ce0ef
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugComPlusSymbolProvider::GetArrayTypeFromAddress
Retrieves type information about the specified array given its debug address.

## Syntax

```cpp
HRESULT GetArrayTypeFromAddress(
    IDebugAddress* pAddress,
    BYTE*          pSig,
    DWORD          dwSigLength,
    IDebugField**  ppField
);
```

```csharp
int GetArrayTypeFromAddress(
    IDebugAddress   pAddress,
    int[]           pSig,
    uint            dwSigLength,
    out IDebugField ppField
);
```

## Parameters
`pAddress`\
[in] The debug address represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`pSig`\
[in] The array to examine.

`dwSigLength`\
[in] Length in bytes of the `pSig` array.

`ppField`\
[out] Returns the array type as represented by an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) interface.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::GetArrayTypeFromAddress(
    IDebugAddress *pAddress,
    BYTE *pSig,
    DWORD dwSigLength,
    IDebugField **ppField)
{
    HRESULT hr = E_FAIL;
    CDEBUG_ADDRESS da;
    CDebugGenericParamScope* pGenScope = NULL;

    METHOD_ENTRY( CDebugDynamicFieldSymbol::GetArrayTypeFromAddress );

    ASSERT(IsValidObjectPtr(this, CDebugSymbolProvider));
    ASSERT(IsValidWritePtr(ppField, IDebugField*));

    IfFailGo( pAddress->GetAddress(&da) );

    if ( S_OK == hr )
    {
        IfNullGo( pGenScope = new CDebugGenericParamScope(da.GetModule(), da.tokClass, da.GetMethod()), E_OUTOFMEMORY );

        IfFailGo( this->CreateType((const COR_SIGNATURE*)(pSig), dwSigLength, da.GetModule(), mdMethodDefNil, pGenScope, ppField) );
    }

Error:

    METHOD_EXIT( CDebugDynamicFieldSymbol::GetArrayTypeFromAddress, hr );
    RELEASE( pGenScope );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
