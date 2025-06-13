---
description: "Describes the resolution of an error breakpoint, including location, program, and thread."
title: BP_ERROR_RESOLUTION_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- BP_ERROR_RESOLUTION_INFO
helpviewer_keywords:
- BP_ERROR_RESOLUTION_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# BP_ERROR_RESOLUTION_INFO

Describes the resolution of an error breakpoint, including location, program, and thread.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct BP_ERROR_RESOLUTION_INFO {
    public uint                   dwFields;
    public BP_RESOLUTION_LOCATION bpResLocation;
    public IDebugProgram2         pProgram;
    public IDebugThread2          pThread;
    public string                 bstrMessage;
    public uint                   dwType;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _BP_ERROR_RESOLUTION_INFO {
    BPERESI_FIELDS         dwFields;
    BP_RESOLUTION_LOCATION bpResLocation;
    IDebugProgram2*        pProgram;
    IDebugThread2*         pThread;
    BSTR                   bstrMessage;
    BP_ERROR_TYPE          dwType;
} BP_ERROR_RESOLUTION_INFO;
```
---

## Members
`dwFields`\
A combination of values from the [BPERESI_FIELDS](../../../extensibility/debugger/reference/bperesi-fields.md) enumeration specifying which fields of this structure are filled out.

`bpResLocation`\
The [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md) union, which specifies the breakpoint resolution location.

`pProgram`\
The [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the application in which the breakpoint error occurred.

`pThread`\
The [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread on which the application that generated the breakpoint error is running.

`bstrMessage`\
A string containing any warning or error message resulting from this error resolution.

`dwType`\
A value from the [BP_ERROR_TYPE](../../../extensibility/debugger/reference/bp-error-type.md) enumeration that specifies the breakpoint error type.

## Remarks
This structure is returned from the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md)
- [BPRESI_FIELDS](../../../extensibility/debugger/reference/bpresi-fields.md)
- [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [BP_ERROR_TYPE](../../../extensibility/debugger/reference/bp-error-type.md)
