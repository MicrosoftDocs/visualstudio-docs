---
title: "IDiaSession::findSymbolByRVAEx | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findSymbolByRVAEx method"
ms.assetid: 61344966-fed4-4c02-9e27-20356ec2ef7c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findSymbolByRVAEx
Retrieves a specified symbol type that contains, or is closest to, a specified relative virtual address (RVA) and offset.

## Syntax

```C++
HRESULT findSymbolByRVAEx ( 
   DWORD        rva,
   SymTagEnum   symtag,
   IDiaSymbol** ppSymbol,
   LONG*        displacement
);
```

#### Parameters
 `rva`

[in] Specifies the RVA.

 `symtag`

[in] Symbol type to be found. Values are taken from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration.

 `ppSymbol`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol retrieved.

 `displacement`

[out] Returns a value specifying an offset from the relative virtual address specified in `rva`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

```C++
IDiaSymbol* pFunc;
LONG disp = 0;
pSession->findSymbolByRVAEx( rva, SymTagFunction, &pFunc, &disp );
```

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)