---
description: "Gives the reason a breakpoint was unbound."
title: BP_UNBOUND_REASON
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_UNBOUND_REASON
helpviewer_keywords:
- BP_UNBOUND_REASON enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_UNBOUND_REASON

Gives the reason a breakpoint was unbound.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_UNBOUND_REASON {
    BPUR_UNKNOWN           = 0x0000,
    BPUR_CODE_UNLOADED     = 0x0002,
    BPUR_BREAKPOINT_REBIND = 0x0003,
    BPUR_BREAKPOINT_ERROR  = 0x0004
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_UNBOUND_REASON {
    BPUR_UNKNOWN           = 0x0000,
    BPUR_CODE_UNLOADED     = 0x0002,
    BPUR_BREAKPOINT_REBIND = 0x0003,
    BPUR_BREAKPOINT_ERROR  = 0x0004
};
typedef DWORD BP_UNBOUND_REASON;
```
---

## Fields
`BPUR_UNKNOWN`\
The reason is unknown.

`BPUR_CODE_UNLOADED`\
The code that contains the breakpoint has been unloaded.

`BPUR_BREAKPOINT_REBIND`\
The breakpoint has been rebound to a different location. This can happen after Edit and Continue operations when the breakpoint moves, or when the breakpoint is bound to a file with a path that is no longer valid.

`BPUR_ BREAKPOINT_ERROR`\
The breakpoint is determined to be in error after it is bound. This happens to managed breakpoints whose conditions are no longer valid.

## Remarks
Returned by the [GetReason](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2-getreason.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetReason](../../../extensibility/debugger/reference/idebugbreakpointunboundevent2-getreason.md)
