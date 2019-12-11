---
title: "IDiaStackWalkHelper | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2 interface"
ms.assetid: d66e5c84-565d-494e-8486-f91db9a34548
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaStackWalkHelper
Facilitates walking the stack using the program debug database (.pdb) file.

## Syntax

```

IDiaStackWalkHelper: IUnknown

```

## Methods in VTable Order
 The table below shows the methods of `IDiaStackWalkHelper`:

|Method|Description|
|------------|-----------------|
|[IDiaStackWalkHelper::get_registerValue](../../debugger/debug-interface-access/idiastackwalkhelper-get-registervalue.md)|Retrieves the value of a register.|
|[IDiaStackWalkHelper::put_registerValue](../../debugger/debug-interface-access/idiastackwalkhelper-put-registervalue.md)|Sets the value of a register.|
|[IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md)|Reads a block of data from the executable's image in memory.|
|[IDiaStackWalkHelper::searchForReturnAddress](../../debugger/debug-interface-access/idiastackwalkhelper-searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|
|[IDiaStackWalkHelper::searchForReturnAddressStart](../../debugger/debug-interface-access/idiastackwalkhelper-searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified stack address.|
|[IDiaStackWalkHelper::frameForVA](../../debugger/debug-interface-access/idiastackwalkhelper-frameforva.md)|Retrieves the stack frame that contains the specified virtual address.|
|[IDiaStackWalkHelper::symbolForVA](../../debugger/debug-interface-access/idiastackwalkhelper-symbolforva.md)|Retrieves the symbol that contains the specified virtual address. **Note:**  Symbol must have the type `SymTagFunctionType` (a value from the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration).|
|[IDiaStackWalkHelper::pdataForVA](../../debugger/debug-interface-access/idiastackwalkhelper-pdataforva.md)|Returns the PDATA data block  associated with the specified virtual address.|
|[IDiaStackWalkHelper::imageForVA](../../debugger/debug-interface-access/idiastackwalkhelper-imageforva.md)|Retrieves the starting virtual address of an executable, given a virtual address somewhere in the executable's memory space.|

## Remarks
 This interface is called by the DIA code to obtain information about the executable to construct a list of stack frames during program execution.

## Notes for Callers
 A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) methods.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
- [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)