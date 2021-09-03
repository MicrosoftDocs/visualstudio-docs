---
description: "IDiaSession::findInlineFramesByRVA retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA)."
title: "IDiaSession::findInlineFramesByRVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: ddb3ff0e-cb3d-4fa0-af56-f064b218b264
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineFramesByRVA
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).

## Syntax

```C++
HRESULT findInlineFramesByRVA ( 
   IDiaSymbol*       parent,   DWORD             rva,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` object representing the parent.

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
