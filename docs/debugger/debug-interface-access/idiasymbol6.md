---
description: "Describes additional properties of a symbol instance related to static member functions."
title: "IDiaSymbol6"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol6 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol6

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol6 : IDiaSymbol5
```

## Methods in Alphabetical Order

The following table shows the methods of `IDiaSymbol6`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol6::get_isStaticMemberFunc`](../../debugger/debug-interface-access/idiasymbol6-get-isstaticmemberfunc.md)|Retrieves a flag that indicates whether this function is a static member function.|

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
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
