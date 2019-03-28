---
title: "IDebugEngine3::SetJustMyCodeState | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine3::SetJustMyCodeState"
helpviewer_keywords: 
  - "IDebugEngine3::SetJustMyCodeState"
ms.assetid: 8ec17fbf-df93-424a-b2ed-fd1e5ee51256
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine3::SetJustMyCodeState
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method tells the debug engine about the JustMyCode state information.  
  
## Syntax  
  
```cpp  
HRESULT SetJustMyCodeState(  
   BOOL           fUpdate,  
   DWORD          dwModules,  
   JMC_CODE_SPEC* rgJMCSpec  
);  
```  
  
```csharp  
int SetJustMyCodeState(  
   int             fUpdate,   
   uint            dwModules,   
   JMC_CODE_SPEC[] rgJMCSpec  
);  
```  
  
#### Parameters  
 `fUpdate`  
 [in] Nonzero (`TRUE`) to update current information, zero (`FALSE`) to reset all information (ignoring anything previously set).  
  
 `dwModules`  
 [in] Number of information structures in `rgJMCSpec.`  
  
 `rgJMCSpec`  
 [in] Array of [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md) structures to use.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 JustMyCode is the concept of debugging only the code that belongs to a user and ignoring all intermediate code such as system code—even if source code is available for that system code.  
  
## See Also  
 [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)   
 [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md)
