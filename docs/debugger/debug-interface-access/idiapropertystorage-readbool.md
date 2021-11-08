---
description: "Reads BOOL values in a property set."
title: "IDiaPropertyStorage::ReadBOOL | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaPropertyStorage::ReadBOOL"
ms.assetid: ad1822db-4572-48f7-9919-f8137f6701f2
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaPropertyStorage::ReadBOOL
Reads `BOOL` values in a property set.

## Syntax

```C++
HRESULT ReadBOOL ( 
   PROPID id,
   BOOL*  pValue
);
```

#### Parameters
 `id`

[in] Identifier of the property to be read (`PROPID` is defined in WTypes.h as a `ULONG`).

 `pValue`

[out] Returns the property value.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code. Returns `E_INVALIDARG` if the property is not of type `BOOL`.

## Remarks
 For consistent results, interpret the `BOOL` value so that nonzero values are `TRUE` and zero is `FALSE`.

## See also
- [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
