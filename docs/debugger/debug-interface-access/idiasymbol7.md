---
description: "Describes additional properties of a symbol instance relating to signed return address protections."
title: "IDiaSymbol7"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol7 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol7

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol7 : IDiaSymbol6
```

## Methods in Alphabetical Order

The following table shows the methods of `IDiaSymbol7`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol7::get_isSignRet`](../../debugger/debug-interface-access/idiasymbol7-get-issignret.md)|Retrieves a flag that indicates whether this function has signed return address protections.|

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
