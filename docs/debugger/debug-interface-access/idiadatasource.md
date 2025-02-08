---
description: Initiates access to a source of debugging symbols.
title: IDiaDataSource
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource

Initiates access to a source of debugging symbols.

## Syntax

`IDiaDataSource : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaDataSource`.

|Method|Description|
|------------|-----------------|
|[`IDiaDataSource::get_lastError`](../../debugger/debug-interface-access/idiadatasource-get-lasterror.md)|Retrieves the file name for the last load error.|
|[`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md)|Opens and prepares a program database (.pdb) file as a debug data source.|
|[`IDiaDataSource::loadAndValidateDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md)|Opens and verifies that the program database (.pdb) file matches the signature information provided; prepares the .pdb file as a debug data source.|
|[`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)|Opens and prepares the debug data associated with the .exe/.dll file.|
|[`IDiaDataSource::loadDataFromIStream`](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md)|Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.|
|[`IDiaDataSource::openSession`](../../debugger/debug-interface-access/idiadatasource-opensession.md)|Opens a session for querying symbols.|
|[`IDiaDataSource::loadDataFromCodeViewInfo`](../../debugger/debug-interface-access/idiadatasource-loaddatafromcodeviewinfo.md)|Opens and prepares the debug data associated with the provided CodeView information.|
|[`IDiaDataSource::loadDataFromMiscInfo`](../../debugger/debug-interface-access/idiadatasource-loaddatafrommiscinfo.md)|Opens and prepares the debug data associated with the provided debug information.|

## Remarks

A call to one of the load methods of the `IDiaDataSource` interface opens the symbol source. A successful call to the [IDiaDataSource::openSession](../../debugger/debug-interface-access/idiadatasource-opensession.md) method returns an [IDiaSession](../../debugger/debug-interface-access/idiasession.md) interface that supports querying the data source. If the load method returns a file-related error then the [IDiaDataSource::get_lastError](../../debugger/debug-interface-access/idiadatasource-get-lasterror.md) method return value contains the file name associated with the error.

## Notes for Callers

This interface is obtained by calling the `CoCreateInstance` function with the class identifier `CLSID_DiaSource` and the interface ID of `IID_IDiaDataSource`. The example shows how this interface is obtained.

## Example

```c++

      IDiaDataSource* pSource;
HRESULT hr = CoCreateInstance(CLSID_DiaSource,
                              NULL,
                              CLSCTX_INPROC_SERVER,
                              IID_IDiaDataSource,
                              (void**) &pSource);
if (FAILED(hr))
{
    // Report error and exit
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx2`](../../debugger/debug-interface-access/idiadatasourceex2.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
