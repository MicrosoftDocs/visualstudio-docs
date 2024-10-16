---
description: Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.
title: "IDiaSession::findSymbolsForAcceleratorPointerTag"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findSymbolsForAcceleratorPointerTag

Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.

## Syntax

```C++
HRESULT findSymbolsForAcceleratorPointerTag ( 
   IDiaSymbol*           parent,
   DWORD                 tagValue,
   IDiaEnumSymbols**     ppResult
);
```

#### Parameters
 `parent`

[in] An IDiaSymbol that corresponds to the Accelerator stub function to be searched.

 `tagValue`

[in] The pointer tag value.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
