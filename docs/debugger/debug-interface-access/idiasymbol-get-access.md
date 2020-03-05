---
title: "IDiaSymbol::get_access | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_access method"
ms.assetid: 908976ae-95c4-4020-89c9-de137f727f98
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_access
Retrieves the access modifier of a class member.

## Syntax

```C++
HRESULT get_access ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [CV_access_e Enumeration](../../debugger/debug-interface-access/cv-access-e.md) enumeration that specifies the access modifier of a class member.

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
- [CV_access_e Enumeration](../../debugger/debug-interface-access/cv-access-e.md)