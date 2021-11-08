---
description: "Retrieves a flag that specifies whether the user-defined data type is an indirect virtual base class."
title: "IDiaSymbol::get_indirectVirtualBaseClass | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_indirectVirtualBaseClass method"
ms.assetid: 853b5c6f-e1cb-4675-ad36-9ee16e3341c3
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_indirectVirtualBaseClass
Retrieves a flag that specifies whether the user-defined data type is an indirect virtual base class.

## Syntax

```C++
HRESULT get_indirectVirtualBaseClass ( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the user-defined data type is an indirect virtual base class; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
