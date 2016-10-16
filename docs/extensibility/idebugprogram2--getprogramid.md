---
title: "IDebugProgram2::GetProgramId"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProgram2::GetProgramId"
helpviewer_keywords: 
  - "IDebugProgram2::GetProgramId"
ms.assetid: 2c31c0aa-2b71-46c7-849c-356e237d26f8
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugProgram2::GetProgramId
Gets a GUID for this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetProgramId(   
   GUID* pguidProgramId  
);  
```  
  
```c#  
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
 A debug engine (DE) must return the program identifier originally passed to the [OnAttach](../extensibility/idebugprogramnodeattach2--onattach.md) or [Attach](../extensibility/idebugengine2--attach.md) methods. This allows identification of the program across debugger components.  
  
## See Also  
 [IDebugProgram2](../extensibility/idebugprogram2.md)   
 [OnAttach](../extensibility/idebugprogramnodeattach2--onattach.md)   
 [Attach](../extensibility/idebugengine2--attach.md)