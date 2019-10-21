---
title: "IDiaSession::findInlineFramesByVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: df9e68f6-e0a4-4cf6-b11d-61c40351e0cd
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineFramesByVA
Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).

## Syntax

```C++
HRESULT findInlineFramesByVA ( 
   IDiaSymbol*       parent,   ULONGLONG         va,
   IDiaEnumSymbols** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` object representing the parent.

 `va`

[in] Specifies the address as a VA.

 `ppResult`

[out] Holds an `IDiaEnumSymbols` object that contains the list of frames that are retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)