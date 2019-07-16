---
title: "IDebugEngine2::CauseBreak | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine2::CauseBreak"
helpviewer_keywords: 
  - "IDebugEngine2::CauseBreak"
ms.assetid: 17fe4698-b04e-4798-8412-80e0da60c387
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine2::CauseBreak
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Requests that all programs being debugged by this debug engine (DE) to stop execution the next time one of their threads attempts to run.  
  
## Syntax  
  
```cpp#  
HRESULT CauseBreak(   
   void   
);  
```  
  
```csharp  
int CauseBreak();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is asynchronous: an [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event is sent when the program next attempts to execute after this method is called.  
  
## See Also  
 [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)   
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
