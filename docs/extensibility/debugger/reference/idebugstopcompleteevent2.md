---
description: "The debug engine (DE) can send this optional event to the session debug manager (SDM) when a program has stopped."
title: IDebugStopCompleteEvent2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugStopCompleteEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugStopCompleteEvent2

The debug engine (DE) can send this optional event to the session debug manager (SDM) when a program has stopped.

## Syntax

```
IDebugStopCompleteEvent2 : IUnknown
```

## Notes for Implementers

This interface was introduced with Visual Studio 2005. Prior releases did not support asynchronous stopping.

- [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md) is called by the SDM in multi-process or multi-program scenarios. When one program sends a stopping event to the SDM, the SDM requests other programs to stop, too.

Stop is used to asynchronously inform the SDM that a program has stopped. Informing the SDM is useful for an interpreter debug engine, where sometimes no code is running inside the debugged program, so [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md) can't be completed synchronously. If a debug engine wants to employ this asynchronous notification, it must return `S_ASYNC_STOP` from [Stop](../../../extensibility/debugger/reference/idebugengineprogram2-stop.md).

## Requirements

Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
