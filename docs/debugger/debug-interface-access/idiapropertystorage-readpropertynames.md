---
description: "Retrieves corresponding string names for given property identifiers."
title: "IDiaPropertyStorage::ReadPropertyNames | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaPropertyStorage::ReadPropertyNames"
ms.assetid: f8bcab77-afca-4a8f-8710-697842f8a518
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaPropertyStorage::ReadPropertyNames
Retrieves corresponding string names for given property identifiers.

## Syntax

```C++
HRESULT ReadPropertyNames (
   ULONG         cpropid,
   PROPID const* rgpropid,
   BSTR*         rglpwstrName
);
```

#### Parameters
 `cpropid`

[in] Number of property ids in `rgpropid`.

 `rgpropid`

[in] Array of property ids for which to get the names (`PROPID` is defined in WTypes.h as a `ULONG`).

 `rglpwstrName`

[in, out] Array of property names for the specified property ids. The array must be pre-allocated to hold the requested number of property names and must be able to hold at least `cpropid``BSTR` strings.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code.

## Remarks
 The returned property names must be freed (by calling the `SysFreeString` function) when they are no longer needed.

## See also
- [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
