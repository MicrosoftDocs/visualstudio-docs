---
description: "Specifies the reason for the debug engine (DE) to attach to a program node."
title: ATTACH_REASON
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- ATTACH_REASON
helpviewer_keywords:
- ATTACH_REASON enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# ATTACH_REASON

Specifies the reason for the debug engine (DE) to attach to a program node.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_ATTACH_REASON {
    ATTACH_REASON_LAUNCH = 0x0001,
    ATTACH_REASON_USER   = 0x0002,
    ATTACH_REASON_AUTO   = 0x0003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_ATTACH_REASON {
    ATTACH_REASON_LAUNCH = 0x0001,
    ATTACH_REASON_USER   = 0x0002,
    ATTACH_REASON_AUTO   = 0x0003
};
typedef DWORD ATTACH_REASON;
```
---

## Fields
`ATTACH_REASON_AUTO`\
Attach because the process is currently in debug mode.

`ATTACH_REASON_LAUNCH`\
Attach because the process has been launched.

`ATTACH_REASON_USER`\
Attach because of a user request.

## Remarks
These values are used as a parameter to the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) and [Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md) methods.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [Attach](../../../extensibility/debugger/reference/idebugprogramex2-attach.md)
