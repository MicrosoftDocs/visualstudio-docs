---
description: "Retrieves the texture slot."
title: "IDiaSymbol::get_textureSlot | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 166a1a3a-2e10-4baa-ace1-9104b56185ce
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_textureSlot
Retrieves the texture slot.

## Syntax

```C++
HRESULT get_textureSlot(
   DWORD* pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `DWORD` that holds the texture slot.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
