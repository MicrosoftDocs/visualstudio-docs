---
description: "Used for setting data breakpoints that are based on a string that the user can enter from the integrated development environment (IDE)."
title: BP_LOCATION_DATA_STRING
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_LOCATION_DATA_STRING
helpviewer_keywords:
- BP_LOCATION_DATA_STRING structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
---
# BP_LOCATION_DATA_STRING

Used for setting data breakpoints that are based on a string that the user can enter from the integrated development environment (IDE).

## Syntax

```cpp
typedef struct _BP_LOCATION_DATA_STRING {
    IDebugThread2* pThread;
    BSTR           bstrContext;
    BSTR           bstrDataExpr;
    DWORD          dwNumElements;
} BP_LOCATION_DATA_STRING;
```

## Members
`pThread`\
The [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread on which the breakpoint occurs.

`bstrContext`\
The context of the breakpoint within the code, typically a method or function name as seen on a call stack.

`bstrDataExpr`\
The data string the user enters to set the breakpoint.

`dwNumElements`\
The number of elements in the data string in which the breakpoint occurs.

## Remarks
This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
