---
title: "IDiaEnumLineNumbers::Clone | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumLineNumbers::Clone method"
ms.assetid: fcd2479a-8ff7-4aba-a737-06123c280d54
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumLineNumbers::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```C++
HRESULT Clone ( 
   IDiaEnumLineNumbers** ppenum
);
```

#### Parameters
 `ppenum`

[out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a duplicate of the enumerator. The line numbers are not duplicated, only the enumerator..

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)