---
description: "Retrieves a flag that specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type float."
title: "IDiaSymbol::get_hfaFloat | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_hfaFloat method"
ms.assetid: 73ddcffe-cdac-4b03-be42-82ef985d17ee
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_hfaFloat
Retrieves a flag that specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type float.

## Syntax

```C++
HRESULT get_hfaFloat( 
   BOOL* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `TRUE` if the UDT contains HFA data of type float; otherwise, returns `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia100.dll

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md)
