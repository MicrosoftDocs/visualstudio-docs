---
description: "Enumerates the various segments contained in the data source."
title: "IDiaEnumSegments | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumSegments interface"
ms.assetid: 0c9edd5e-b9ce-43e1-a791-cd4c5d16d923
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumSegments
Enumerates the various segments contained in the data source.

## Syntax

```
IDiaEnumSegments : IUnknown
```

## Methods in Vtable Order
The following table shows the methods of `IDiaEnumSegments`.

|Method|Description|
|------------|-----------------|
|[IDiaEnumSegments::get__NewEnum](../../debugger/debug-interface-access/idiaenumsegments-get-newenum.md)|Retrieves the [IEnumVARIANT Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-ienumvariant) version of this enumerator.|
|[IDiaEnumSegments::get_Count](../../debugger/debug-interface-access/idiaenumsegments-get-count.md)|Retrieves the number of segments.|
|[IDiaEnumSegments::Item](../../debugger/debug-interface-access/idiaenumsegments-item.md)|Retrieves a segment by means of an index.|
|[IDiaEnumSegments::Next](../../debugger/debug-interface-access/idiaenumsegments-next.md)|Retrieves a specified number of segments in the enumeration sequence.|
|[IDiaEnumSegments::Skip](../../debugger/debug-interface-access/idiaenumsegments-skip.md)|Skips a specified number of segments in an enumeration sequence.|
|[IDiaEnumSegments::Reset](../../debugger/debug-interface-access/idiaenumsegments-reset.md)|Resets an enumeration sequence to the beginning.|
|[IDiaEnumSegments::Clone](../../debugger/debug-interface-access/idiaenumsegments-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

## Notes for Callers
Obtain this interface by calling the `QueryInterface` method on an [IDiaTable](../../debugger/debug-interface-access/idiatable.md) object. See the example for details.

## Example
This example shows how to obtain the `IDiaEnumSections` interface from a table. For a more complete example of using segments, see the [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) interface.

```C++
void ShowSegments(IDiaTable *pTable, IDiaSession *pSession)
{
    CComPtr<IDiaEnumSegments> pSegments;
    if ( SUCCEEDED( pTable->QueryInterface(
                                __uuidof( IDiaEnumSegments ),
                                (void**)&pSegments )
                  )
       )
    {
        // Do something with this enumeration
    }
}
```

## Requirements
Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
