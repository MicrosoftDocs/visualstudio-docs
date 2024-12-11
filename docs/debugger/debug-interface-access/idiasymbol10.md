---
description: "Describes additional properties of a symbol instance relating to source links."
title: "IDiaSymbol10"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol10 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol10

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol10 : IDiaSymbol9
```

## Methods

The following table shows the methods of `IDiaSymbol10`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol10::get_sourceLink`](../../debugger/debug-interface-access/idiasymbol10-get-sourcelink.md)|Retreives the [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md) blob associated with this `SymTagCompiland` symbol.|

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
- [`IDiaSymbol8`](../../debugger/debug-interface-access/idiasymbol7.md)
- [`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
- [Using Source Link](https://github.com/dotnet/sourcelink#using-source-link-in-c-projects)
