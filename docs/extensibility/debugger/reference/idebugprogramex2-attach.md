---
description: "Attach a session to a program."
title: IDebugProgramEx2::Attach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramEx2::Attach
helpviewer_keywords:
- IDebugProgramEx2::Attach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramEx2::Attach

Attach a session to a program.

## Syntax

### [C#](#tab/csharp)
```csharp
int Attach( 
   IDebugEventCallback2 pCallback,
   uint                 dwReason,
   IDebugSession2       pSession
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Attach( 
   IDebugEventCallback2* pCallback,
   DWORD                 dwReason,
   IDebugSession2*       pSession
);
```
---

## Parameters
`pCallback`\
[in] An [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) object that represents the callback function that the attached debug engine sends events to.

`dwReason`\
[in] A value from the [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md) enumeration that describes the reason for the attach operation.

`pSession`\
[in] A value that uniquely identifies the session that is attaching to the program.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code. This method should return `E_ATTACH_DEBUGGER_ALREADY_ATTACHED` if the program is already attached.

## Remarks
 The port that contains the program can use the value in `pSession` to determine which session is attempting to attach to the program. For example, if a port allows only one debug session to attach to a process at a time, the port can determine if the same session is already attached to other programs in the process.

> [!NOTE]
> The interface passed in `pSession` is to be treated only as a cookie, a value that uniquely identifies the session debug manager attaching to this program; none of the methods on the supplied interface are functional.

## See also
- [IDebugProgramEx2](../../../extensibility/debugger/reference/idebugprogramex2.md)
