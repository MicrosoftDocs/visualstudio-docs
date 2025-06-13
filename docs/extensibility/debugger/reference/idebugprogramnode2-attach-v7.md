---
title: IDebugProgramNode2::Attach_V7
description: "This interface method is an old, deprecated attach method used prior to Visual Studio 2005."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNode2::Attach
helpviewer_keywords:
- IDebugProgramNode2::Attach_V7
- IDebugProgramNode2::Attach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNode2::Attach_V7

> [!Note]
> DEPRECATED. DO NOT USE.

## Syntax

### [C#](#tab/csharp)
```csharp
int Attach_V7 (
   IDebugProgram2       pMDMProgram,
   IDebugEventCallback2 pCallback,
   uint                 dwReason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Attach_V7 (
   IDebugProgram2*       pMDMProgram,
   IDebugEventCallback2* pCallback,
   DWORD                 dwReason
);
```
---

## Parameters

`pMDMProgram`\
[in] The [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface that represents the program to attach to.

`pCallback`\
[in] The [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) interface to be used to send debug events to the SDM.

`dwReason`\
[in] A value from the [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md) enumeration that specifies the reason for attaching.

## Return Value

An implementation should always return `E_NOTIMPL`.

## Remarks

> [!WARNING]
> As of Visual Studio 2005, this method is no longer used and should always return `E_NOTIMPL`. See the [IDebugProgramNodeAttach2](../../../extensibility/debugger/reference/idebugprogramnodeattach2.md) interface for an alternative approach if the program node needs to indicate it cannot be attached to or if the program node is simply setting the program `GUID`. Otherwise, implement the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method.

## Prior to Visual Studio 2005

This method needs to be implemented only if the DE runs in the address space of the program being debugged. Otherwise, this method should return `S_FALSE`.

When this method is called, the DE must send the [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md) event object, if it has not already been sent for this instance of the [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) interface, as well as the [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md) and [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md) event objects. The [IDebugEntryPointEvent2](../../../extensibility/debugger/reference/idebugentrypointevent2.md) event object is then sent if the `dwReason` parameter is `ATTACH_REASON_LAUNCH`.

The DE must call the [GetProgramId](../../../extensibility/debugger/reference/idebugprogram2-getprogramid.md) method on the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object supplied by the [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md) event object, and must store that program's GUID in the instance data for the `IDebugProgram2` object implemented by the DE.

## See also

- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [IDebugProgramNodeAttach2](../../../extensibility/debugger/reference/idebugprogramnodeattach2.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md)
- [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md)
- [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md)
- [IDebugEntryPointEvent2](../../../extensibility/debugger/reference/idebugentrypointevent2.md)
- [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md)
