---
description: Facilitates walking the stack using the program debug database (.pdb) file.
title: IDiaStackWalkHelper
ms.date: "11/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2 interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper

Facilitates walking the stack using the program debug database (.pdb) file.

## Syntax

```C++

IDiaStackWalkHelper: IUnknown

```

## Methods in VTable Order

 This table shows the methods of `IDiaStackWalkHelper`:

|Method|Description|
|------------|-----------------|
|[`IDiaStackWalkHelper::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-get-registervalue.md)|Retrieves the value of a register.|
|[`IDiaStackWalkHelper::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-put-registervalue.md)|Sets the value of a register.|
|[`IDiaStackWalkHelper::readMemory`](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md)|Reads a block of data from the executable's image in memory.|
|[`IDiaStackWalkHelper::searchForReturnAddress`](../../debugger/debug-interface-access/idiastackwalkhelper-searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|
|[`IDiaStackWalkHelper::searchForReturnAddressStart`](../../debugger/debug-interface-access/idiastackwalkhelper-searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified stack address.|
|[`IDiaStackWalkHelper::frameForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-frameforva.md)|Retrieves the stack frame that contains the specified virtual address (VA).|
|[`IDiaStackWalkHelper::symbolForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-symbolforva.md)|Retrieves the symbol that contains the specified VA. **Note:**  Symbol must have the type `SymTagFunctionType` (a value from the [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration).|
|[`IDiaStackWalkHelper::pdataForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-pdataforva.md)|Returns the PDATA data block  associated with the specified VA.|
|[`IDiaStackWalkHelper::imageForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-imageforva.md)|Retrieves the starting VA of an executable, given a VA somewhere in the executable's memory space.|
|[`IDiaStackWalkHelper::addressForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-addressforva.md)|Returns the equivalent address (section and offset) for the specified VA.|
|[`IDiaStackWalkHelper::numberOfFunctionFragmentsForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-numberoffunctionfragmentsforva.md)|Retrieves the number of discontiguous fragments for the function at the specified VA.|
|[`IDiaStackWalkHelper::functionFragmentsForVA`](../../debugger/debug-interface-access/idiastackwalkhelper-functionfragmentsforva.md)|Retrieves the addresses and lengths of discontiguous fragments for the function at the specified VA.|

## Remarks

 This interface is called by the Debug Interface Access (DIA) code to obtain information about the executable to construct a list of stack frames during program execution.

## Notes for Callers

 A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) methods.

## Requirements

 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaFrameData`](../../debugger/debug-interface-access/idiaframedata.md)
- [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
- [`IDiaStackWalker::getEnumFrames2`](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)
