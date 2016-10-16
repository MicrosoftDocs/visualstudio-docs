---
title: "IDebugEngineLaunch2::ResumeProcess"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugEngineLaunch2::ResumeProcess"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::ResumeProcess"
ms.assetid: 61ccc14e-75c6-44e7-aae4-57a9aac52089
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugEngineLaunch2::ResumeProcess
Resumes process execution.  
  
## Syntax  
  
```cpp#  
HRESULT ResumeProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```c#  
int ResumeProcess (   
   IDebugProcess2 pProcess  
);  
```  
  
#### Parameters  
 `pProcess`  
 [in] An [IDebugProcess2](../extensibility/idebugprocess2.md) object that represents the process to be resumed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 This method is called after a process has been launched with a call to the [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md) method.  
  
## See Also  
 [IDebugEngineLaunch2](../extensibility/idebugenginelaunch2.md)   
 [IDebugProcess2](../extensibility/idebugprocess2.md)   
 [LaunchSuspended](../extensibility/idebugenginelaunch2--launchsuspended.md)