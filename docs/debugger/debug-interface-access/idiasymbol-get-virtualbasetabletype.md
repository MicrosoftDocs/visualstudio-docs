---
description: "Retrieves the type of a virtual base table pointer."
title: "IDiaSymbol::get_virtualBaseTableType"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_virtualBaseTableType method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_virtualBaseTableType

Retrieves the type of a virtual base table pointer.

## Syntax

```C++
HRESULT get_virtualBaseTableType(
   IDiaSymbol *pRetVal
};
```

#### Parameters

|Parameter|Description|
|---------------|-----------------|
|`pRetVal`|[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that specifies the type of base table.|

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 A virtual base table pointer (`vbtptr`) is a hidden pointer in a Visual C++ vtable that handles inheritance from virtual base classes. A `vbtptr` can have different sizes depending on the inherited classes.

 This method returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that can be used to determine the size of the vbtptr.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v8.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
