---
title: "IDebugThread2::GetProgram | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugThread2::GetProgram"
helpviewer_keywords: 
  - "IDebugThread2::GetProgram"
ms.assetid: 8c9c5ea1-2031-472e-bc8f-30e22e754566
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugThread2::GetProgram
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the program in which a thread is running.  
  
## Syntax  
  
```cpp#  
HRESULT GetProgram (   
   IDebugProgram2** ppProgram  
);  
```  
  
```csharp  
int GetProgram (   
   out IDebugProgram2 ppProgram  
);  
```  
  
#### Parameters  
 `ppProgram`  
 [out] Returns an [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program this thread is running in.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)   
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
