---
description: "IDiaStackWalkHelper3::put_registerValue sets the value of the specified register."
title: "IDiaStackWalkHelper3::put_registerValue"
ms.date: "02/09/2026"
ms.topic: "reference"
ms.custom: awp-ai
ai-usage: ai-assisted
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper3::put_registerValue method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper3::put_registerValue

Sets the value of the specified register.

## Syntax

```C++
HRESULT put_registerValue(
    DWORD index,
    DWORD cbData,
    const BYTE* pbData
);
```

#### Parameters

`index`

[in] A value from the [`CV_HREG_e`](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying which register to modify. This parameter value is primarily intended for the ARM64 SVE registers.

`cbData`

[in] Size, in bytes, of the data pointed to by `pbData`.

`pbData`

[in] Buffer containing the new register value.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

Allows modifying register values during stack walking, for example, to support unwinding or simulating execution state.

Supports variable-sized registers, including large vector registers such as ARM64 SVE.

For registers 64-bits or less (for example, 1-8 bytes), use `get_registerValue` and `put_registerValue` in [IDiaStackWalkHelper](../debug-interface-access/idiastackwalkhelper.md).

## See also

- [`IDiaStackWalkHelper3`](../../debugger/debug-interface-access/idiastackwalkhelper3.md)
- [`IDiaStackWalkHelper3::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper3-get-registervalue.md)
- [`CV_HREG_e` Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)
