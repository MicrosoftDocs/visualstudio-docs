---
description: "This method sends events that signify the creation and destruction of processes and programs on a port."
title: IDebugPortEvents2::Event
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEvents2::Event
helpviewer_keywords:
- IDebugPortEvents2::Event
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEvents2::Event

This method sends events that signify the creation and destruction of processes and programs on a port.

## Syntax

### [C#](#tab/csharp)
```csharp
int Event(
   IDebugCoreServer2 pServer,
   IDebugPort2       pPort,
   IDebugProcess2    pProcess,
   IDebugProgram2    pProgram,
   IDebugEvent2      pEvent,
   ref Guid          riidEvent
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Event(
   IDebugCoreServer2* pServer,
   IDebugPort2*       pPort,
   IDebugProcess2*    pProcess,
   IDebugProgram2*    pProgram,
   IDebugEvent2*      pEvent,
   REFIID             riidEvent
);
```
---

## Parameters
`pMachine`\
[in] An [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md) object that represents the debug server (there is one for every instance of Visual Studio) in which the event occurred.

`pPort`\
[in] An [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port in which the event occurred.

`pProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process in which the event occurred.

`pProgram`\
[in] An [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program in which the event occurred.

`pEvent`\
[in] An [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) object that identifies the event. The possible events are as follows:

- [IDebugProcessCreateEvent2](../../../extensibility/debugger/reference/idebugprocesscreateevent2.md)

- [IDebugProcessDestroyEvent2](../../../extensibility/debugger/reference/idebugprocessdestroyevent2.md)

- [IDebugProgramCreateEvent2](../../../extensibility/debugger/reference/idebugprogramcreateevent2.md)

- [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)

`riidEvent`\
[in] The GUID of the event. Because the event is cast to [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) before calling this method, this identifier makes it easier to determine which event is being sent.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortEvents2](../../../extensibility/debugger/reference/idebugportevents2.md)
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
