---
title: "IDiaSymbol::get_timeStamp | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_timeStamp method"
ms.assetid: 5d707b76-dbaa-4d88-86c3-6f3672cc6d4c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_timeStamp
Retrieves the timestamp of the underlying executable file.

## Syntax

```C++
HRESULT get_timeStamp ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the timestamp of the underlying executable file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)