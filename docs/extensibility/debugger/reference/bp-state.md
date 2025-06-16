---
description: "Specifies the existence of a bound breakpoint and also specifies if it is enabled."
title: BP_STATE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_STATE
helpviewer_keywords:
- BP_STATE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_STATE

Specifies the existence of a bound breakpoint and also specifies if it is enabled.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_BP_STATE {
    BPS_NONE     = 0x0000,
    BPS_DELETED  = 0x0001,
    BPS_DISABLED = 0x0002,
    BPS_ENABLED  = 0x0003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_BP_STATE {
    BPS_NONE     = 0x0000,
    BPS_DELETED  = 0x0001,
    BPS_DISABLED = 0x0002,
    BPS_ENABLED  = 0x0003
};
typedef DWORD BP_STATE;
```
---

## Fields
`BPS_NONE`\
Specifies that no breakpoint exists.

`BPS_DELETED`\
Specifies that the breakpoint has been deleted.

`BPS_DISABLED`\
Specifies that the breakpoint is disabled.

`BPS_ENABLED`\
Specifies that the breakpoint is enabled.

## Remarks
Returned from the [GetState](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetState](../../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md)
