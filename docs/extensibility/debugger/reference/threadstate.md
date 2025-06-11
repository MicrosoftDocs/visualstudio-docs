---
description: "Specifies the state of the thread."
title: THREADSTATE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- THREADSTATE
helpviewer_keywords:
- THREADSTATE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# THREADSTATE

Specifies the state of the thread.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_THREADSTATE { 
   THREADSTATE_RUNNING = 0x0001,
   THREADSTATE_STOPPED = 0x0002,
   THREADSTATE_FRESH   = 0x0003,
   THREADSTATE_DEAD    = 0x0004,
   THREADSTATE_FROZEN  = 0x0005
};
```
### [C++](#tab/cpp)
```cpp
enum enum_THREADSTATE { 
   THREADSTATE_RUNNING = 0x0001,
   THREADSTATE_STOPPED = 0x0002,
   THREADSTATE_FRESH   = 0x0003,
   THREADSTATE_DEAD    = 0x0004,
   THREADSTATE_FROZEN  = 0x0005
};
typedef DWORD THREADSTATE;
```
---

## Fields
 `THREADSTATE_RUNNING`\
 Indicates that the thread is running.

 `THREADSTATE_STOPPED`\
 Indicates that the thread is stopped because of a breakpoint.

 `THREADSTATE_FRESH`\
 Indicates that the thread has been created, but is not yet running code.

 `THREADSTATE_DEAD`\
 Indicates that the thread is dead.

 `THREADSTATE_FROZEN`\
 Indicates that the thread is frozen (no execution can be performed).

## Remarks
 Used for the `dwThreadState` field of the [THREADPROPERTIES](../../../extensibility/debugger/reference/threadproperties.md) structure.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [THREADPROPERTIES](../../../extensibility/debugger/reference/threadproperties.md)
