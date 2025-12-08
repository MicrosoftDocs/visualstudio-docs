---
title: IDiaSymbol12
description: DIA interface providing version 12 extensions to IDiaSymbol.
ms.date: 12/08/2025
ms.topic: reference
dev_langs:
- C++
helpviewer_keywords:
- IDiaSymbol12
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSymbol12

Provides version 12 extensions to [IDiaSymbol](idiasymbol.md). This interface adds support for scalable vector register types (for example, Arm SVE).

## Syntax

```
IDiaSymbol12 : IDiaSymbol11
```

## Methods

The following table shows the methods of `IDiaSymbol12`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[IDiaSymbol12:get_scalableRegisterType](./idiasymbol12-get-scalableRegisterType.md)|Retrieves scalable vector register type for the symbol.|

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
- [`IDiaSymbol11`](../../debugger/debug-interface-access/idiasymbol11.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
