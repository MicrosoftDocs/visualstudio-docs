---
title: "IDiaSymbol::get_dataBytes | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_dataBytes method"
ms.assetid: 5eb37179-20d8-44ae-a72a-405c1b0435c4
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_dataBytes
Retrieves the data bytes of an OEM symbol.

## Syntax

```C++
HRESULT get_dataBytes ( 
   DWORD  cbData,
   DWORD* pcbData,
   BYTE   data[]
);
```

#### Parameters
 `cbData`

[in] Size of the buffer to hold the data.

 `pcbData`

[out] Returns the number of bytes written, or, if the `data` parameter is `NULL`, returns the number of bytes available.

 `data[]`
- [out,] A buffer that is filled in with the data bytes.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v7.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)