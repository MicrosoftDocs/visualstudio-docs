---
description: Enables a client application to supply bytes of an executable file as specified by file position.
title: IDiaReadExeAtOffsetCallback
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaReadExeAtOffsetCallback interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaReadExeAtOffsetCallback

Enables a client application to supply bytes of an executable file as  specified by file position.

## Syntax

`IDiaReadExeAtOffsetCallback : IUnknown`

## Methods in Vtable Order
 The following table shows the methods of `IDiaReadExeAtOffsetCallback`.

|Method|Description|
|------------|-----------------|
|[IDiaReadExeAtOffsetCallback::ReadExecutableAt](../../debugger/debug-interface-access/idiareadexeatoffsetcallback-readexecutableat.md)|Reads the specified number of bytes starting at the specified offset from an executable file.|

## Remarks
 The client application implements this interface in order to provide the bytes of the executable using an absolute offset into the executable's file. To use a relative virtual address, implement the [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md) interface.

## Notes for Callers
 This method is implemented by the client application and passed to the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method as an alternative method for reading the file.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
