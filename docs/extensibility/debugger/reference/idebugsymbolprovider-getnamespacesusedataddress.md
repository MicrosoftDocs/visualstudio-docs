---
title: "IDebugSymbolProvider::GetNamespacesUsedAtAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugSymbolProvider::GetNamespacesUsedAtAddress"
helpviewer_keywords:
  - "IDebugSymbolProvider::GetNamespacesUsedAtAddress method"
ms.assetid: 392de54b-9af0-4567-953b-1b41acd1e05c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugSymbolProvider::GetNamespacesUsedAtAddress
This method creates an enumerator for namespaces associated with the debug address.

## Syntax

```cpp
HRESULT GetNamespacesUsedAtAddress( 
   IDebugAddress*     pAddress,
   IEnumDebugFields** ppEnum
);
```

```csharp
int GetNamespacesUsedAtAddress(
   IDebugAddress        pAddress,
   out IEnumDebugFields ppEnum
);
```

## Parameters
`pAddress`\
[in] The debug address.

`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) enumerator for the namespaces.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 There may be several namespaces associated with a given debug address, for example, nested namespaces or multiple `using` statements.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)