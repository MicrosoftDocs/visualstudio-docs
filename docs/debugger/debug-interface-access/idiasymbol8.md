---
description: "Describes additional properties of a symbol instance relating to coroutines."
title: "IDiaSymbol8"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol8 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol8

Describes additional properties of a symbol instance relating to coroutines.

## Syntax

```
IDiaSymbol8 : IDiaSymbol7
```

## Methods

The following table shows the methods of `IDiaSymbol8`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol8::get_coroutineKind`](../../debugger/debug-interface-access/idiasymbol8-get-coroutinekind.md)|Retrieves the coroutine function kind.|
|[`IDiaSymbol8::get_associatedSymbolKind`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymbolkind.md)|Retrieves the associated symbol kind.|
|[`IDiaSymbol8::get_associatedSymbolSection`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymbolsection.md)|Retrieves the section component of the address of the associated symbol.|
|[`IDiaSymbol8::get_associatedSymbolOffset`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymboloffset.md)|Retrieves the offset component of the address of the associated symbol.|
|[`IDiaSymbol8::get_associatedSymbolRva`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymbolrva.md)|Retrieves the relative virtual address (RVA) of the associated symbol.|
|[`IDiaSymbol8::get_associatedSymbolAddr`](../../debugger/debug-interface-access/idiasymbol8-get-associatedsymboladdr.md)|Retrieves the virtual address (VA) of the associated symbol.|

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
- [`IDiaSymbol3`](../../debugger/debug-interface-access/idiasymbol3.md)
- [`IDiaSymbol4`](../../debugger/debug-interface-access/idiasymbol4.md)
- [`IDiaSymbol5`](../../debugger/debug-interface-access/idiasymbol5.md)
- [`IDiaSymbol6`](../../debugger/debug-interface-access/idiasymbol6.md)
- [`IDiaSymbol7`](../../debugger/debug-interface-access/idiasymbol7.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
