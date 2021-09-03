---
description: "IDiaSymbol::findInlineFramesByRVA retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA)."
title: "IDiaSymbol::findInlineFramesByRVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: e7a6d9cb-2726-4ac7-9f38-415ad215bf9c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::findInlineFramesByRVA
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).

## Syntax

```C++
HRESULT findInlineFramesByRVA (    DWORD             rva,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters
 `rva`

[in] Specifies the address as an RVA.

 `ppResult`

[out] Holds an `IDiaEnumSymbols` object that contains the list of frames that are retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
