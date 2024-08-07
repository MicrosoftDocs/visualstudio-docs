---
description: Opens and verifies that the program database (.pdb) file matches the signature information provided, and prepares the .pdb file as a debug data source.
title: "IDiaDataSource::loadAndValidateDataFromPdb"
ms.date: "07/22/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::loadAndValidateDataFromPdb method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSource::loadAndValidateDataFromPdb

Opens and verifies that the program database (.pdb) file matches the signature information provided, and prepares the .pdb file as a debug data source.

## Syntax

```c++
HRESULT loadAndValidateDataFromPdb ( 
   LPCOLESTR pdbPath,
   GUID*     pcsig70,
   DWORD     sig,
   DWORD     age
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

To load a .pdb file and validate with prefetching, use the [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md) method.

To load a .pdb file without validation, use the [`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md) method.

To gain access to the data load process (through a callback mechanism), use the [`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

To load a .pdb file directly from memory, use the [`IDiaDataSource::loadDataFromIStream`](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md) method.

To validate a .pdb file without loading it, use the [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md) method.

## Example

```c++
IDiaDataSource* pSource;  // Previously created data source.
DEFINE_GUID(expectedGUIDSignature,0x1234,0x5678,0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08);
DWORD expectedFileSignature = 0x12345678;
DWORD expectedAge           = 128;

HRESULT hr;
hr = pSource->loadAndValidateDataFromPdb( L"yprog.pdb",
                                          &expectedGUIDSignature,
                                          expectedFileSignature,
                                          expectedAge);
if (FAILED(hr))
{
    // Report an error
}

```

## See also

- [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)
- [`IDiaDataSource::loadDataForExe`](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [`IDiaDataSource::loadDataFromPdb`](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md)
- [`IDiaDataSource::loadDataFromIStream`](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md)
- [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)
- [`IDiaDataSourceEx::ValidatePdb`](../../debugger/debug-interface-access/idiadatasourceex-validatepdb.md)
