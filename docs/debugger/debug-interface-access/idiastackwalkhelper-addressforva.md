---
description: Returns the equivalent address (section and offset) for the specified VA.
title: "IDiaStackWalkHelper::addressForVA"
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::addressForVA method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper::addressForVA

Returns the equivalent address (section and offset) for the specified VA.

## Syntax

```C++
HRESULT addressForVA( 
   ULONGLONG  va,
   DWORD*     pISect,
   DWORD*     pOffset
);
```

### Parameters

 `[in] va`

 Specifies the virtual address to translate.

 `[out] pISect`

 Returns the equivalent section for the specified address.

 `[out] pOffset`

 Returns the equivalent offset within the section for the specified address.

## Return Value

 If successful, returns `S_OK`. Returns `E_NOTIMPL` if the helper doesn't support translation; otherwise, returns an error code.

## See also

- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [`IDiaSession::addressForVA`](../../debugger/debug-interface-access/idiasession-addressForVA.md)
