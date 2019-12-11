---
title: "IDiaReadExeAtRVACallback | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaReadExeAtRVACallback interface"
ms.assetid: b2892513-3952-4f99-9b98-60cb9b1fdc91
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaReadExeAtRVACallback
Enables a client application to supply bytes of an executable file as specified by a relative virtual address.

## Syntax

```
IDiaReadExeAtRVACallback : IUnknown
```

## Methods in Vtable Order
 The following table shows the methods of `IDiaReadExeAtRVACallback`.

|Method|Description|
|------------|-----------------|
|[IDiaReadExeAtRVACallback::ReadExecutableAtRVA](../../debugger/debug-interface-access/idiareadexeatrvacallback-readexecutableatrva.md)|Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.|

## Remarks
 The client application implements this interface in order to provide the bytes of the executable using a relative virtual address into the executable's file. To use an absolute file offset, implement the [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md) interface.

## Notes for Callers
 This method is implemented by the client application and passed to the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method as an alternative method for reading the file.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)