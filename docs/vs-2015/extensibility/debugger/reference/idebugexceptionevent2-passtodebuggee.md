---
title: "IDebugExceptionEvent2::PassToDebuggee | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugExceptionEvent2::PassToDebuggee"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::PassToDebuggee"
ms.assetid: a20d0f0b-2ca0-4437-bd22-9213c81d2738
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugExceptionEvent2::PassToDebuggee
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies whether the exception should be passed on to the program being debugged when execution resumes, or if the exception should be discarded.  
  
## Syntax  
  
```cpp#  
HRESULT PassToDebuggee(  
   BOOL fPass  
);  
```  
  
```csharp  
int PassToDebuggee(  
   int fPass  
);  
```  
  
#### Parameters  
 `fPass`  
 [in] Nonzero (`TRUE`) if the exception should be passed on to the program being debugged when execution resumes, or zero (`FALSE`) if the exception should be discarded.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Calling this method does not actually cause any code to be executed in the program being debugged. The call is merely to set the state for the next code execution. For example, calls to the [CanPassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md) method may return `S_OK` with the [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md).`dwState` field set to `EXCEPTION_STOP_SECOND_CHANCE`.  
  
 The IDE may receive the [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md) event and call the [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md) method. The debug engine (DE) should have a default behavior to handle the case if the `PassToDebuggee` method is not called.  
  
## See Also  
 [IDebugExceptionEvent2](../../../extensibility/debugger/reference/idebugexceptionevent2.md)   
 [CanPassToDebuggee](../../../extensibility/debugger/reference/idebugexceptionevent2-canpasstodebuggee.md)   
 [Continue](../../../extensibility/debugger/reference/idebugprogram2-continue.md)
