---
description: Gets an enumerator for properties within this set.
title: "IDiaPropertyStorage::Enum"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaPropertyStorage::Enum"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaPropertyStorage::Enum

Gets an enumerator for properties within this set.

## Syntax

```C++
HRESULT Enum ( 
   IEnumSTATPROPSTG** ppenum
);
```

#### Parameters
 `ppenum`

[out] Returns an `IEnumSTATPROPSTG` object (in the Microsoft.VisualStudio.OLE.Interop namespace) representing an enumeration of properties.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code.

## See also
- [IDiaPropertyStorage](../../debugger/debug-interface-access/idiapropertystorage.md)
