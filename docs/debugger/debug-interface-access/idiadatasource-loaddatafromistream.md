---
description: Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.
title: "IDiaDataSource::loadDataFromIStream"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::loadDataFromIStream method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource::loadDataFromIStream

Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.

## Syntax

```c++
HRESULT loadDataFromIStream ( 
   IStream* pIStream
);
```

#### Parameters

`pIStream`

[in] An <xref:IStream> object representing the data stream to use.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|`E_PDB_FORMAT`|Attempted to access a file with an obsolete format.|
|`E_INVALIDARG`|Invalid parameter.|
|`E_UNEXPECTED`|Data source has already been prepared.|

## Remarks

This method allows the debug data for an executable to be obtained through an <xref:IStream> object.

To load with prefetching, use the [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md) method.

To load a .pdb file without validation, use the [`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md) method.

To validate the .pdb file against specific criteria, use the [`IDiaDataSource::loadAndValidateDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md) method.

To gain access to the data load process (through a callback mechanism), use the [`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

## See also

- [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)
- [`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md)
- [`IDiaDataSource::loadAndValidateDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md)
