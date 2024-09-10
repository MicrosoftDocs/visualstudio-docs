---
description: This method retrieves the value of the specified local variable as raw bytes.
title: "IDiaStackFrame::get_rawLVarInstanceValue"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackFrame::get_rawLVarInstanceValue method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackFrame::get_rawLVarInstanceValue

This method retrieves the value of the specified local variable as raw bytes.

## Syntax

```C++
HRESULT get_rawLVarInstanceValue(
   IDiaLVarInstance* pInstance,
   DWORD             cbDataMax,
   DWORD*            pcbData,
   BYTE*             pbData
);
```

#### Parameters
 `pInstance`

[in] An `IDiaLVarInstance` object representing an instance of local variable to get the value for.

 `cbDataMax`

[in] Maximum number of bytes in the buffer pointed to by `pbData`. This can be a maximum of 8 bytes (`sizeof(ULONGLONG)`).

 `pcbData`

[out] Returns the actual number of bytes stored in the buffer.

 `pbData`

[out] A buffer to be filled in with data. This cannot be `NULL`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
