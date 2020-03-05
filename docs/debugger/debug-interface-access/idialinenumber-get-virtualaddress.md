---
title: "IDiaLineNumber::get_virtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_virtualAddress method"
ms.assetid: 9048ef91-a59d-4ad8-90cb-4c13d0989241
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_virtualAddress
Retrieves the virtual address (VA) of the block.

## Syntax

```C++
HRESULT get_virtualAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the virtual address of the block.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)