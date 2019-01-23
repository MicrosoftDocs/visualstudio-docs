---
title: "IDebugProgram2::Terminate | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::Terminate"
helpviewer_keywords: 
  - "IDebugProgram2::Terminate"
ms.assetid: 4d3127d3-b1e9-4b28-ac22-2f2eea255f86
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::Terminate
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Terminates the program.  
  
## Syntax  
  
```cpp#  
HRESULT Terminate(   
   void   
);  
```  
  
```csharp  
int Terminate();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If possible, the program will be terminated and unloaded from the process; otherwise, the debug engine (DE) will perform any necessary cleanup.  
  
 This method or the [Terminate](../../../extensibility/debugger/reference/idebugprocess2-terminate.md) method is called by the IDE, typically in response to the user halting all debugging. The implementation of this method should, ideally, terminate the program within the process. If this is not possible, the DE should prevent the program from running any more in this process (and do any necessary cleanup). If the `IDebugProcess2::Terminate` method was called by the IDE, the entire process will be terminated sometime after the `IDebugProgram2::Terminate` method is called.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [Terminate](../../../extensibility/debugger/reference/idebugprocess2-terminate.md)
