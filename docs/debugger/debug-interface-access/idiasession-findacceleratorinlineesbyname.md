---
description: Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.
title: "IDiaSession::findAcceleratorInlineesByName"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findAcceleratorInlineesByName

Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.

## Syntax

```C++
HRESULT findAcceleratorInlineeLinesByName ( 
   LPCOLESTR             name,
   DWORD                 option,
   IDiaEnumSymbols**     ppResult
);
```

#### Parameters
 `name`

[in] The inlinee function name to be searched.

 `option`

[in] The name search options to be used when searching for inline frames that correspond to `name`. For more information, see [NameSearchOptions Enumeration](../../debugger/debug-interface-access/namesearchoptions.md).

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This function searches for inlinees only within Accelerator stub functions. It ignores native C++ procedure records.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
