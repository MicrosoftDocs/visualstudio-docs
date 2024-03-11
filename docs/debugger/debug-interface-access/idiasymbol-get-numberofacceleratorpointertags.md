---
description: "Returns the number of accelerator pointer tags in a C++ AMP stub function."
title: "IDiaSymbol::get_numberOfAcceleratorPointerTags"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_numberOfAcceleratorPointerTags

Returns the number of accelerator pointer tags in a C++ AMP stub function.

## Syntax

```C++
HRESULT get_numberOfAcceleratorPointerTags(
   DWORD* count);
```

#### Parameters
 `count`

[out] A pointer to a `DWORD` that holds the number of accelerator pointer tags in a C++ AMP stub function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks
 This method is called on an `IDiaSymbol` interface that corresponds to a C++ AMP accelerator stub function.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
