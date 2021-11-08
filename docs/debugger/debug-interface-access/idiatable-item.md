---
description: "Retrieves a reference to the specified entry in the table."
title: "IDiaTable::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaTable::Item method"
ms.assetid: eae11b26-4807-400c-be25-e85bbc0c6b20
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaTable::Item
Retrieves a reference to the specified entry in the table.

## Syntax

```C++
HRESULT Item ( 
   DWORD      index,
   IUnknown** element
);
```

#### Parameters
 `index`

[in] The index of the table entry in the range 0 to `count`-1, where `count` is returned by the [IDiaTable::get_Count](../../debugger/debug-interface-access/idiatable-get-count.md)method.

 `element`

[out] Returns an `IUnknown` object that represents the specified table entry.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A table represents a collection of objects. Depending on those objects, the element parameter can be cast to the appropriate interface. For example, if a table contains [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md) objects, then the element parameter can be cast to the `IDiaSegment` interface.

 It is a more common approach to call the `QueryInterface` method in the [IDiaTable](../../debugger/debug-interface-access/idiatable.md) interface for the appropriate enumerator interface and use the enumerator's specific methods to access the table contents. See the [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md) interface for an example.

## See also
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
- [IDiaTable::get_Count](../../debugger/debug-interface-access/idiatable-get-count.md)
- [IDiaSegment](../../debugger/debug-interface-access/idiasegment.md)
- [IDiaEnumInjectedSources](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
