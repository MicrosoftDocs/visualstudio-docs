---
description: "Describes the bound breakpoint information for either a code breakpoint or a data breakpoint."
title: BP_RESOLUTION_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_RESOLUTION_INFO
helpviewer_keywords:
- BP_RESOLUTION_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_RESOLUTION_INFO

Describes the bound breakpoint information for either a code breakpoint or a data breakpoint.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct BP_RESOLUTION_INFO {
    public uint                   dwFields;
    public BP_RESOLUTION_LOCATION bpResLocation;
    public IDebugProgram2         pProgram;
    public IDebugThread2          pThread;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _BP_RESOLUTION_INFO {
    BPRESI_FIELDS          dwFields;
    BP_RESOLUTION_LOCATION bpResLocation;
    IDebugProgram2*        pProgram;
    IDebugThread2*         pThread;
} BP_RESOLUTION_INFO;
```
---

## Members
`dwFields`\
A collection of flags from the [BPRESI_FIELDS](../../../extensibility/debugger/reference/bpresi-fields.md) enumerations that specifies which fields are filled out.

`bpResLocation`\
The [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md) structure that specifies the location of the breakpoint in code or data.

`pProgram`\
The [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the application in which the breakpoint error occurred.

`pThread`\
The [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread in which the application that contains the breakpoint error is running.

## Remarks
This structure is returned by [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md).

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)
- [BPRESI_FIELDS](../../../extensibility/debugger/reference/bpresi-fields.md)
- [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
