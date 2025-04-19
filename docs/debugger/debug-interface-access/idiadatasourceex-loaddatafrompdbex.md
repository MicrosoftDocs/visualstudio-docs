---
description: Opens and prepares a program database (.pdb) file as a debug data source, with optional record prefetching.
title: "IDiaDataSourceEx::loadDataFromPdbEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::loadDataFromPdbEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::loadDataFromPdbEx

Opens and prepares a program database (.pdb) file as a debug data source with optional record prefetching.

## Syntax

```c++
HRESULT loadDataFromPdbEx (
   LPCOLESTR pdbPath,
   BOOL      fPdbPrefetching
);
```

#### Parameters

`pdbPath`

[in] The path to the .pdb file.

`fPdbPrefetching`

[in] If set to `TRUE`, adjacent debug records are prefetched into memory, potentially replacing many smaller file I/O operations with fewer, larger operations, and thus improving overall throughput as those records are subsequently accessed, at the expense of potentially increased memory usage. If set to `FALSE`, this behaves identically to [`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md). If set to some other value, behavior is unspecified.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|`E_PDB_NOT_FOUND`|Failed to open the file, or determined that the file has an invalid format.|
|`E_PDB_FORMAT`|Attempted to access a file with an incompatible or unsupported format.|
|`E_INVALIDARG`|Invalid parameter.|
|`E_UNEXPECTED`|Data source has already been prepared.|

## Remarks

This method loads the debug data directly from a .pdb file.

To validate the .pdb file against specific criteria, use the [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md) method.

To gain access to the data load process (through a callback mechanism), use the [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md) method.

To load a .pdb file directly from memory, use the [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md) method.

To validate a .pdb file without loading it, use the [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md) method.

## Example

```c++
HRESULT hr = pSource->loadDataFromPdbEx( L"myprog.pdb", TRUE );
if (FAILED(hr))
{
    // report error
}
```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md)
- [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)
- [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md)
- [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md)
