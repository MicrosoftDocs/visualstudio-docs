---
description: "Retrieves the type or method owner of this generic parameter."
title: IDebugGenericParamField::GetOwner
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugGenericParamField::GetOwner
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericParamField::GetOwner

Retrieves the type or method owner of this generic parameter.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetOwner(
    out IDebugField ppOwner
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetOwner(
    IDebugField** ppOwner
);
```
---

## Parameters
`ppOwner`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that owns this generic parameter.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md) interface.

```cpp
HRESULT CDebugGenericParamFieldType::GetOwner(IDebugField** ppOwner)
{
    HRESULT hr = S_OK;
    CComPtr<IMetaDataImport> pMetadata;

    METHOD_ENTRY( CDebugGenericParamFieldType::GetOwner );

    IfFalseGo(ppOwner, E_INVALIDARG );
    *ppOwner = NULL;

    IfFailGo( this->LoadProps() );
    IfFailGo( m_spSH->GetMetadata( m_idModule, &pMetadata ) );

    switch (TypeFromToken(m_tokOwner))
    {
        case mdtMethodDef:
            {
                mdTypeDef tokClass;
                CComPtr<IDebugField> pClass;
                CDEBUG_ADDRESS caddr;
                CComPtr<IDebugContainerField> pContainer;

                IfFailGo( pMetadata->GetMethodProps( m_tokOwner, &tokClass, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL ) );
                IfFailGo( m_spSH->CreateClassType(m_idModule, tokClass, &pClass) );
                IfFailGo( pClass->QueryInterface( &pContainer ) );
                IfFailGo( caddr.InitializeMethod( m_idModule, tokClass, m_tokOwner, 0, 0 ) );
                IfFailGo( m_spSH->CreateMethodSymbol( pContainer, caddr, FIELD_SYM_MEMBER, ppOwner ) );
                break;
            }
        case mdtTypeDef:
            {
                IfFailGo( m_spSH->CreateClassType(m_idModule, m_tokOwner, ppOwner) );
                break;
            }
        default:
            {
                ASSERT(!"Unexpected Owner type for Generic Param Field");
                hr = E_FAIL;
            }
    }
Error:

    METHOD_EXIT( CDebugGenericParamFieldType::GetOwner, hr );
    return hr;
}
```

## See also
- [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)
