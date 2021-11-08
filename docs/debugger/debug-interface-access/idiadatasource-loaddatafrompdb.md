---
description: "Opens and prepares a program database (.pdb) file as a debug data source."
title: "IDiaDataSource::loadDataFromPdb | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaDataSource::loadDataFromPdb method"
ms.assetid: 02159073-8144-47f8-a0b0-aa0edcb92b5b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaDataSource::loadDataFromPdb
Opens and prepares a program database (.pdb) file as a debug data source.

## Syntax

```C++
HRESULT loadDataFromPdb (
   LPCOLESTR pdbPath
);
```

#### Parameters
pdbPath

[in] The path to the .pdb file.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.

|Value|Description|
|-----------|-----------------|
|E_PDB_NOT_FOUND|Failed to open the file, or determined that the file has an invalid format.|
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|
|E_INVALIDARG|Invalid parameter.|
|E_UNEXPECTED|Data source has already been prepared.|

## Remarks
This method loads the debug data directly from a .pdb file.

To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md) method.

To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.

To load a .pdb file directly from memory, use the [IDiaDataSource::loadDataFromIStream](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md) method.

## Example

```C++
HRESULT hr = pSource->loadDataFromPdb( L"myprog.pdb" );
if (FAILED(hr))
{
    // report error
}
```

## See also
- [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md)
- [IDiaDataSource::loadDataFromIStream](../../debugger/debug-interface-access/idiadatasource-loaddatafromistream.md)
