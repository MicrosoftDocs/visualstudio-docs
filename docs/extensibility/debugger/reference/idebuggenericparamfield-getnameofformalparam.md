---
description: "Retrieves the name of this generic parameter."
title: IDebugGenericParamField::GetNameOfFormalParam
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugGenericParamField::GetNameOfFormalParam
- GetNameOfFormalParam
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericParamField::GetNameOfFormalParam

Retrieves the name of this generic parameter.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetNameOfFormalParam (
    string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetNameOfFormalParam (
    BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Name of this generic parameter.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md) interface.

```cpp
HRESULT CDebugGenericParamFieldType::GetNameOfFormalParam(BSTR *pbstrName)
{
    HRESULT hr = S_OK;
    CComBSTR bstrName;

    METHOD_ENTRY( CDebugGenericParamFieldType::GetNameOfFormalParam );

    IfFalseGo( pbstrName, E_INVALIDARG );
    IfFailGo( this->LoadProps() );
    IfNullGo( *pbstrName = SysAllocString(m_bstrName), E_OUTOFMEMORY );

Error:

    METHOD_EXIT( CDebugGenericParamFieldType::GetNameOfFormalParam, hr );
    return hr;
}
```

## See also
- [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)
