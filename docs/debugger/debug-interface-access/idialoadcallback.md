---
description: Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.
title: IDiaLoadCallback
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLoadCallback interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaLoadCallback

Receives callbacks from the Debug Interface Access (DIA) symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.

## Syntax

`IDiaLoadCallback : IUnknown`

## Methods in Vtable Order

The following methods are exposed by this interface:

|Method|Description|
|------------|-----------------|
|[IDiaLoadCallback::NotifyDebugDir](../../debugger/debug-interface-access/idialoadcallback-notifydebugdir.md)|Called when a debug directory was found in the .exe file.|
|[IDiaLoadCallback::NotifyOpenDBG](../../debugger/debug-interface-access/idialoadcallback-notifyopendbg.md)|Called when a candidate .dbg file has been opened.|
|[IDiaLoadCallback::NotifyOpenPDB](../../debugger/debug-interface-access/idialoadcallback-notifyopenpdb.md)|Called when a candidate .pdb file has been opened.|
|[IDiaLoadCallback::RestrictRegistryAccess](../../debugger/debug-interface-access/idialoadcallback-restrictregistryaccess.md)|Determines if registry queries can be used to locate symbol search paths.|
|[IDiaLoadCallback::RestrictSymbolServerAccess](../../debugger/debug-interface-access/idialoadcallback-restrictsymbolserveraccess.md)|Determines if access is allowed to a symbol server to resolve symbols.|

## Remarks

The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

For additional restrictions that can be imposed on a load process, see the [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md) interface.

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaReadExeAtOffsetCallback](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)
- [IDiaReadExeAtRVACallback](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)
- [IDiaLoadCallback2](../../debugger/debug-interface-access/idialoadcallback2.md)
