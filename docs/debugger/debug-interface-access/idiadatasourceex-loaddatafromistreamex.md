---
description: Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream, with optional record prefetching.
title: "IDiaDataSourceEx::loadDataFromIStreamEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::loadDataFromIStreamEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::loadDataFromIStreamEx

Prepares the debug data stored in a program database (.pdb) file accessed through a potentially in-memory data stream, with optional record prefetching.

## Syntax

```c++
HRESULT loadDataFromIStreamEx ( 
   IStream* pIStream,
   BOOL     fPdbPrefetching
);
```

#### Parameters

`pIStream`

[in] An <xref:IStream> object representing the data stream to use.

`fPdbPrefetching`

[in] If set to `TRUE`, adjacent debug records are prefetched into memory, potentially replacing many smaller file I/O operations with fewer, larger operations, and thus improving overall throughput as those records are subsequently accessed, at the expense of potentially increased memory usage. If set to `FALSE`, this behaves identically to [`IDiaDataSource::loadDataFromIStream`](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md). If set to some other value, behavior is unspecified.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|`E_PDB_FORMAT`|Attempted to access a file with an obsolete format.|
|`E_INVALIDARG`|Invalid parameter.|
|`E_UNEXPECTED`|Data source has already been prepared.|

## Remarks

This method allows the debug data for an executable to be obtained from memory through an <xref:IStream> object.

To load a .pdb file without validation, use the [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md) method.

To validate the .pdb file against specific criteria, use the [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md) method.

To gain access to the data load process (through a callback mechanism), use the [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md) method.

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md)
- [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md)
- [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)
