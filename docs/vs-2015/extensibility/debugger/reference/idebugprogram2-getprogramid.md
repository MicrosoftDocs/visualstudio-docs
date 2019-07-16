---
title: "IDebugProgram2::GetProgramId | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgram2::GetProgramId"
helpviewer_keywords: 
  - "IDebugProgram2::GetProgramId"
ms.assetid: 2c31c0aa-2b71-46c7-849c-356e237d26f8
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProgram2::GetProgramId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets a GUID for this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetProgramId(   
   GUID* pguidProgramId  
);  
```  
  
```csharp  
int GetProgramId(   
   out Guid pguidProgramId  
);  
```  
  
#### Parameters  
 `pguidProgramId`  
 [out] Returns the `GUID` for this program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A debug engine (DE) must return the program identifier originally passed to the [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) or [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) methods. This allows identification of the program across debugger components.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md)   
 [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
