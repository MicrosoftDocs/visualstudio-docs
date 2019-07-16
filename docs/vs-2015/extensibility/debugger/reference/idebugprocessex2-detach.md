---
title: "IDebugProcessEx2::Detach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcessEx2::Detach"
helpviewer_keywords: 
  - "IDebugProcessEx2::Detach method"
ms.assetid: 66d54c2c-9302-47c8-9975-f30ed988ab29
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessEx2::Detach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method informs the process that a session is no longer debugging the process.  
  
## Syntax  
  
```cpp#  
HRESULT Detach(   
   IDebugSession2* pSession  
);  
```  
  
```csharp  
int Detach(  
   IDebugSession2 pSession  
);  
```  
  
#### Parameters  
 `pSession`  
 [in] A value that uniquely identifies the session to detach this process from.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The interface passed in `pSession` is to be treated only as a cookie, a value that uniquely identifies the session debug manager that originally attached to this process; none of the methods on the supplied interface are functional.  
  
## See Also  
 [IDebugProcessEx2](../../../extensibility/debugger/reference/idebugprocessex2.md)
