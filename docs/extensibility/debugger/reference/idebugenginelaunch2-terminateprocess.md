---
title: "IDebugEngineLaunch2::TerminateProcess | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugEngineLaunch2::TerminateProcess"
helpviewer_keywords:
  - "IDebugEngineLaunch2::TerminateProcess"
ms.assetid: f7039e7f-5f57-4222-9ad2-11a66b2da6e0
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugEngineLaunch2::TerminateProcess
Terminates a process.

## Syntax

```cpp
HRESULT TerminateProcess ( 
   IDebugProcess2* pProcess
);
```

```csharp
int TerminateProcess ( 
   IDebugProcess2 pProcess
);
```

#### Parameters
 `pProcess`

 [in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process to be terminated.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code.

## Remarks
 Call the [CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md) method before calling this method.

## See Also
- [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md)