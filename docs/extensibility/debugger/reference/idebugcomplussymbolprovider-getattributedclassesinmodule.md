---
description: "Retrieves the classes with the specified attribute in a given module."
title: IDebugComPlusSymbolProvider::GetAttributedClassesinModule
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugComPlusSymbolProvider::GetAttributedClassesinModule
- GetAttributedClassesinModule
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugComPlusSymbolProvider::GetAttributedClassesinModule

Retrieves the classes with the specified attribute in a given module.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAttributedClassesinModule (
    uint                 ulAppDomainID,
    Guid                 guidModule,
    string               pstrAttribute,
    out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAttributedClassesinModule (
    ULONG32            ulAppDomainID,
    GUID               guidModule,
    LPOLESTR           pstrAttribute,
    IEnumDebugFields** ppEnum
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier of the application domain.

`guidModule`\
[in] Unique identifier of the module.

`pstrAttribute`\
[in] The attribute string.

`ppEnum`\
[out] Returns an enumeration of the attributed classes.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.

```cpp
HRESULT CDebugSymbolProvider::GetAttributedClassesinModule(
    ULONG32 ulAppDomainID,
    GUID guidModule,
    __in_z LPOLESTR pstrAttribute,
    IEnumDebugFields** ppEnum
)
{
    HRESULT hr = S_OK;
    CComPtr<CModule> pModule;
    CComPtr<IMetaDataImport> pMetaData;
    Module_ID idModule(ulAppDomainID, guidModule);
    const void* pUnused;
    ULONG cbUnused;
    HCORENUM hEnum = 0;
    ULONG cTypeDefs = 0;
    ULONG cEnum;
    DWORD iTypeDef = 0;
    mdTypeDef* rgTypeDefs = NULL;
    IDebugField** rgFields = NULL;
    DWORD ctField = 0;
    CEnumDebugFields* pEnumFields = NULL;

    METHOD_ENTRY( CDebugSymbolProvider::GetAttributedClassesinModule );

    IfFalseGo( pstrAttribute && ppEnum , E_INVALIDARG );
    IfFailGo( GetModule( idModule, &pModule ) );
    pModule->GetMetaData( &pMetaData );

    IfFailGo( pMetaData->EnumTypeDefs( &hEnum,
                                       NULL,
                                       0,
                                       &cTypeDefs ) );

    IfFailGo( pMetaData->CountEnum( hEnum, &cEnum ) );
    pMetaData->CloseEnum(hEnum);
    hEnum = NULL;

    IfNullGo( rgTypeDefs = new mdTypeDef[cEnum], E_OUTOFMEMORY );
    IfNullGo( rgFields = new IDebugField * [cEnum], E_OUTOFMEMORY );

    IfFailGo( pMetaData->EnumTypeDefs( &hEnum,
                                       rgTypeDefs,
                                       cEnum,
                                       &cTypeDefs ) );

    for ( iTypeDef = 0; iTypeDef < cTypeDefs; iTypeDef++)
    {

        if (pMetaData->GetCustomAttributeByName( rgTypeDefs[iTypeDef],
                pstrAttribute,
                &pUnused,
                &cbUnused ) == S_OK)
        {
            if (CreateClassType( idModule, rgTypeDefs[iTypeDef], rgFields + ctField) == S_OK)
            {
                ctField++;
            }
            else
            {
                ASSERT(!"Failed to Create Attributed Class");
            }
        }
    }

    IfNullGo( pEnumFields = new CEnumDebugFields, E_OUTOFMEMORY );
    IfFailGo( pEnumFields->Initialize(rgFields, ctField) );
    IfFailGo( pEnumFields->QueryInterface( __uuidof(IEnumDebugFields),
                                           (void**) ppEnum ) );

Error:

    METHOD_EXIT( CDebugSymbolProvider::GetAttributedClassesinModule, hr );

    DELETERG( rgTypeDefs );

    for ( iTypeDef = 0; iTypeDef < ctField; iTypeDef++)
    {
        RELEASE( rgFields[iTypeDef] );
    }

    DELETERG( rgFields );
    RELEASE( pEnumFields );

    return hr;
}
```

## See also
- [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
