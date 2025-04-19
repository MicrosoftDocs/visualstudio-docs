---
description: Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.
title: "IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag

Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.

## Syntax

```C++
HRESULT findSymbolsByRVAForAcceleratorPointerTag (
   DWORD             tagValue,
   DWORD             rva,
   IDiaEnumSymbols** ppResult);
```

#### Parameters
 `tagValue`

[in] The pointer tag value for which the pointee symbol records are found.

 `rva`

[in] The rva that is used to filter the symbols that correspond to the pointee variable with the specified tag value.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer which is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks
 Call this method only on an `IDiaSymbol` interface that corresponds to an Accelerator stub function.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
