---
description: "IDebugEngineLaunch2::TerminateProcess terminates a process."
title: IDebugEngineLaunch2::TerminateProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineLaunch2::TerminateProcess
helpviewer_keywords:
- IDebugEngineLaunch2::TerminateProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineLaunch2::TerminateProcess

Terminates a process.

## Syntax

### [C#](#tab/csharp)
```csharp
int TerminateProcess ( 
   IDebugProcess2 pProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT TerminateProcess ( 
   IDebugProcess2* pProcess
);
```
---

## Parameters
`pProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process to be terminated.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code.

## Remarks
 Call the [CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md) method before calling this method.

## See also
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md)
