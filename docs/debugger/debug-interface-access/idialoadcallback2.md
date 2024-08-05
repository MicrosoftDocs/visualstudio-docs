---
description: Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.
title: IDiaLoadCallback2
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback2 interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLoadCallback2

Receives callbacks from the Debug Interface Access (DIA) symbol locating procedure, allowing restrictions to be imposed on the locating process.

## Syntax

`IDiaLoadCallback2 : IDiaLoadCallback`

## Methods in Vtable Order
 In addition to the methods in the [IDiaLoadCallback](../../debugger/debug-interface-access/idialoadcallback.md) interface, this interface exposes the following methods:

|Method|Description|
|------------|-----------------|
|[IDiaLoadCallback2::RestrictOriginalPathAccess](../../debugger/debug-interface-access/idialoadcallback2-restrictoriginalpathaccess.md)|Determines if looking for a .pdb file in the original debug directory.|
|[IDiaLoadCallback2::RestrictReferencePathAccess](../../debugger/debug-interface-access/idialoadcallback2-restrictreferencepathaccess.md)|Determines if looking for a .pdb file is allowed in the path where the .exe file is located.|
|[IDiaLoadCallback2::RestrictDBGAccess](../../debugger/debug-interface-access/idialoadcallback2-restrictdbgaccess.md)|Determines if looking for debug information is allowed from .dbg files.|
|[IDiaLoadCallback2::RestrictSystemRootAccess](../../debugger/debug-interface-access/idialoadcallback2-restrictsystemrootaccess.md)|Determines if searching for .pdb files is allowed in the system root directory.|

## Remarks
 The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method. Remember to implement all of the methods in the [IDiaLoadCallback](../../debugger/debug-interface-access/idialoadcallback.md) interface as well.

## Requirements
 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)
- [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
- [IDiaLoadCallback](../../debugger/debug-interface-access/idialoadcallback.md)
