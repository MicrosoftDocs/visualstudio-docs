---
description: "Retrieves the index of this generic parameter."
title: IDebugGenericParamField::GetIndex
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugGenericParamField::GetIndex
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericParamField::GetIndex

Retrieves the index of this generic parameter.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetIndex(
    out uint pIndex
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetIndex(
    DWORD* pIndex
);
```
---

## Parameters
`pIndex`\
[out] Index value of this generic parameter.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
For example, for Dictionary(K,V), K is index 0, V is index 1.

## Example
The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md) interface.

```cpp
HRESULT CDebugGenericParamFieldType::GetIndex(DWORD* pIndex)
{
    HRESULT hr = S_OK;

    METHOD_ENTRY( CDebugGenericParamFieldType::GetIndex );

    IfFalseGo(pIndex, E_INVALIDARG );
    IfFailGo( this->LoadProps() );
    *pIndex = m_index;

Error:

    METHOD_EXIT( CDebugGenericParamFieldType::GetIndex, hr );
    return hr;
}
```

## See also
- [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)
