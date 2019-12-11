---
title: "IDiaLineNumber::get_addressOffset | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_addressOffset method"
ms.assetid: 3bcb5500-b26c-4d3c-9d81-0a389a3715c3
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_addressOffset
Retrieves the offset part of the memory address where a block begins.

## Syntax

```C++
HRESULT get_addressOffset ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset part of the memory address where a block begins.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Example

```C++
CComPtr< IDiaLineNumber > pLine;
DWORD offset;
pLine->get_addressOffset( &offset);
```

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
- [IDiaLineNumber::get_addressSection](../../debugger/debug-interface-access/idialinenumber-get-addresssection.md)