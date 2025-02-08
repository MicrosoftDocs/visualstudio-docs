---
description: Initiates access to a source of debugging symbols. Extends IDiaDataSource and IDiaDataSourceEx.
title: IDiaDataSourceEx2
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx2 interface"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx2

Initiates access to a source of debugging symbols and retrieves information about that source.

## Syntax

`IDiaDataSourceEx2 : IDiaDataSourceEx`

## Methods in Vtable Order

The following table shows the methods of `IDiaDataSourceEx2`.

|Method|Description|
|------------|-----------------|
|[`IDiaDataSourceEx2::findNamedStreams`](../../debugger/debug-interface-access/idiadatasourceex2-findnamedstreams.md)|Retrieves all names of named streams within the datasource that match the optionally given pattern.|

## Remarks

A call to one of the load methods of the `IDiaDataSource` interface opens the symbol source. A successful call to the [`IDiaDataSource::openSession`](../../debugger/debug-interface-access/idiadatasource-opensession.md) method returns an [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md) interface that supports querying the data source. If the load method returns a file-related error, then the [`IDiaDataSource::get_lastError`](../../debugger/debug-interface-access/idiadatasource-get-lasterror.md) method return value contains the file name associated with the error.

## Notes for Callers

This interface is obtained by calling the `CoCreateInstance` function with the class identifier `CLSID_DiaSource` and the interface ID of `IID_IDiaDataSourceEx`, or by calling `QueryInterface` on an existing `IDiaDataSource` interface pointer. The example shows how this interface is obtained.

## Example

```c++

      IDiaDataSource* pSource;
HRESULT hr = CoCreateInstance(CLSID_DiaSource,
                              NULL,
                              CLSCTX_INPROC_SERVER,
                              IID_IDiaDataSourceEx2,
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
- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
