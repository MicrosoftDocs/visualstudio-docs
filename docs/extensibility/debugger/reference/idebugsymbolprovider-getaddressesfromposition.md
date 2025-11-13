---
description: "This method maps a document position into an array of debug addresses."
title: IDebugSymbolProvider::GetAddressesFromPosition
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugSymbolProvider::GetAddressesFromPosition
helpviewer_keywords:
- IDebugSymbolProvider::GetAddressesFromPosition method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugSymbolProvider::GetAddressesFromPosition

This method maps a document position into an array of debug addresses.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAddressesFromPosition( 
   IDebugDocumentPosition2  pDocPos,
   bool                     fStatmentOnly,
   out IEnumDebugAddresses  ppEnumBegAddresses,
   out IEnumDebugAddresses  ppEnumEndAddresses
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAddressesFromPosition( 
   IDebugDocumentPosition2* pDocPos,
   BOOL                     fStatmentOnly,
   IEnumDebugAddresses**    ppEnumBegAddresses,
   IEnumDebugAddresses**    ppEnumEndAddresses
);
```
---

## Parameters
`pDocPos`\
[in] The document position.

`fStatmentOnly`\
[in] If TRUE, limits the debug addresses to a single statement.

`ppEnumBegAddresses`\
[out] Returns an enumerator for the starting debug addresses associated with this statement or line.

`ppEnumEndAddresses`\
[out] Returns an [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md) enumerator for the ending debug addresses associated with this statement or line.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A document position typically indicates a range of source lines. This method provides the starting and ending debug addresses associated with these lines. Some languages allow statements that span multiple lines, or lines that contains more than one statement. This method provides a flag to limit the debug addresses to a single statement.

 It is possible for a single statement to have multiple debug addresses, as in the case of templates.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [GetAddressesFromContext](../../../extensibility/debugger/reference/idebugsymbolprovider-getaddressesfromcontext.md)
- [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)
