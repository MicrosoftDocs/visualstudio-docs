---
description: Enumerate the input assembly files listed in the data source.
title: IDiaEnumInputAssemblyFiles
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles

Enumerate the input assembly files listed in the data source.

## Syntax

`IDiaEnumInputAssemblyFiles : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumInputAssemblyFiles`.

|Method|Description|
|------------|-----------------|
|[IDiaEnumInputAssemblyFiles::get__NewEnum](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-get-newenum.md)|Retrieves the [IEnumVARIANT Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-ienumvariant) version of this enumerator.|
|[IDiaEnumInputAssemblyFiles::get_Count](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-get-count.md)|Retrieves the number of input assembly files.|
|[IDiaEnumInputAssemblyFiles::Item](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-item.md)|Retrieves an input assembly file by means of an index.|
|[IDiaEnumInputAssemblyFiles::Next](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-next.md)|Retrieves a specified number of input assembly files in the enumeration sequence.|
|[IDiaEnumInputAssemblyFiles::Skip](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-skip.md)|Skips a specified number of input assembly files in an enumeration sequence.|
|[IDiaEnumInputAssemblyFiles::Reset](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-reset.md)|Resets an enumeration sequence to the beginning.|
|[IDiaEnumInputAssemblyFiles::Clone](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

## Notes for Callers

This interface is obtained by calling the [IDiaSession::findInputAssemblyFiles](../../debugger/debug-interface-access/idiasession-findinputassemblyfiles.md) method with the name of a specific source file or by calling the [IDiaSession::getEnumTables](../../debugger/debug-interface-access/idiasession-getenumtables.md) method with the globally unique identifier (GUID) of the `IDiaEnumInputAssemblyFiles` interface.

## Example

This example shows how to obtain (the `GetEnumInputAssemblyFiles` function) and use (the `DumpAllInputAssemblyFiles` function) the `IDiaEnumInputAssemblyFiles` interface. See the [`IDiaPropertyStorage`](../../debugger/debug-interface-access/idiapropertystorage.md) interface for an implementation of the `PrintPropertyStorage` function. For an alternative output, see the [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md) interface.

```c++

IDiaEnumInputAssemblyFiles* GetEnumInputAssemblyInputFiles(IDiaSession *pSession)
{
    IDiaEnumInputAssemblyFiles* pUnknown    = NULL;
    REFIID                   iid         = __uuidof(IDiaEnumInputAssemblyFiles);
    IDiaEnumTables*          pEnumTables = NULL;
    IDiaTable*               pTable      = NULL;
    ULONG                    celt        = 0;

    if (pSession->getEnumTables(&pEnumTables) != S_OK)
    {
        wprintf(L"ERROR - GetTable() getEnumTables\n");
        return NULL;
    }
    while (pEnumTables->Next(1, &pTable, &celt) == S_OK && celt == 1)
    {
        // There is only one table that matches the given iid
        HRESULT hr = pTable->QueryInterface(iid, (void**)&pUnknown);
        pTable->Release();
        if (hr == S_OK)
        {
            break;
        }
    }
    pEnumTables->Release();
    return pUnknown;
}

void DumpAllInputAssemblyFiles( IDiaSession* pSession)
{
    IDiaEnumInputAssemblyFiles* pEnumInpAsmFiles;

    pEnumInpAsmFiles = GetEnumInputAssemblyInputFiles(pSession);
    if (pEnumInpAsmFiles != NULL)
    {
        IDiaInputAssemblyFile* pInpAsmFile;
        ULONG celt = 0;

        while(pEnumInpAsmFiles->Next(1, &pInpAsmFile, &celt) == S_OK &&
              celt == 1)
        {
            IDiaPropertyStorage *pPropertyStorage;
            if (pInpAsmFile->QueryInterface(__uuidof(IDiaPropertyStorage),
                                          (void **)&pPropertyStorage) == S_OK)
            {
                PrintPropertyStorage(pPropertyStorage);
                pPropertyStorage->Release();
            }
            pInpAsmFile->Release();
        }
        pEnumInpAsmFiles->Release();
    }
}
```

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
- [`IDiaSession::findInputAssemblyFiles`](../../debugger/debug-interface-access/idiasession-findinputassemblyfiles.md)
- [`IDiaSession::getEnumTables`](../../debugger/debug-interface-access/idiasession-getenumtables.md)
- [`IDiaPropertyStorage`](../../debugger/debug-interface-access/idiapropertystorage.md)
- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
