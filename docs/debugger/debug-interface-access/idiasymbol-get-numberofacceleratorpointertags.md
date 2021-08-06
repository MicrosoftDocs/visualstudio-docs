---
description: "Returns the number of accelerator pointer tags in a C++ AMP stub function."
title: "IDiaSymbol::get_numberOfAcceleratorPointerTags | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 1886e3ec-b227-4187-8d93-c5144b4b77ae
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
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
