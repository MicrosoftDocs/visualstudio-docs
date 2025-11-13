---
description: "Specifies how much of a program's state (such as running threads, stack frames, and current instruction address) to dump."
title: DUMPTYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DUMPTYPE
helpviewer_keywords:
- DUMPTYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DUMPTYPE

Specifies how much of a program's state (such as running threads, stack frames, and current instruction address) to dump.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DUMPTYPE {
    DUMP_MINIDUMP = 0,
    DUMP_FULLDUMP = 1
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DUMPTYPE {
    DUMP_MINIDUMP = 0,
    DUMP_FULLDUMP = 1
};
typedef DWORD DUMPTYPE;
```
---

## Fields
`DUMP_MINIDUMP`\
Specifies a small, compact dump.

`DUMP_FULLDUMP`\
Specifies a large, complete dump.

## Remarks
Passed as an argument to the [WriteDump](../../../extensibility/debugger/reference/idebugprogram2-writedump.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [WriteDump](../../../extensibility/debugger/reference/idebugprogram2-writedump.md)
