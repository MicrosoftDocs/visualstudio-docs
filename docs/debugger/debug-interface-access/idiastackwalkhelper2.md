---
description: Facilitates walking the stack using the program debug database (.pdb) file. Extends IDiaStackWalkHelper.
title: IDiaStackWalkHelper2
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper2 interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper2

Facilitates walking the stack using the program debug database (.pdb) file.

## Syntax

`IDiaStackWalkHelper2: IDiaStackWalkHelper`

## Methods in VTable Order

 The table below shows the methods of `IDiaStackWalkHelper2`:

|Method|Description|
|------------|-----------------|
|[`IDiaStackWalkHelper2::GetPointerAuthenticationMask`](../../debugger/debug-interface-access/idiastackwalkhelper2-getpointerauthenticationmask.md)|Retrieves the value of the pointer authentication mask.|

## Remarks

 This interface is called by the Debug Interface Access (DIA) code to obtain information about the executable to construct a list of stack frames during program execution.

## Notes for Callers

 A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) or [`IDiaStackWalker::getEnumFrames2`](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) methods.

## Requirements

 Header: Dia2.h

 Library: diaguids.lib

 DLL: msdia140.dll

## See also
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaFrameData`](../../debugger/debug-interface-access/idiaframedata.md)
- [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
- [`IDiaStackWalker::getEnumFrames2`](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)
