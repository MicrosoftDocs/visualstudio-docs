---
title: "IDebugThread2::GetThreadId | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugThread2::GetThreadId"
helpviewer_keywords: 
  - "IDebugThread2::GetThreadId"
ms.assetid: db8b1c07-6b86-47f9-b292-bac19c276d36
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugThread2::GetThreadId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the system thread identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetThreadId (   
   DWORD* pdwThreadId  
);  
```  
  
```csharp  
int GetThreadId (   
   out uint pdwThreadId  
);  
```  
  
#### Parameters  
 `pdwThreadId`  
 [out] Returns the system thread identifier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A thread ID is used to identify a thread among all other threads in a process.  
  
## Example  
 The following example shows how to implement this method for a simple `CProgram` object that implements the [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) interface.  
  
```cpp#  
HRESULT CProgram::GetThreadId(DWORD* pdwThreadId) {     
   *pdwThreadId = GetCurrentThreadId();    
   return NOERROR;    
}    
```  
  
## See Also  
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)

