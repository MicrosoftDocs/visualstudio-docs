---
description: "Attaches a debug engine (DE) to a program or programs."
title: IDebugEngine2::Attach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::Attach
helpviewer_keywords:
- IDebugEngine2::Attach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::Attach

Attaches a debug engine (DE) to a program or programs. Called by the session debug manager (SDM) when the DE is running in-process to the SDM.

## Syntax

### [C#](#tab/csharp)
```csharp
int Attach( 
   IDebugProgram2[]     pProgram,
   IDebugProgramNode2[] rgpProgramNodes,
   uint                 celtPrograms,
   IDebugEventCallback2 pCallback,
   Enum_ATTACH_REASON   dwReason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Attach( 
   IDebugProgram2**      pProgram,
   IDebugProgramNode2**  rgpProgramNodes,
   DWORD                 celtPrograms,
   IDebugEventCallback2* pCallback,
   ATTACH_REASON         dwReason
);
```
---

## Parameters
`pProgram`\
[in] An array of [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) objects that represent programs to be attached to. These are port programs.

`rgpProgramNodes`\
[in] An array of [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) objects that represent program nodes, one for each program. The program nodes in this array represent the same programs as in `pProgram`. The program nodes are given so that the DE can identify the programs to attach to.

`celtPrograms`\
[in] Number of programs and/or program nodes in the `pProgram` and `rgpProgramNodes` arrays.

`pCallback`\
[in] The [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) object to be used to send debug events to the SDM.

`dwReason`\
[in] A value from the [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md) enumeration that specifies the reason for attaching these programs. For more information, see the Remarks section.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 There are three reasons for attaching to a program, as follows:

- `ATTACH_REASON_LAUNCH` indicates that the DE is attaching to the program because the user launched the process that contains it.

- `ATTACH_REASON_USER` indicates that the user has explicitly requested the DE to attach to a program (or the process that contains a program).

- `ATTACH_REASON_AUTO` indicates the DE is attaching to a particular program because it is already debugging other programs in a particular process. This is also called auto-attach.

  When this method is called, the DE needs to send these events in sequence:

1. [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md) (if it has not already been sent for a particular instance of the debug engine)

2. [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md)

3. [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md)

   In addition, if the reason for attaching is `ATTACH_REASON_LAUNCH`, the DE needs to send the [IDebugEntryPointEvent2](../../../extensibility/debugger/reference/idebugentrypointevent2.md) event.

   Once the DE gets the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object corresponding to the program being debugged, it can be queried for any private interface.

   Before calling the methods of a program node in the array given by `pProgram` or `rgpProgramNodes`, impersonation, if required, should be enabled on the `IDebugProgram2` interface that represents the program node. Normally, however, this step is not necessary. For more information, see [Security Issues](../../../extensibility/debugger/security-issues.md).

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
- [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md)
- [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md)
- [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md)
- [IDebugLoadCompleteEvent2](../../../extensibility/debugger/reference/idebugloadcompleteevent2.md)
- [IDebugEntryPointEvent2](../../../extensibility/debugger/reference/idebugentrypointevent2.md)
