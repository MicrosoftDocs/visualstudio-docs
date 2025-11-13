---
description: "Describes or specifies properties of a process."
title: PROCESS_INFO_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- PROCESS_INFO_FLAGS
helpviewer_keywords:
- PROCESS_INFO_FLAGS enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# PROCESS_INFO_FLAGS

Describes or specifies properties of a process.

## Syntax

### [C#](#tab/csharp)
```csharp
enum enum_PROCESS_INFO_FLAGS { 
   PIFLAG_SYSTEM_PROCESS    = 0x00000001,
   PIFLAG_DEBUGGER_ATTACHED = 0x00000002,
   PIFLAG_PROCESS_STOPPED   = 0x00000004,
   PIFLAG_PROCESS_RUNNING   = 0x00000008,
};
```
### [C++](#tab/cpp)
```cpp
enum enum_PROCESS_INFO_FLAGS { 
   PIFLAG_SYSTEM_PROCESS    = 0x00000001,
   PIFLAG_DEBUGGER_ATTACHED = 0x00000002,
   PIFLAG_PROCESS_STOPPED   = 0x00000004,
   PIFLAG_PROCESS_RUNNING   = 0x00000008,
};
typedef DWORD PROCESS_INFO_FLAGS;
```
---

## Fields

`PIFLAG_SYSTEM_PROCESS`\
Indicates that the process is a system process.

`PIFLAG_DEBUGGER_ATTACHED`\
Indicates that the process is being debugged by a debugger. It may be a Visual Studio debugger, or it may be some other debugger, for example, WinDbg.

`PIFLAG_PROCESS_STOPPED`\
Indicates the process is stopped. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in Visual Studio 2005 and later.

`PIFLAG_PROCESS_RUNNING`\
Indicates the process is running. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in Visual Studio 2005 and later.

## Remarks

Used for the `Flags` member of the [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md) structure.

These flags may be combined with a bitwise `OR`.

## Requirements

Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)
