---
description: Retrieves the value of the pointer authentication mask.
title: "IDiaStackWalkHelper2::GetPointerAuthenticationMask"
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2::GetPointerAuthenticationMask method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper2::GetPointerAuthenticationMask

Retrieves the value of the pointer authentication mask.

## Syntax

```C++
HRESULT GetPointerAuthenticationMask ( 
    ULONG64 PtrVal,
    ULONG64* AuthMask
);
```

#### Parameters

 `PtrVal`

[in] The pointer from the stack to be decoded.

 `AuthMask`

[out] Returns the value of the authentication mask.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks

 Currently only the ARM64 hardware and OS support pointer authentication, so this callback is only ever called when walking ARM64 stacks. If `AuthMask` has all the bits set (`0xFFFFFFFFFFFFFFFFull`), then it means that the target stack shares the same pointer authentication as the current process, and thus DIA should use the OS APIs to decode the pointer. Conversely if `AuthMask` has no bits set it means that pointer authentication is not in use or enabled and thus the pointer does not need to be decoded. Otherwise the `AuthMask` should have 1 bit set for every part of the pointer that is part of the pointer authentication, and 0 for the base parts of the pointer.

## See also

- [`IDiaStackWalkHelper2`](../../debugger/debug-interface-access/idiastackwalkhelper2.md)
- [`IDiaSymbol7::get_isSignRet`](../../debugger/debug-interface-access/idiasymbol7-get-issignret.md)
