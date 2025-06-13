---
title: BP_PASSCOUNT
description: "Describes the count and conditions upon which a conditional breakpoint is fired."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_PASSCOUNT
helpviewer_keywords:
- BP_PASSCOUNT structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_PASSCOUNT

Describes the count and conditions upon which a conditional breakpoint is fired.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct BP_PASSCOUNT {
    public uint dwPassCount;
    public uint stylePassCount;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _BP_PASSCOUNT {
    DWORD              dwPassCount;
    BP_PASSCOUNT_STYLE stylePassCount;
} BP_PASSCOUNT;
```
---

## Members
`dwPassCount`\
The number of times to pass over the breakpoint before firing it.

`stylePassCount`\
A value from the [BP_PASSCOUNT_STYLE](../../../extensibility/debugger/reference/bp-passcount-style.md) enumeration that specifies the style of the breakpoint pass count.

## Remarks
This structure is a member of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure.

This structure is also passed as a parameter to the [SetPassCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setpasscount.md) and [SetPassCount](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setpasscount.md) methods.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)
- [SetPassCount](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setpasscount.md)
- [SetPassCount](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setpasscount.md)
- [BP_PASSCOUNT_STYLE](../../../extensibility/debugger/reference/bp-passcount-style.md)
