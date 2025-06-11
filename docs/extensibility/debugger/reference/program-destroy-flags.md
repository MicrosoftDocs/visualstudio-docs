---
description: "Enumerates the valid values of the program destroy flags."
title: PROGRAM_DESTROY_FLAGS
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- PROGRAM_DESTROY_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PROGRAM_DESTROY_FLAGS

Enumerates the valid values of the program destroy flags.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_PPROGRAM_DESTROY_FLAGS
{
   PROGRAM_DESTROY_CONTINUE_DEBUGGING = 0x1
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PPROGRAM_DESTROY_FLAGS
{
   PROGRAM_DESTROY_CONTINUE_DEBUGGING = 0x1
};
typedef DWORD PROGRAM_DESTROY_FLAGS;
```
---

## Fields
 `PROGRAM_DESTROY_CONTINUE_DEBUGGING`\
 Destroy program, but continue to debug.

## Remarks
 The enumeration is returned by the [GetFlags](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2-getflags.md) method.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetFlags](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2-getflags.md)
