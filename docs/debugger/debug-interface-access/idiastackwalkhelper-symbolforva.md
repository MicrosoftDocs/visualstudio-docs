---
description: "Retrieves the symbol that contains the specified virtual address."
title: "IDiaStackWalkHelper::symbolForVA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper::symbolForVA method"
ms.assetid: 8dd9455d-d44c-4dd6-a0aa-31131cbea2aa
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaStackWalkHelper::symbolForVA
Retrieves the symbol that contains the specified virtual address.

## Syntax

```C++
HRESULT symbolForVA( 
   ULONGLONG     va,
   IDiaSymbol**  ppSymbol
);
```

#### Parameters
 `va`

[in] The virtual address that is contained in the requested symbol. The symbol must be a `SymTagFunctionType` (a value from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration).

 `ppSymbol`

[out] An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the symbol at the specified address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
