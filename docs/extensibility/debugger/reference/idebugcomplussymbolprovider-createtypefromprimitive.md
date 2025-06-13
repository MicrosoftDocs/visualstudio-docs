---
description: "Creates a type from the specified primitive type."
title: IDebugComPlusSymbolProvider::CreateTypeFromPrimitive
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider::CreateTypeFromPrimitive
- CreateTypeFromPrimitive
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::CreateTypeFromPrimitive

Creates a type from the specified primitive type.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateTypeFromPrimitive(
    uint          dwPrimType,
    IDebugAddress pAddress,
    IDebugField   ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateTypeFromPrimitive(
    DWORD          dwPrimType,
    IDebugAddress* pAddress,
    IDebugField**  ppType
);
```
---

## Parameters
`dwPrimType`\
[in] Value from the [CorElementType Enumeration](/dotnet/framework/unmanaged-api/metadata/corelementtype-enumeration) that represents the primitive type.

`pAddress`\
[in] An address object represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`ppType`\
[in] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that describes the type.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::CreateTypeFromPrimitive(
    DWORD dwPrimType,
    IDebugAddress* pAddress,
    IDebugField** ppType)
{
    HRESULT hr = S_OK;
    CDEBUG_ADDRESS addr;
    const COR_SIGNATURE* pTypeInfo = (const COR_SIGNATURE*) & dwPrimType;
    CDebugGenericParamScope* pGenScope = NULL;

    //
    // This function will only work for primitive types
    //

    METHOD_ENTRY( CDebugSymbolProvider::CreateTypeFromPrimitive );

    IfFailGo( pAddress->GetAddress( &addr ) );

    IfNullGo( pGenScope = new CDebugGenericParamScope(addr.GetModule(), addr.tokClass, addr.GetMethod()), E_OUTOFMEMORY );

    IfFailGo( CreateType( pTypeInfo,
                          1,
                          addr.GetModule(),
                          addr.GetMethod(),
                          pGenScope,
                          ppType ) );

    METHOD_EXIT( CDebugSymbolProvider::CreateTypeFromPrimitive, hr );

Error:

    RELEASE( pGenScope );
    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
