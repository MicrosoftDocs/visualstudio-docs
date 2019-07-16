---
title: "IDebugEngineLaunch2::ResumeProcess | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngineLaunch2::ResumeProcess"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::ResumeProcess"
ms.assetid: 61ccc14e-75c6-44e7-aae4-57a9aac52089
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugEngineLaunch2::ResumeProcess
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Resumes process execution.  
  
## Syntax  
  
```cpp#  
HRESULT ResumeProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```csharp  
int ResumeProcess (   
   IDebugProcess2 pProcess  
);  
```  
  
#### Parameters  
 `pProcess`  
 [in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object that represents the process to be resumed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 This method is called after a process has been launched with a call to the [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md) method.  
  
## See Also  
 [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
