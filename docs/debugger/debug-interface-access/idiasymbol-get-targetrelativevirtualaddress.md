---
title: "IDiaSymbol::get_targetRelativeVirtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_targetRelativeVirtualAddress method"
ms.assetid: 49a159f3-6943-44d3-90a3-0dba51e8a7ec
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_targetRelativeVirtualAddress
Retrieves the relative virtual address (RVA) of a thunk target.

## Syntax

```C++
HRESULT get_targetRelativeVirtualAddress ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the RVA of a thunk target.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property is valid only if the symbol as a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) value of `SymTagThunk`.

 A "thunk" is a piece of code that converts between a 32-bit memory address space (also known as flat address space) and a 16-bit address space (known as a segmented address space).

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)