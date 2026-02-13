---
description: Facilitates walking the stack using the program debug database (.pdb) file. Extends IDiaStackWalkHelper2 with support for variable-size registers.
title: IDiaStackWalkHelper3
ms.date: "02/09/2026"
ms.topic: "reference"
ms.custom: awp-ai
ai-usage: ai-assisted
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaStackWalkHelper3 interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaStackWalkHelper3

Facilitates walking the stack using the program debug database (.pdb) file. Provides methods for reading and writing variable-size register values, including large vector registers such as ARM64 SVE.

## Syntax

`IDiaStackWalkHelper3: IDiaStackWalkHelper2`

## Methods in VTable Order

The table below shows the methods of `IDiaStackWalkHelper3`:

|Method|Description|
|------------|-----------------|
|[`IDiaStackWalkHelper3::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper3-get-registervalue.md)|Retrieves the value of the specified register.|
|[`IDiaStackWalkHelper3::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper3-put-registervalue.md)|Sets the value of the specified register.|

## Remarks

This interface extends [`IDiaStackWalkHelper2`](../../debugger/debug-interface-access/idiastackwalkhelper2.md) with methods that support variable-size registers. Unlike the original [`IDiaStackWalkHelper::get_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-get-registervalue.md) and [`IDiaStackWalkHelper::put_registerValue`](../../debugger/debug-interface-access/idiastackwalkhelper-put-registervalue.md) methods that use a fixed `ULONGLONG` for the register value, these methods use byte buffers that can accommodate registers of any size, including large vector registers used by ARM64 SVE.

## Notes for Callers

A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) or [`IDiaStackWalker::getEnumFrames2`](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) methods.

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaStackWalkHelper2`](../../debugger/debug-interface-access/idiastackwalkhelper2.md)
- [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)
- [`IDiaFrameData`](../../debugger/debug-interface-access/idiaframedata.md)
- [`SymTagEnum` Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [`IDiaStackWalker::getEnumFrames`](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
- [`IDiaStackWalker::getEnumFrames2`](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)
