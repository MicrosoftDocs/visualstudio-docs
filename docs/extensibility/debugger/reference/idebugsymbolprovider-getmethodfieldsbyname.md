---
title: "IDebugSymbolProvider::GetMethodFieldsByName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugSymbolProvider::GetMethodFieldsByName"
helpviewer_keywords:
  - "IDebugSymbolProvider::GetMethodFieldsByName method"
ms.assetid: 1f781320-81ef-4037-b068-f1864b271258
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSymbolProvider::GetMethodFieldsByName
This method gets the field representing a fully qualified method name.

## Syntax

```cpp
HRESULT GetMethodFieldsByName( 
   LPCOLESTR          pszFullName,
   NAME_MATCH         nameMatch,
   IEnumDebugFields** ppEnum
);
```

```csharp
int GetMethodFieldsByName(
   string               pszFullName,
   NAME_MATCH           nameMatch,
   out IEnumDebugFields ppEnum
);
```

## Parameters
`pszFullName`\
[in] The method name.

`nameMatch`\
[in] Selects the type of match, for example, case-sensitive.

`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) enumerator for the fields associated with this method.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A method can be associated with multiple fields if it is overloaded, for example.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)