---
description: "Describes the offset location of a breakpoint in a function in code."
title: BP_LOCATION_CODE_FUNC_OFFSET
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_LOCATION_CODE_FUNC_OFFSET
helpviewer_keywords:
- BP_LOCATION_CODE_FUNC_OFFSET structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
---
# BP_LOCATION_CODE_FUNC_OFFSET

Describes the offset location of a breakpoint in a function in code.

## Syntax

```cpp
typedef struct _BP_LOCATION_CODE_FUNC_OFFSET {
    BSTR                     bstrContext;
    IDebugFunctionPosition2* pFuncPos;
} BP_LOCATION_CODE_FUNC_OFFSET;
```

## Members
`bstrContext`\
The context of the breakpoint, typically a method or function name as seen on a call stack.

`pFuncPos`\
The [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md) object that describes the name of the function and the relative position from the beginning of the function.

## Remarks
This structure is a member of the [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) structure as part of a union.

The `pFuncPos` member indicates where to set the function breakpoint.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)
- [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)
