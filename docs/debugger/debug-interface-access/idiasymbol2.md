---
description: "Describes additional properties of a symbol instance related to Objective-C."
title: "IDiaSymbol2"
ms.date: "07/12/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol2 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol2

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol2 : IDiaSymbol
```

## Methods in Alphabetical Order

The following table shows the methods of `IDiaSymbol2`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol2::get_isObjCCategory`](../../debugger/debug-interface-access/idiasymbol2-get-isobjccategory.md)|Retrieves a flag indicating whether this is an Objective-C category.|
|[`IDiaSymbol2::get_isObjCClass`](../../debugger/debug-interface-access/idiasymbol2-get-isobjcclass.md)|Retrieves a flag indicating whether this is an Objective-C class interface/implementation.|
|[`IDiaSymbol2::get_isObjCProtocol`](../../debugger/debug-interface-access/idiasymbol2-get-isobjcprotocol.md)|Retrieves a flag indicating whether this is an Objective-C protocol.|

## Remarks

## Notes for Callers

Obtain this interface by first getting an [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) instance and then calling [`IUnknown::QueryInterface`](/windows/win32/api/unknwn/nf-unknwn-iunknown-queryinterface(refiid_void)) to do a dynamic downcast

## Requirements

`Header:` Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
