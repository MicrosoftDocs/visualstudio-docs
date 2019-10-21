---
title: "IDiaSymbol::get_objectFileName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 21793872-4879-4e4d-b527-dcf70aa7fb31
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_objectFileName
Retrieves the object file name.

## Syntax

```C++
HRESULT get_objectFilename(
   BSTR *pRetVal);
```

#### Parameters
 `pRetVal`

[out] A pointer to a `BSTR` that holds the object file name.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)