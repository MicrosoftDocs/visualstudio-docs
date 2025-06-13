---
description: "Used to determine if a program can stop execution after reaching a particular point in the execution."
title: CANSTOP_REASON
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CANSTOP_REASON
helpviewer_keywords:
- CANSTOP_REASON enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# CANSTOP_REASON

Used to determine if a program can stop execution after reaching a particular point in the execution.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_CANSTOP_REASON {
    CANSTOP_ENTRYPOINT = 0x0000,
    CANSTOP_STEPIN     = 0x0001
};
```
### [C++](#tab/cpp)
```cpp
enum enum_CANSTOP_REASON {
    CANSTOP_ENTRYPOINT = 0x0000,
    CANSTOP_STEPIN     = 0x0001
};
typedef DWORD CANSTOP_REASON;
```
---

## Fields
`CANSTOP_ENTRYPOINT`\
Specifies the entry point of the given program.

`CANSTOP_STEPIN`\
Specifies stepping into a function.

## Remarks
Passed as an argument to the [GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md) method to confirm with the Session Debug Manager (SDM) if it is okay to stop after reaching the entry point of the program or after stepping into a function or method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md)
