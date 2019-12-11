---
title: "IDiaEnumLineNumbers::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumLineNumbers::Item method"
ms.assetid: 08efbeaf-22f7-49e9-96a8-bb906dfe4fd8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumLineNumbers::Item
Retrieves a line number by means of an index.

## Syntax

```C++
HRESULT Item ( 
   DWORD            index,
   IDiaLineNumber** lineNumber
);
```

#### Parameters
 index

[in] Index of the [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumLineNumbers::get_Count](../../debugger/debug-interface-access/idiaenumlinenumbers-get-count.md) method.

 lineNumber

[out] Returns an [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md) object representing the desired line number.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)