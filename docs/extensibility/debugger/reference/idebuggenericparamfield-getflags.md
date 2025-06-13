---
description: "Retrieves the flags for this generic parameter."
title: IDebugGenericParamField::GetFlags
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetFlags
- IDebugGenericParamField::GetFlags
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericParamField::GetFlags

Retrieves the flags for this generic parameter.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetFlags(
    ref uint pdwFlags
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFlags(
    DWORD* pdwFlags
);
```
---

## Parameters
`pdwFlags`\
[out] Returns the flags for this generic parameter.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
These flags contain information about various special constraints.

## Example
The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md) interface.

```cpp
HRESULT CDebugGenericParamFieldType::GetFlags(DWORD *pdwFlags)
{
    HRESULT hr = S_OK;

    METHOD_ENTRY( CDebugGenericParamFieldType::GetFlags );

    IfFalseGo( pdwFlags, E_INVALIDARG );
    IfFailGo( this->LoadProps() );
    *pdwFlags = m_dwFlags;

Error:

    METHOD_EXIT( CDebugGenericParamFieldType::GetFlags, hr );
    return hr;
}
```

## See also
- [IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)
