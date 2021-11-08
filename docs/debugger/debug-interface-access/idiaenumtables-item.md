---
description: "Retrieves a table by means of an index or name."
title: "IDiaEnumTables::Item | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumTables::Item method"
ms.assetid: d65ab262-10c6-48ce-95a3-b5e4cb2c85af
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaEnumTables::Item
Retrieves a table by means of an index or name.

## Syntax

```C++
HRESULT Item ( 
   VARIANT     index,
   IDiaTable** table
);
```

#### Parameters
 `index`

[in] Index or name of the [IDiaTable](../../debugger/debug-interface-access/idiatable.md) to be retrieved. If an integer variant is used, it must be in the range 0 to `count`-1, where `count` is as returned by the [IDiaEnumTables::get_Count](../../debugger/debug-interface-access/idiaenumtables-get-count.md) method.

 `table`

[out] Returns an [IDiaTable](../../debugger/debug-interface-access/idiatable.md) object representing the desired table.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If a string variant is specified, then the string names a particular table. The name should be one of the table names as defined in [Constants (Debug Interface Access SDK)](../../debugger/debug-interface-access/constants-debug-interface-access-sdk.md).

## Example

```C++
VARIANT var;
var.vt = VT_BSTR;
var.bstrVal = SysAllocString(DiaTable_Symbols );
IDiaTable* pTable;
pEnumTables->Item( var, &pTable );
```

## See also
- [IDiaEnumTables](../../debugger/debug-interface-access/idiaenumtables.md)
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
- [IDiaEnumTables::get_Count](../../debugger/debug-interface-access/idiaenumtables-get-count.md)
- [Constants (Debug Interface Access SDK)](../../debugger/debug-interface-access/constants-debug-interface-access-sdk.md)
