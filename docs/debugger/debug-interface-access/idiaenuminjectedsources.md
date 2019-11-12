---
title: "IDiaEnumInjectedSources | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInjectedSources interface"
ms.assetid: f97e2392-22e1-48da-b7ce-ad94c8b684b0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaEnumInjectedSources
Enumerate the various injected sources contained in the data source.

## Syntax

```
IDiaEnumInjectedSources : IUnknown
```

## Methods in Vtable Order
The following table shows the methods of `IDiaEnumInjectedSources`.

|Method|Description|
|------------|-----------------|
|[IDiaEnumInjectedSources::get__NewEnum](../../debugger/debug-interface-access/idiaenuminjectedsources-get-newenum.md)|Retrieves the [IEnumVARIANT Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-ienumvariant) version of this enumerator.|
|[IDiaEnumInjectedSources::get_Count](../../debugger/debug-interface-access/idiaenuminjectedsources-get-count.md)|Retrieves the number of injected sources.|
|[IDiaEnumInjectedSources::Item](../../debugger/debug-interface-access/idiaenuminjectedsources-item.md)|Retrieves an injected source by means of an index.|
|[IDiaEnumInjectedSources::Next](../../debugger/debug-interface-access/idiaenuminjectedsources-next.md)|Retrieves a specified number of injected sources in the enumeration sequence.|
|[IDiaEnumInjectedSources::Skip](../../debugger/debug-interface-access/idiaenuminjectedsources-skip.md)|Skips a specified number of injected sources in an enumeration sequence.|
|[IDiaEnumInjectedSources::Reset](../../debugger/debug-interface-access/idiaenuminjectedsources-reset.md)|Resets an enumeration sequence to the beginning.|
|[IDiaEnumInjectedSources::Clone](../../debugger/debug-interface-access/idiaenuminjectedsources-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

## Notes for Callers
This interface is obtained by calling the [IDiaSession::findInjectedSource](../../debugger/debug-interface-access/idiasession-findinjectedsource.md) method with the name of a specific source file or by calling the [IDiaSession::getEnumTables](../../debugger/debug-interface-access/idiasession-getenumtables.md) method with the GUID of the `IDiaEnumInjectedSources` interface.

## Example
This example shows how to obtain (the `GetEnumInjectedSources` function) and use (the `DumpAllInjectedSources` function) the `IDiaEnumInjectedSources` interface. See the [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md) interface for an implementation of the `PrintPropertyStorage` function. For an alternative output, see the [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md) interface.

```C++

IDiaEnumInjectedSources* GetEnumInjectedSources(IDiaSession *pSession)
{
    IDiaEnumInjectedSources* pUnknown    = NULL;
    REFIID                   iid         = __uuidof(IDiaEnumInjectedSources);
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

void DumpAllInjectedSources( IDiaSession* pSession)
{
    IDiaEnumInjectedSources* pEnumInjSources;

    pEnumInjSources = GetEnumInjectedSources(pSession);
    if (pEnumInjSources != NULL)
    {
        IDiaInjectedSource* pInjSource;
        ULONG celt = 0;

        while(pEnumInjSources->Next(1, &pInjSource, &celt) == S_OK &&
              celt == 1)
        {
            IDiaPropertyStorage *pPropertyStorage;
            if (pInjSource->QueryInterface(__uuidof(IDiaPropertyStorage),
                                          (void **)&pPropertyStorage) == S_OK)
            {
                PrintPropertyStorage(pPropertyStorage);
                pPropertyStorage->Release();
            }
            pInjSource->Release();
        }
        pEnumInjSources->Release();
    }
}
```

## Requirements
Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaSession::findInjectedSource](../../debugger/debug-interface-access/idiasession-findinjectedsource.md)
- [IDiaSession::getEnumTables](../../debugger/debug-interface-access/idiasession-getenumtables.md)
- [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
