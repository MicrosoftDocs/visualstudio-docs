---
description: "Describes additional properties of a symbol instance related to the inlinee ID."
title: "IDiaSymbol3"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol3 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol3

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol3 : IDiaSymbol2
```

## Methods in Alphabetical Order

The following table shows the methods of `IDiaSymbol3`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol3::get_inlinee`](../../debugger/debug-interface-access/idiasymbol3-get-inlinee.md)|Retrieves the inlinee symbol from a `SymTagInlineSite` symbol.|
|[`IDiaSymbol3::get_inlineeId`](../../debugger/debug-interface-access/idiasymbol3-get-inlineeid.md)|Retrieves the inlinee ID from a `SymTagInlineSite` symbol.|

## Remarks

## Notes for Callers

Obtain this interface by first getting an [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) instance and then calling [`IUnknown::QueryInterface`](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(refiid_void)) to do a dynamic downcast.

## Requirements

`Header:` Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol2`](../../debugger/debug-interface-access/idiasymbol2.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
