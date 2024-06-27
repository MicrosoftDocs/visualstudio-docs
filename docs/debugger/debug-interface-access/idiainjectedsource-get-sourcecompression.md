---
description: Retrieves the indicator of the source compression used.
title: "IDiaInjectedSource::get_sourceCompression"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_sourceCompression method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaInjectedSource::get_sourceCompression

Retrieves the indicator of the source compression used.

## Syntax

```c++
HRESULT get_sourceCompression ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the indicator of the source compression used. A value of zero indicates that no source compression was used.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks

The value returned by this method is specific to the compiler used. For example, a compiler might use Run-Length Encoding or Huffman-style compression.

## See also

- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
