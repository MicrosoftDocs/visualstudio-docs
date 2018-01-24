---
title: "IDebugThreadDestroyEvent2::GetExitCode | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugThreadDestroyEvent2::GetExitCode"
helpviewer_keywords: 
  - "IDebugThreadDestroyEvent2::GetExitCode"
ms.assetid: 8bf47a17-f811-4d9b-bcea-7488908830ff
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugThreadDestroyEvent2::GetExitCode
Gets the exit code for a thread.  
  
## Syntax  
  
```cpp  
HRESULT GetExitCode (   
   DWORD* pdwExit  
);  
```  
  
```csharp  
int GetExitCode (   
   out uint pdwExit  
);  
```  
  
#### Parameters  
 `pdwExit`  
 [out] Returns the thread's exit code.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugThreadDestroyEvent2](../../../extensibility/debugger/reference/idebugthreaddestroyevent2.md)