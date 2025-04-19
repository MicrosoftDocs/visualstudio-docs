---
description: Verifies that the program database (.pdb) file matches the signature information provided.
title: "IDiaDataSourceEx::ValidatePdb"
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSourceEx::ValidatePdb method"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaDataSourceEx::ValidatePdbEx

Verifies that the program database (.pdb) file matches the signature information provided.

## Syntax

```c++
HRESULT ValidatePdb ( 
   LPCOLESTR    pdbPath,
   const GUID*  pcsig70,
   DWORD        sig,
   DWORD        age,
   BOOL*        pfStripped
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

pfStripped

[out] If the PDB matches the other information, this parameter is set to indicate whether the PDB has been stripped of private symbols. This is the same value as would be returned by [IDiaSymbol::get_isStripped](../../debugger/debug-interface-access/idiasymbol-get-isstripped.md). If the PDB does not match the other values, or this method fails, this parameter is unspecified.

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

A .pdb file contains both signature and age values. These values are replicated in the .exe or .dll file that matches the .pdb file. This method verifies that the named .pdb file's signature and age match the values provided without otherwise loading the PDB or preparing it for use.

To load a .pdb file without validation, use the [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md) method.

To load and validate the .pdb file against specific criteria, use the [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md) method.

## Example

```c++
IDiaDataSource* pSource;  // Previously created data source.
DEFINE_GUID(expectedGUIDSignature,0x1234,0x5678,0x01,0x02,0x03,0x04,0x05,0x06,0x07,0x08);
DWORD expectedFileSignature = 0x12345678;
DWORD expectedAge           = 128;
BOOL fStripped              = FALSE;

HRESULT hr;
hr = pSource->lValidatePdb( L"myprog.pdb",
                            &expectedGUIDSignature,
                            expectedFileSignature,
                            expectedAge,
                            &fStripped);
if (FAILED(hr))
{
    // Report an error
}

```

## See also

- [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)
- [`IDiaDataSourceEx::loadDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loaddatafrompdbex.md)
- [`IDiaDataSourceEx::loadAndValidateDataFromPdbEx`](../../debugger/debug-interface-access/idiadatasourceex-loadandvalidatedatafrompdbex.md)
