---
title: "IDiaSession::findSymbolByAddr | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findSymbolByAddr method"
ms.assetid: c130abc5-4d0a-4d2d-8286-94fde36ddd4a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findSymbolByAddr
Retrieves a specified symbol type that contains, or is closest to, a specified address.

## Syntax

```C++
HRESULT findSymbolByAddr ( 
   DWORD        isect,
   DWORD        offset,
   SymTagEnum   symtag,
   IDiaSymbol** ppSymbol
);
```

#### Parameters
 `isect`

[in] Specifies the section component of the address.

 `offset`

[in] Specifies the offset component of the address.

 `symtag`

[in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration.

 `ppSymbol`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

```C++
IDiaSymbol* pFunc;
pSession->findSymbolByAddr( isect, offset, SymTagFunction, &pFunc );
```

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)