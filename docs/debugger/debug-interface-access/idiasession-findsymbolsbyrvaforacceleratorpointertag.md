---
description: Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.
title: "IDiaSession::findSymbolsByRVAForAcceleratorPointerTag"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findSymbolsByRVAForAcceleratorPointerTag

Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.

## Syntax

```C++
HRESULT findSymbolsByRVAForAcceleratorPointerTag ( 
   IDiaSymbol*           parent,
   DWORD                 tagValue,
   DWORD                 rva,
   IDiaEnumSymbols**     ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` that corresponds to the Accelerator stub function to be searched.

 `tagValue`

[in] The pointer tag value.

 `rva`

[in] The relative virtual address.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Call this method only on an `IDiaSymbol` interface that corresponds to an Accelerator stub function.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
