---
description: Retrieves the load address for the executable file that corresponds to the symbols in this symbol store.
title: "IDiaSession::get_loadAddress"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::get_loadAddress method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::get_loadAddress

Retrieves the load address for the executable file that corresponds to the symbols in this symbol store.

## Syntax

```C++
HRESULT get_loadAddress ( 
   ULONGLONG* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a virtual address (VA) where an .exe file or .dll file is loaded.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The returned load address is always zero unless specifically set using the [IDiaSession::put_loadAddress](../../debugger/debug-interface-access/idiasession-put-loadaddress.md) method.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSession::put_loadAddress](../../debugger/debug-interface-access/idiasession-put-loadaddress.md)
