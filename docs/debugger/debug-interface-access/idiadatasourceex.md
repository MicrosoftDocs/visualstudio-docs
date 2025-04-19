---
description: Initiates access to a source of debugging symbols. Extends IDiaDataSource.
title: IDiaDataSourceEx
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx interface"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx

Initiates access to a source of debugging symbols and retrieves information about that source.

## Syntax

`IDiaDataSourceEx : IDiaDataSource`

## Methods in Vtable Order

The following table shows the methods of `IDiaDataSourceEx`.

|Method|Description|
|------------|-----------------|
|[`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md)|Opens and prepares a program database (.pdb) file as a debug data source.|
|[`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)|Opens and verifies that the program database (.pdb) file matches the signature information provided; prepares the .pdb file as a debug data source.|
|[`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md)|Opens and prepares the debug data associated with the .exe/.dll file.|
|[`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md)|Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.|
|[`IDiaDataSourceEx::getStreamSize`](../../debugger/debug-interface-access/idiadatasourceex-getstreamsize.md)|Reads the size of a named stream within this program database (.pdb) file.|
|[`IDiaDataSourceEx::getStreamRawData`](../../debugger/debug-interface-access/idiadatasourceex-getstreamrawdata.md)|Reads the data of a named stream within this program database (.pdb) file.|
|[`IDiaDataSourceEx::setPfnMiniPDBErrorCallback2`](../../debugger/debug-interface-access/idiadatasourceex-setpfnminipdberrorcallback2.md)|Set a callback function pointer for receiving error notifications relating to fastlink PDBs.|
|[`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md)|Only verifies that the program database (.pdb) file matches the signature information provided.|

## Remarks

A call to one of the load methods of the `IDiaDataSourceEx` interface opens the symbol source. A successful call to the [`IDiaDataSource::openSession`](../../debugger/debug-interface-access/idiadatasource-opensession.md) method returns an [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md) interface that supports querying the data source. If the load method returns a file-related error, then the [`IDiaDataSource::get_lastError`](../../debugger/debug-interface-access/idiadatasource-get-lasterror.md) method return value contains the file name associated with the error.

## Notes for Callers

This interface is obtained by calling the `CoCreateInstance` function with the class identifier `CLSID_DiaSource` and the interface ID of `IID_IDiaDataSourceEx`, or by calling `QueryInterface` on an existing `IDiaDataSource` interface pointer. The example shows how this interface is obtained.

## Example

```c++

      IDiaDataSource* pSource;
HRESULT hr = CoCreateInstance(CLSID_DiaSource,
                              NULL,
                              CLSCTX_INPROC_SERVER,
                              IID_IDiaDataSourceEx,
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

- [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)
- [`IDiaDataSourceEx2`](../../debugger/debug-interface-access/idiadatasourceex2.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
