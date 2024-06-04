---
description: Retrieves a specified number of stack frame elements from the enumeration sequence.
title: "IDiaEnumStackFrames::Next"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumStackFrames::Next method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumStackFrames::Next

Retrieves a specified number of stack frame elements from the enumeration sequence.

## Syntax

```c++
HRESULT Next( 
   ULONG             celt,
   IDiaStackFrame**  rgelt,
   ULONG*            pceltFetched
);
```

#### Parameters

celt

[in] The number of stackframe elements in the enumerator to be retrieved.

rgelt

[out] An array that is to be filled in with the requested [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) objects.

pceltFetched

[out] Returns the number of stack frame elements in the fetched enumerator.

## Return Value

If successful, returns `S_OK`. Returns `S_FALSE` if there are no more stack frames. Otherwise, returns an error code.

## See also

- [IDiaEnumStackFrames](../../debugger/debug-interface-access/idiaenumstackframes.md)
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
