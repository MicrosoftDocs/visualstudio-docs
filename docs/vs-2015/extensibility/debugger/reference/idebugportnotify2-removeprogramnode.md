---
title: "IDebugPortNotify2::RemoveProgramNode | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugPortNotify2::RemoveProgramNode"
helpviewer_keywords: 
  - "IDebugPortNotify2::RemoveProgramNode"
ms.assetid: 3668157b-66d2-416e-a359-fc04dcd18a48
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugPortNotify2::RemoveProgramNode
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Unregisters a program that can be debugged from the port it is running on.  
  
## Syntax  
  
```cpp#  
HRESULT RemoveProgramNode(   
   IDebugProgramNode2* pProgramNode  
);  
```  
  
```csharp  
int RemoveProgramNode(   
   IDebugProgramNode2 pProgramNode  
);  
```  
  
#### Parameters  
 `pProgramNode`  
 [in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) objecy that represents the program to be unregistered.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method removes a program node that was added with a call to the [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md) method.  
  
## See Also  
 [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md)   
 [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)   
 [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)
