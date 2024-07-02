---
description: Opens and verifies that the program database (.pdb) file matches the signature information provided, and prepares the .pdb file as a debug data source, with optional record prefetching.
title: "IDiaDataSourceEx::loadAndValidateDataFromPdbEx"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::loadAndValidateDataFromPdbEx method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::loadAndValidateDataFromPdbEx

Opens and verifies that the program database (.pdb) file matches the signature information provided, and prepares the .pdb file as a debug data source, with optional record prefetching.

## Syntax

```c++
HRESULT loadAndValidateDataFromPdbEx ( 
   LPCOLESTR pdbPath,
   GUID*     pcsig70,
   DWORD     sig,
   DWORD     age,
   BOOL      fPdbPrefetching
);
```

#### Parameters

`pdbPath`

[in] The path to the .pdb file.

`pcsig70`

[in] The globally unique identifier (GUID) signature to verify against the .pdb file signature. Only .pdb files in Visual C++ and later have GUID signatures.

`sig`

[in] The 32-bit signature to verify against the .pdb file signature.

`age`

[in] Age value to verify. The age does not necessarily correspond to any known time value, it is used to determine whether a .pdb file is out of sync with a corresponding .exe file.

fPdbPrefetching

[in] If set to `TRUE`, adjacent debug records are prefetched into memory, potentially replacing many smaller file I/O operations with fewer, larger operations, and thus improving overall throughput as those records are subsequently accessed, at the expense of potentially increased memory usage. If set to `FALSE`, this behaves identically to [`IDiaDataSource::loadAndValidateDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md). If set to some other value, behavior is unspecified.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|`E_PDB_NOT_FOUND`|Failed to open the file, or the file has an invalid format.|
|`E_PDB_FORMAT`|Attempted to access a file with an obsolete format.|
|`E_PDB_INVALID_SIG`|Signature does not match.|
|`E_PDB_INVALID_AGE`|Age does not match.|
|`E_INVALIDARG`|Invalid parameter.|
|`E_UNEXPECTED`|The data source has already been prepared.|

## Remarks

A .pdb file contains both signature and age values. These values are replicated in the .exe or .dll file that matches the .pdb file. Before preparing the data source, this method verifies that the named .pdb file's signature and age match the values provided.

To load a .pdb file without validation, use the [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md) method.

To gain access to the data load process (through a callback mechanism), use the [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md) method.

To load a .pdb file directly from memory, use the [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md) method.

To validate a .pdb file without loading it, use the [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md) method.

## Example

```c++
IDiaDataSource* pSource;  // Previously created data source.
DEFINE_GUID(expectedGUIDSignature,0x1234,0x5678,0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08);
DWORD expectedFileSignature = 0x12345678;
DWORD expectedAge           = 128;

HRESULT hr;
hr = pSource->loadAndValidateDataFromPdbEx( L"yprog.pdb",
                                            &expectedGUIDSignature,
                                            expectedFileSignature,
                                            expectedAge,
                                            TRUE);
if (FAILED(hr))
{
    // Report an error
}

```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::loadDataForExeEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddataforexeex.md)
- [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md)
- [`IDiaDataSourceEx::loadDataFromIStreamEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafromistreamex.md)
- [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md)
