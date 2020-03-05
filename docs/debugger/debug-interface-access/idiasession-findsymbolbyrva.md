---
title: "IDiaSession::findSymbolByRVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findSymbolByRVA method"
ms.assetid: 14fb2903-b771-44d6-b0a8-44e0097c58ce
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findSymbolByRVA
Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address (RVA).

## Syntax

```C++
HRESULT findSymbolByRVA ( 
   DWORD        rva,
   SymTagEnum   symtag,
   IDiaSymbol** ppSymbol
);
```

#### Parameters
 `rva`

[in] Specifies the RVA.

 `symtag`

[in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration.

 `ppSymbol`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

```C++
IDiaSymbol* pFunc;
pSession->findSymbolByRVA( rva, SymTagFunction, &pFunc );
```

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)