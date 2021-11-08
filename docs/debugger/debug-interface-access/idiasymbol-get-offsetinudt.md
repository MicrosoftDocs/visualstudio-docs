---
description: "Retrieves the offset to the beginning of a user-defined type (UDT) of a member in the UDT."
title: "IDiaSymbol::get_offsetInUdt | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_offsetInUdt method"
ms.assetid: 442f20d9-9d6a-44a1-83fb-c3f8c14b6c97
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_offsetInUdt
Retrieves the offset to the beginning of a user-defined type (UDT) of a member in the UDT.

## Syntax

```C++
HRESULT get_offsetInUdt( 
   DWORD* pRetVal)
);
```

#### Parameters
 `pRetVal`

[out] Returns the offset in bytes of the symbol location.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This function is used only in local records in an optimized build.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
