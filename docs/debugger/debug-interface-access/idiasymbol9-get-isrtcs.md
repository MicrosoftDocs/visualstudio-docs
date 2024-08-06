---
description: "Retrieves a flag that indicates whether the function was compiled with runtime stack checks."
title: "IDiaSymbol9::get_isRTCs"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol9::get_isRTCs method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol9::get_isRTCs

Retrieves a flag that indicates whether the function was compiled with runtime stack checks.

## Syntax

```C++
HRESULT get_isRTCs(
   BOOL* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `TRUE` if the function was compiled with runtime stack checks (`/RTCs`); otherwise, returns `FALSE`.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)
- [`/RTC` (Run-time error checks)](/cpp/build/reference/rtc-run-time-error-checks)
