---
description: "Enumerates the various tables contained in the data source."
title: "IDiaEnumTables | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables interface"
ms.assetid: 016190c5-09e4-48f2-bf60-9b02603a03e0
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumTables
Enumerates the various tables contained in the data source.

## Syntax

```
IDiaEnumTables : IUnknown
```

## Methods in Vtable Order
 The following table shows the methods of `IDiaEnumTables`.

|Method|Description|
|------------|-----------------|
|[IDiaEnumTables::get__NewEnum](../../debugger/debug-interface-access/idiaenumtables-get-newenum.md)|Retrieves the [IEnumVARIANT Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-ienumvariant) version of this enumerator.|
|[IDiaEnumTables::get_Count](../../debugger/debug-interface-access/idiaenumtables-get-count.md)|Retrieves the number of tables.|
|[IDiaEnumTables::Item](../../debugger/debug-interface-access/idiaenumtables-item.md)|Retrieves a table by means of an index or a name.|
|[IDiaEnumTables::Next](../../debugger/debug-interface-access/idiaenumtables-next.md)|Retrieves a specified number of tables in the enumeration sequence.|
|[IDiaEnumTables::Skip](../../debugger/debug-interface-access/idiaenumtables-skip.md)|Skips a specified number of tables in an enumeration sequence.|
|[IDiaEnumTables::Reset](../../debugger/debug-interface-access/idiaenumtables-reset.md)|Resets an enumeration sequence to the beginning.|
|[IDiaEnumTables::Clone](../../debugger/debug-interface-access/idiaenumtables-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

## Notes for Callers
Obtain this interface by calling the [IDiaSession::getEnumTables](../../debugger/debug-interface-access/idiasession-getenumtables.md) method.

## Example
This example shows how to obtain the `IDiaEnumTables` interface from a session. For a more complete example of using tables, see the [IDiaTable](../../debugger/debug-interface-access/idiatable.md) interface.

```C++
void ShowTableNames(IDiaSession *pSession)
{
    CComPtr<IDiaEnumTables> pTables;
    if ( FAILED( psession->getEnumTables( &pTables ) ) )
    {
        Fatal( "getEnumTables" );
    }
    // Do something with table
}
```

## Requirements
Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaSession::getEnumTables](../../debugger/debug-interface-access/idiasession-getenumtables.md)
