---
description: Retrieves a unique identifier for the compiland that contributed this line.
title: "IDiaLineNumber::get_compilandId"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_compilandId method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLineNumber::get_compilandId

Retrieves a unique identifier for the compiland that contributed this line.

## Syntax

```c++
HRESULT get_compilandId ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns `DWORD` that contains the unique identifier for the compiland that contributed this line.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
