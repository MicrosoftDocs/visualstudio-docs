---
description: "Retrieves the stack frame pad size used for Edit and Continue."
title: "IDiaSymbol9::get_framePadSize"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol9::get_framePadSize method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol9::get_framePadSize

Retrieves the stack frame pad size used for Edit and Continue.

## Syntax

```C++
HRESULT get_framePadSize(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the size in bytes of the frame pad buffer that was added to the function for Edit and Continue.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)
- [`IDiaSymbol9::get_framePadOffset`](../../debugger/debug-interface-access/idiasymbol9-get-framepadoffset.md)
- [Edit and Continue (C++)](/visualstudio/debugger/edit-and-continue-visual-cpp)