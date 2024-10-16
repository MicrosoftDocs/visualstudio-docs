---
description: "Describes additional properties of a SymTagTaggedUnionCase symbol instance relating to tag ranges."
title: "IDiaSymbol11"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol11 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol11

Describes additional properties of a `SymTagTaggedUnionCase` symbol instance.

## Syntax

```
IDiaSymbol11 : IDiaSymbol10
```

## Methods

The following table shows the methods of `IDiaSymbol11`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol11::get_discriminatedUnionTag`](../../debugger/debug-interface-access/idiasymbol11-get-discriminateduniontag.md)|Retrieves information about the tag of a discriminated union symbol instance.|
|[`IDiaSymbol11::get_tagRanges`](../../debugger/debug-interface-access/idiasymbol11-get-tagranges.md)|Retrieves the ranges of tags within a discriminated union symbol instance.|


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
- [`IDiaSymbol10`](../../debugger/debug-interface-access/idiasymbol10.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)