---
description: "Retrieves a flag that specifies whether the user-defined data type is a virtual base class."
title: "IDiaSymbol::get_virtualBaseClass | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualBaseClass method"
ms.assetid: 474eddc6-bf16-4731-9145-6db2f2a0b4fd
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_virtualBaseClass
Retrieves a flag that specifies whether the user-defined data type is a virtual base class.

## Syntax

```C++
HRESULT get_virtualBaseClass ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the user-defined data type is a virtual base class; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
