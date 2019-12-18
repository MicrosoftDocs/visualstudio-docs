---
title: "IDiaEnumLineNumbers::Next | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumLineNumbers::Next method"
ms.assetid: 363d5b40-1316-4ab8-836f-63637f619e0a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumLineNumbers::Next
Retrieves a specified number of line numbers in the enumeration sequence.

## Syntax

```C++
HRESULT Next ( 
   ULONG            celt,
   IDiaLineNumber** rgelt,
   ULONG*           pceltFetched
);
```

#### Parameters
 celt

[in] The number of line numbers in the enumerator to be retrieved.

 rgelt

[out] Returns an array of [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md) objects that represent the desired line numbers.

 pceltFetched

[out] Returns the number of line numbers in the fetched enumerator.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more line numbers. Otherwise, returns an error code.

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
- [IDiaSession::findLinesByLinenum](../../debugger/debug-interface-access/idiasession-findlinesbylinenum.md)