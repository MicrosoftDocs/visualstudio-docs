---
title: "IDebugThread2::GetLogicalThread | Microsoft Docs"
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
  - "IDebugThread2::GetLogicalThread"
helpviewer_keywords: 
  - "IDebugThread2::GetLogicalThread"
ms.assetid: bce6230e-41d4-49b7-a050-2dde5efb6805
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugThread2::GetLogicalThread
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugThread2::GetLogicalThread](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugthread2-getlogicalthread).  
  
Debug engines do not implement this method.  
  
## Syntax  
  
```cpp#  
HRESULT GetLogicalThread(   
   IDebugStackFrame2*     pStackFrame,  
   IDebugLogicalThread2** ppLogicalThread  
);  
```  
  
```csharp  
int GetLogicalThread(   
   IDebugStackFrame2        pStackFrame,  
   out IDebugLogicalThread2 ppLogicalThread  
);  
```  
  
#### Parameters  
 `pStackFrame`  
 [in] An [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) object that represents the stack frame.  
  
 `ppLogicalThread`  
 [out] Returns an `IDebugLogicalThread2` interface that represents the associated logical thread. A debug engine implementation should set this to a null value.  
  
## Return Value  
 Debug engine implementations always return `E_NOTIMPL`.  
  
## See Also  
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)

