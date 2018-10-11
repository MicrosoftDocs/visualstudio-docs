---
title: "IDebugThread2::CanSetNextStatement | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugThread2::CanSetNextStatement"
helpviewer_keywords: 
  - "IDebugThread2::CanSetNextStatement"
ms.assetid: 7014af80-ff4f-4790-a34b-0528918d1fa3
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugThread2::CanSetNextStatement
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugThread2::CanSetNextStatement](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugthread2-cansetnextstatement).  
  
Determines whether the current instruction pointer can be set to the given stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT CanSetNextStatement (   
   IDebugStackFrame2*  pStackFrame,  
   IDebugCodeContext2* pCodeContext  
);  
```  
  
```csharp  
int CanSetNextStatement (   
   IDebugStackFrame2  pStackFrame,  
   IDebugCodeContext2 pCodeContext  
);  
```  
  
#### Parameters  
 `pStackFrame`  
 Reserved for future use; set to a null value. If this is a null value, use the current stack frame.  
  
 `pCodeContext`  
 [in] An [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md) object that describes the code location about to be executed and its context.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If this method returns `S_OK`, then call the [SetNextStatement](../../../extensibility/debugger/reference/idebugthread2-setnextstatement.md) method to actually set the next statement.  
  
## See Also  
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)   
 [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)   
 [IDebugCodeContext2](../../../extensibility/debugger/reference/idebugcodecontext2.md)   
 [SetNextStatement](../../../extensibility/debugger/reference/idebugthread2-setnextstatement.md)

