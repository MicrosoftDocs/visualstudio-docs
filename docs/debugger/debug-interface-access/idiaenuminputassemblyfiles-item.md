---
description: Retrieves an input assembly file by means of an index.
title: "IDiaEnumInputAssemblyFiles::Item"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumInputAssemblyFiles::Item method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumInputAssemblyFiles::Item

Retrieves an input assembly file by means of an index.

## Syntax

```c++
HRESULT Item ( 
   DWORD                   index,
   IDiaInputAssemblyFile** file
);
```

#### Parameters

index

[in] Index of the [IDiaInputAssemblyFile](../../debugger/debug-interface-access/idiainputassemblyfile.md) object to be retrieved. The index is the range 0 to `count`-1, where `count` is returned by the [IDiaEnumInputAssemblyFiles::get_Count](../../debugger/debug-interface-access/idiaenuminputassemblyfiles-get-count.md) method.

file

[out] Returns an [IDiaInputAssemblyFile](../../debugger/debug-interface-access/idiainputassemblyfile.md) object representing the input assembly file.

## Return Value

If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [IDiaEnumInputAssemblyFiles](../../debugger/debug-interface-access/idiaenumininputassemblyfiles.md)
- [IDiaInputAssemblyFile](../../debugger/debug-interface-access/idiainputassemblyfile.md)
