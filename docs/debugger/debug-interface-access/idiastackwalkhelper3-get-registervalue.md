---
description: "IDiaStackWalkHelper3::get_registerValue retrieves the value of the specified register with variable-size support."
title: "IDiaStackWalkHelper3::get_registerValue"
ms.date: "02/12/2026"
ms.topic: "reference"
ms.custom: awp-ai
ai-usage: ai-assisted
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper3::get_registerValue method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper3::get_registerValue

Retrieves the value of the specified register.

## Syntax

```C++
HRESULT get_registerValue(
    DWORD index,
    DWORD cbData,
    DWORD* pcbData,
    BYTE* pbData
);
```

#### Parameters

`index`

[in] A value from the [`CV_HREG_e`](../../debugger/debug-interface-access/cv-hreg-e.md) enumeration specifying which register to get the value from. This parameter value is primarily intended for the ARM64 SVE registers.

`cbData`

[in] Size, in bytes, of the buffer pointed to by `pbData`. May be `0` when `pbData` is `nullptr`.

`pcbData`

[out] Receives the size, in bytes, of the register value. When `pbData` is `nullptr` and `cbData` is `0`, `pcbData` is set to the required size for the register value.

`pbData`

[out, optional] Caller-allocated buffer that receives the register value. May be `nullptr` to query the required size only.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

You can pass `pbData = nullptr` with `cbData = 0` to query only the required size of the register value. The method sets `pcbData` to the number of bytes needed. Allocate a buffer of that size and call again to retrieve the value.

Register sizes can differ between CPU architectures. This method supports variable-sized registers, including large vector registers such as ARM64 SVE.

For registers 64-bits or less (for example, 1-8 bytes), use `get_registerValue` and `put_registerValue` in [IDiaStackWalkHelper](../debug-interface-access/idiastackwalkhelper.md).

## See also

- [`IDiaStackWalkHelper3`](../../debugger/debug-interface-access/idiastackwalkhelper3.md)
- [`IDiaStackWalkHelper3::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper3-put-registervalue.md)
- [`CV_HREG_e` Enumeration](../../debugger/debug-interface-access/cv-hreg-e.md)
