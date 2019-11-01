---
title: "IDiaSymbol::get_objectPointerType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_objectPointerType method"
ms.assetid: bce193b9-67b0-4c35-96e5-6a664937322e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_objectPointerType
Retrieves the type of the object pointer for a class method.

## Syntax

```C++
HRESULT get_objectPointerType ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the object pointer for a class method.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 This property applies only to symbols with a [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) type of `SymTagFunctionType`.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)