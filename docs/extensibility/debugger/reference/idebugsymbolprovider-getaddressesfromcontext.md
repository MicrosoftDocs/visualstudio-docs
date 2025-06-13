---
description: "This method maps a document context into an array of debug addresses."
title: IDebugSymbolProvider::GetAddressesFromContext
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetAddressesFromContext
helpviewer_keywords:
- IDebugSymbolProvider::GetAddressesFromContext method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetAddressesFromContext

This method maps a document context into an array of debug addresses.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAddressesFromContext(
   IDebugDocumentContext2  pDocContext,
   bool                    fStatmentOnly,
   out IEnumDebugAddresses ppEnumBegAddresses,
   out IEnumDebugAddresses ppEnumEndAddresses
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAddressesFromContext( 
   IDebugDocumentContext2* pDocContext,
   BOOL                    fStatmentOnly,
   IEnumDebugAddresses**   ppEnumBegAddresses,
   IEnumDebugAddresses**   ppEnumEndAddresses
);
```
---

## Parameters
`pDocContext`\
[in] The document context.

`fStatmentOnly`\
[in] If TRUE, limits the debug addresses to a single statement.

`ppEnumBegAddresses`\
[out] Returns an enumerator for the starting debug addresses associated with this statement or line.

`ppEnumEndAddresses`\
[out] Returns an [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md) enumerator for the ending debug addresses associated with this statement or line.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A document context typically indicates a range of source lines. This method provides the starting and ending debug addresses associated with these lines. Some languages allow statements that span multiple lines, or lines that contains more than one statement. This method provides a flag to limit the debug addresses to a single statement.

 It is possible for a single statement to have multiple debug addresses, as in the case of templates.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [GetAddressesFromPosition](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromposition.md)
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)
