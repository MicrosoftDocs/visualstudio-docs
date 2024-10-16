---
description: Retrieves the characteristics of this COFF section.
title: "IDiaSymbol::get_characteristics"
ms.date: "07/11/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_characteristics method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_characteristics

Retrieves the characteristics of this COFF section.

## Syntax

```C++
HRESULT get_characteristics ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the characteristics of this COFF section.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

The `DWORD` can contain values defined in `winnt.h` such as `IMAGE_SCN_CNT_INITIALIZED_DATA` or `IMAGE_SCN_MEM_READ` bitwise or'ed together.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
-[IMAGE_SECTION_HEADER structure (winnt.h)](/windows/win32/api/winnt/ns-winnt-image_section_header)
