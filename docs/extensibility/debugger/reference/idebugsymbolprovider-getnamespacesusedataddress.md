---
description: "This method creates an enumerator for namespaces associated with the debug address."
title: IDebugSymbolProvider::GetNamespacesUsedAtAddress
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetNamespacesUsedAtAddress
helpviewer_keywords:
- IDebugSymbolProvider::GetNamespacesUsedAtAddress method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetNamespacesUsedAtAddress

This method creates an enumerator for namespaces associated with the debug address.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetNamespacesUsedAtAddress(
   IDebugAddress        pAddress,
   out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetNamespacesUsedAtAddress( 
   IDebugAddress*     pAddress,
   IEnumDebugFields** ppEnum
);
```
---

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
