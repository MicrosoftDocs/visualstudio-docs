---
description: "Describes additional properties of a symbol instance relating to frames and runtime stack checks." 
title: "IDiaSymbol9"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol9 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol9

Describes additional properties of a symbol instance.

## Syntax

```
IDiaSymbol9 : IDiaSymbol8
```

## Methods

The following table shows the methods of `IDiaSymbol9`.

> [!NOTE]
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol9::get_framePadSize`](../../debugger/debug-interface-access/idiasymbol9-get-framepadsize.md)|Retrieves the stack frame pad size used for Edit and Continue.|
|[`IDiaSymbol9::get_framePadOffset`](../../debugger/debug-interface-access/idiasymbol9-get-framepadoffset.md)|Retrieves the stack frame pad offset used for Edit and Continue.|
|[`IDiaSymbol9::get_isRTCs`](../../debugger/debug-interface-access/idiasymbol9-get-isrtcs.md)|Retrieves a flag that indicates whether the function was compiled with runtime stack checks.|

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
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
- [Edit and Continue (C++)](/visualstudio/debugger/edit-and-continue-visual-cpp)
- [`/RTC` (Run-time error checks)](/cpp/build/reference/rtc-run-time-error-checks)
