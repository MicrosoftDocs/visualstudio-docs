---
title: "IDebugEngineLaunch2::TerminateProcess | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEngineLaunch2::TerminateProcess"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::TerminateProcess"
ms.assetid: f7039e7f-5f57-4222-9ad2-11a66b2da6e0
caps.latest.revision: 10
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
# IDebugEngineLaunch2::TerminateProcess
Terminates a process.  
  
## Syntax  
  
```cpp#  
HRESULT TerminateProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```c#  
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
 [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [CanTerminateProcess](../../../extensibility/debugger/reference/idebugenginelaunch2-canterminateprocess.md)