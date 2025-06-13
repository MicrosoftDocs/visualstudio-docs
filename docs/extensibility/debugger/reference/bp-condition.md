---
description: "Describes the conditions under which a breakpoint fires."
title: BP_CONDITION
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_CONDITION
helpviewer_keywords:
- BP_CONDITION structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_CONDITION

Describes the conditions under which a breakpoint fires.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct BP_CONDITION {
    public IDebugThread2 pThread;
    public uint          styleCondition;
    public string        bstrContext;
    public string        bstrCondition;
    public uint          nRadix;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _BP_CONDITION {
    IDebugThread2* pThread;
    BP_COND_STYLE  styleCondition;
    BSTR           bstrContext;
    BSTR           bstrCondition;
    UINT           nRadix;
} BP_CONDITION;
```
---

## Members
`pThread`\
The [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the active thread for the application that contains the breakpoint.

`styleCondition`\
A value from the [BP_COND_STYLE](../../../extensibility/debugger/reference/bp-cond-style.md) enumeration describing the style of this breakpoint condition.

`bstrContext`\
The location of the breakpoint.

`bstrCondition`\
The firing condition of the breakpoint.

`nRadix`\
Radix to be used in evaluating any numerical information.

## Remarks
This structure is a member of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) and [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) structures.

This structure is also passed as a parameter to the [SetCondition](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setcondition.md) and [SetCondition](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setcondition.md) methods.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)
- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)
- [SetCondition](../../../extensibility/debugger/reference/idebugboundbreakpoint2-setcondition.md)
- [SetCondition](../../../extensibility/debugger/reference/idebugpendingbreakpoint2-setcondition.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [BP_COND_STYLE](../../../extensibility/debugger/reference/bp-cond-style.md)
