---
description: "Reads ULONGLONG values in a property set."
title: "IDiaPropertyStorage::ReadULONGLONG | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaPropertyStorage::ReadULONGLONG"
ms.assetid: f80a2e24-5744-4fec-bab0-3ed51aef6e58
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaPropertyStorage::ReadULONGLONG
Reads `ULONGLONG` values in a property set.

## Syntax

```C++
HRESULT ReadULONGLONG ( 
   PROPID     id,
   ULONGLONG* pValue
);
```

#### Parameters
 `id`

[in] Identifier of the property to be read (`PROPID` is defined in WTypes.h as a `ULONG`).

 `pValue`

[out] Returns the property value.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code. Returns `E_INVALIDARG` if the property is not of type `ULONGLONG`.

## Remarks
 A `ULONGLONG` is defined by Windows as a 64-bit unsigned integer.

## See also
- [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
