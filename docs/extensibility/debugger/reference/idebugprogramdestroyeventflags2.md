---
description: "Enables a debug engine to override the default behavior of the Visual Studio UI when you end a debug session."
title: IDebugProgramDestroyEventFlags2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProgramDestroyEventFlags2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramDestroyEventFlags2

Enables a debug engine to override the default behavior of the Visual Studio UI when you end a debug session.

## Syntax

```
IDebugProgramDestroyEventFlags2 : IUnknown
```

## Notes for Implementers
 This interface is implemented by debug engines. It is useful for hosts that might create and destroy multiple programs over the lifetime of a process.

## Methods
 The following table shows the methods of `IDebugProgramDestroyEventFlags2`.

|Method|Description|
|------------|-----------------|
|[GetFlags](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2-getflags.md)|Retrieves the program destroy flags.|

## Remarks
 The default behavior of the Visual Studio UI is to go back to design mode after all programs have sent a program destroy event. This interface enables a debug engine to change that behavior.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
