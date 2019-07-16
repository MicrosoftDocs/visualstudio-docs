---
title: "IDebugEngineProgram2::Stop | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngineProgram2::Stop"
helpviewer_keywords: 
  - "IDebugEngineProgram2::Stop"
ms.assetid: 6e1c3d56-fb67-4a5b-80f9-8ee5131972bf
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugEngineProgram2::Stop
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Stops all threads running in this program.  
  
## Syntax  
  
```cpp#  
HRESULT Stop(   
   void   
);  
```  
  
```csharp  
int Stop();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is called when this program is being debugged in a multi-program environment. When a stopping event from some other program is received, this method is called on this program. The implementation of this method should be asynchronous; that is, not all threads should be required to be stopped before this method returns. The implementation of this method may be as simple as calling the [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md) method on this program.  
  
 No debug event is sent in response to this method.  
  
## See Also  
 [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)   
 [CauseBreak](../../../extensibility/debugger/reference/idebugprogram2-causebreak.md)
