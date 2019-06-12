---
title: "IDebugProcessEx2::Attach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcessEx2::Attach"
helpviewer_keywords: 
  - "IDebugProcessEx2::Attach method"
ms.assetid: f3334ed7-39bf-4d02-a338-36f567b9b287
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessEx2::Attach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method informs the process that a session is now debugging the process.  
  
## Syntax  
  
```cpp#  
HRESULT Attach(   
   IDebugSession2* pSession  
);  
```  
  
```csharp  
int Attach(  
   IDebugSession2 pSession  
);  
```  
  
#### Parameters  
 `pSession`  
 [in] A value that uniquely identifies the session attaching to this process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The interface passed in `pSession` is to be treated only as a cookie, a value that uniquely identifies the session debug manager attaching to this process; none of the methods on the supplied interface are functional.  
  
## See Also  
 [IDebugProcessEx2](../../../extensibility/debugger/reference/idebugprocessex2.md)
