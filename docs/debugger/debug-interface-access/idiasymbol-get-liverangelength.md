---
description: "Returns the length of the address range in which the local symbol is valid."
title: "IDiaSymbol::get_liveRangeLength | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_liveRangeLength"
ms.assetid: ffcce3cc-085c-44eb-8145-46e3819c54f9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_liveRangeLength
Returns the length of the address range in which the local symbol is valid.

## Syntax

```C++
HRESULT get_liveRangeLength ( 
   ULONGLONG* length
);
```

#### Parameters
 `length`

[out] Returns the length of the address range.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A returned error code means that the symbol does not have live range information.

## Remarks

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
