---
description: "Maintains stack context between invocations of the IDiaFrameData::execute) method."
title: IDiaStackWalkFrame
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkFrame interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkFrame

Maintains stack context between invocations of the [IDiaFrameData::execute](../../debugger/debug-interface-access/idiaframedata-execute.md) method.

## Syntax

`IDiaStackWalkFrame : IUnknown`

## Methods in Vtable Order
 The following table shows the methods of `IDiaStackWalkFrame`.

|Method|Description|
|------------|-----------------|
|[IDiaStackWalkFrame::get_registerValue](../../debugger/debug-interface-access/idiastackwalkframe-get-registervalue.md)|Retrieves the value of a register.|
|[IDiaStackWalkFrame::put_registerValue](../../debugger/debug-interface-access/idiastackwalkframe-put-registervalue.md)|Sets the value of a register.|
|[IDiaStackWalkFrame::readMemory](../../debugger/debug-interface-access/idiastackwalkframe-readmemory.md)|Reads memory from image.|
|[IDiaStackWalkFrame::searchForReturnAddress](../../debugger/debug-interface-access/idiastackwalkframe-searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|
|[IDiaStackWalkFrame::searchForReturnAddressStart](../../debugger/debug-interface-access/idiastackwalkframe-searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified address.|

## Remarks
 This interface is used during program execution to read and write registers as well as access memory and find return addresses.

## Notes for Callers
 The client application implements this interface and passes an instance of the interface to the [IDiaFrameData::execute](../../debugger/debug-interface-access/idiaframedata-execute.md) method. The same instance of this interface is used again and again to maintain the state of the registers during each invocation of the `execute` method. The `execute` method also uses this interface to determine the return address.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaFrameData::execute](../../debugger/debug-interface-access/idiaframedata-execute.md)
