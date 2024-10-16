---
description: Retrieves the source code bytes.
title: "IDiaInjectedSource::get_source"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_source method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaInjectedSource::get_source

Retrieves the source code bytes.

## Syntax

```c++
HRESULT get_source ( 
   DWORD  cbData,
   DWORD* pcbData,
   BYTE   data[]
);
```

#### Parameters

 `cbData`

[in] The number of bytes that represents the size of the data buffer.

 `pcbData`

[out] Returns the number of bytes that represents the bytes returned. If `data` is `NULL`, then `pcbData` is the total number of bytes of data available.

 `data[]`

[out] A buffer that is to be filled in with the source bytes.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also

- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
