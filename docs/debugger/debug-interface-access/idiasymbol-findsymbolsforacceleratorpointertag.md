---
description: Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function.
title: "IDiaSymbol::findSymbolsForAcceleratorPointerTag"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::findSymbolsForAcceleratorPointerTag

Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function.

## Syntax

```C++
HRESULT findSymbolsForAccleratorPointerTag (
   DWORD             tagValue,
   IDiaEnumSymbols** ppResult);
```

#### Parameters
 `tagValue`

[in] The pointer tag value for which the pointee symbol records are found.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer which is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
