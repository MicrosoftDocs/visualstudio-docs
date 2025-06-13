---
description: "Stops all threads running in this program."
title: IDebugEngineProgram2::Stop
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineProgram2::Stop
helpviewer_keywords:
- IDebugEngineProgram2::Stop
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineProgram2::Stop

Stops all threads running in this program.

## Syntax

### [C#](#tab/csharp)
```csharp
int Stop();
```
### [C++](#tab/cpp)
```cpp
HRESULT Stop( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is called when this program is being debugged in a multi-program environment. When a stopping event from some other program is received, this method is called on this program. The implementation of this method should be asynchronous; that is, not all threads should be required to be stopped before this method returns. The implementation of this method may be as simple as calling the [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md) method on this program.

 Implementers should send an [IDebugStopCompleteEvent2](../../../extensibility/debugger/reference/idebugstopcompleteevent2.md) when the program stops.

## See also
- [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)
- [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)
