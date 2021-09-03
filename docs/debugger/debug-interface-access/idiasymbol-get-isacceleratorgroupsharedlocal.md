---
description: "Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator."
title: "IDiaSymbol::get_isAcceleratorGroupSharedLocal | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 17a20542-5b45-478f-bb80-0d56031aadb5
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_isAcceleratorGroupSharedLocal
Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator.

## Syntax

```C++
HRESULT get_isAcceleratorGroupSharedLocal(
   BOOL* pFlag);
```

#### Parameters
 `pFlag`

[out] A pointer to a `BOOL` that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator. If `TRUE`, the `get_baseDataSlot` and `get_baseDataOffset` methods can be used to get the storage location information for the variable.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_baseDataSlot](../../debugger/debug-interface-access/idiasymbol-get-basedataslot.md)
- [IDiaSymbol::get_baseDataOffset](../../debugger/debug-interface-access/idiasymbol-get-basedataoffset.md)
