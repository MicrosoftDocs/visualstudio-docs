---
title: "IDiaStackWalker::getEnumFrames | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalker2::getEnumFrames method"
ms.assetid: f9f09729-4c34-441c-989c-e0b7339ee32c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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