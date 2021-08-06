---
description: "Gets an enumerator for properties within this set."
title: "IDiaPropertyStorage::Enum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaPropertyStorage::Enum"
ms.assetid: 00e462da-980a-40b3-a2d6-75a25ee809e5
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
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
