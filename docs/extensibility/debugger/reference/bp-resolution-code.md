---
title: "BP_RESOLUTION_CODE | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "BP_RESOLUTION_CODE"
helpviewer_keywords:
  - "BP_RESOLUTION_CODE structure"
ms.assetid: ac103ec5-771c-4667-92de-b5abb53bbb52
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# BP_RESOLUTION_CODE
Describes the location of a code breakpoint.

## Syntax

```cpp
typedef struct _BP_RESOLUTION_CODE {
    IDebugCodeContext2* pCodeContext;
} BP_RESOLUTION_CODE;
```

```csharp
public struct BP_RESOLUTION_CODE {
    public IDebugCodeContext2 pCodeContext;
};
```

## Members
`pCodeContext`\
The [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that identifies the position of the breakpoint in the code.

## Remarks
This structure is a member of the [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md) structure, which is in turn a member of the [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structure returned by the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md) method.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)
- [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)
- [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)
- [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)
