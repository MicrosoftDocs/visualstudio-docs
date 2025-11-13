---
description: "Get the process that this program is running in."
title: IDebugProgram2::GetProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetProcess
helpviewer_keywords:
- IDebugProgram2::GetProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetProcess

Get the process that this program is running in.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProcess(
   out IDebugProcess2 ppProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProcess(
   IDebugProcess2** ppProcess
);
```
---

## Parameters
`ppProcess`\
[out] Returns the [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) interface that represents the process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Unless a debug engine (DE) implements the [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md) interface, the DE's implementation of this method should always return `E_NOTIMPL` because a DE cannot determine which process it is running in and therefore cannot satisfy an implementation of this method.

 Implementing the `IDebugEngineLaunch2` interface means that the DE must know how to create a process; therefore, the DE's implementation of the [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) interface is able to know what process it is running in.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
