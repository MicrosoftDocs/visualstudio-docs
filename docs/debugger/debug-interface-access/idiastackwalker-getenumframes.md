---
description: Retrieves a stack frame enumerator for x86 platforms.
title: "IDiaStackWalker::getEnumFrames"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalker2::getEnumFrames method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalker::getEnumFrames

Retrieves a stack frame enumerator for x86 platforms.

## Syntax

```C++
HRESULT getEnumFrames( 
   IDiaStackWalkHelper*   pHelper,
   IDiaEnumStackFrames**  ppEnum
);
```

#### Parameters
 `pHelper`

[in] The helper [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md) object.

 `ppEnum`

[out] Returns an [IDiaEnumStackFrames](../../debugger/debug-interface-access/idiaenumstackframes.md) object that contains a list of [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) objects.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 To get a stack frame list on any other platform, call the [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) method.

## See also
- [IDiaStackWalker](../../debugger/debug-interface-access/idiastackwalker.md)
- [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)
- [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)
