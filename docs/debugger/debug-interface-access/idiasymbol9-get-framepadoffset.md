---
description: "Retrieves the stack frame pad offset used for Edit and Continue."
title: "IDiaSymbol9::get_framePadOffset"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol9::get_framePadOffset method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol9::get_framePadOffset

Retrieves the stack frame pad offset used for Edit and Continue.

## Syntax

```C++
HRESULT get_framePadOffset(
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the offset in bytes from the frame pointer of the frame pad buffer that was added to the function for Edit and Continue.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)
- [`IDiaSymbol9::get_framePadSize`](../../debugger/debug-interface-access/idiasymbol9-get-framepadsize.md)
- [Edit and Continue (C++)](/visualstudio/debugger/edit-and-continue-visual-cpp)