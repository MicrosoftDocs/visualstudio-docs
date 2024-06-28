---
description: Creates an enumerator that contains the same enumeration state as the current input assembly files enumerator.
title: "IDiaEnumInputAssemblyFiles::Clone"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::Clone method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::Clone

Creates an enumerator that contains the same enumeration state as the current enumerator.

## Syntax

```c++
HRESULT Clone ( 
   IDiaEnumInputAssemblyFiles** ppenum
);
```

#### Parameters

 `ppenum`

[out] Returns an [IDiaEnumInputAssemblyFiles](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md) object that contains a duplicate of the enumerator. The input assembly files are not duplicated, only the enumerator.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumInputAssemblyFiles](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
