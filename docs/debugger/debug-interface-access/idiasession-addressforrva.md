---
description: Returns the equivalent address for the specified relative virtual address (RVA).
title: "IDiaSession::addressForRVA"
ms.date: "07/03/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::addressForRVA method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::addressForRVA

Returns the equivalent address for the specified virtual address (VA).

## Syntax

```C++
HRESULT addressForRVA(
    DWORD rva,
    DWORD* pISect,
    DWORD* pOffset);
```

#### Parameters

 `rva`

[in] The relative virtual address to translate.

 `pISect`

[out] Returns the equivalent section for the specified address.

 `pOffset`

[out] Returns the equivalent offset within the section for the specified address.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

```C++
DWORD sect = 0, offset = 0;
pSession->addressForRVA( rva, &sect, &offset );
```

## See also

- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
