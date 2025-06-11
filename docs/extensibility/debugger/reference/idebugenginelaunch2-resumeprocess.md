---
description: "Resumes process execution."
title: IDebugEngineLaunch2::ResumeProcess
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineLaunch2::ResumeProcess
helpviewer_keywords:
- IDebugEngineLaunch2::ResumeProcess
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineLaunch2::ResumeProcess

Resumes process execution.

## Syntax

### [C#](#tab/csharp)
```csharp
int ResumeProcess ( 
   IDebugProcess2 pProcess
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ResumeProcess ( 
   IDebugProcess2* pProcess
);
```
---

## Parameters
`pProcess`\
[in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process to be resumed.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code.

## Remarks
 This method is called after a process has been launched with a call to the [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md) method.

## See also
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
