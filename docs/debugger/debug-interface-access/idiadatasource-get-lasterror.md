---
description: Retrieves the file name for the last load error.
title: "IDiaDataSource::get_lastError"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::get_lastError method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource::get_lastError

Retrieves the file name for the last load error.

## Syntax

```c++
HRESULT get_lastError (
   BSTR* pRetVal
);
```

#### Parameters

pRetVal

[out] Returns a string that contains the file name associated with the last error.

## Return Value

Returns the last error code caused by any previous operation. Returns `E_INVALIDARG` if the `pRetVal` parameter is `NULL`. Returns `E_OUTOFMEMORY` if there is insufficient resources to allocate a BSTR

## Example

```c++
BSTR    fileName;
HRESULT errorCode = pSource->get_lastError( &fileName );
```

## See also

- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
- [Common HRESULT Values (Debug Interface Access SDK)](../../debugger/debug-interface-access/common-hresult-values.md)
