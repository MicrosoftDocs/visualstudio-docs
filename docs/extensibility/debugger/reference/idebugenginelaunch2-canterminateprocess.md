---
description: "Determines if a process can be terminated."
title: IDebugEngineLaunch2::CanTerminateProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineLaunch2::CanTerminateProcess
helpviewer_keywords:
- IDebugEngineLaunch2::CanTerminateProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineLaunch2::CanTerminateProcess

Determines if a process can be terminated.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanTerminateProcess ( 
   IDebugProcess2 pProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CanTerminateProcess ( 
   IDebugProcess2* pProcess
);
```
---

## Parameters
`pProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process to be terminated.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code. Returns `S_FALSE` if the engine cannot terminate the process, for example, because access is denied.

## Remarks
 If this method returns `S_OK`, then it the [TerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-terminateprocess.md) method can be called to actually terminate the process.

## See also
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [TerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-terminateprocess.md)
