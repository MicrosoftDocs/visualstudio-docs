---
title: "IDebugProcessEx2::AddImplicitProgramNodes"
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
  - "IDebugProcessEx2::AddImplicitProgramNodes"
helpviewer_keywords: 
  - "IDebugProcessEx2::AddImplicitProgramNodes method"
ms.assetid: 8b491b00-f9e7-45b3-9115-fe58c3464289
caps.latest.revision: 10
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
# IDebugProcessEx2::AddImplicitProgramNodes
This method adds a program node for each debug engine (DE) specified.  
  
## Syntax  
  
```cpp#  
HRESULT AddImplicitProgramNodes(  
   REFGUID guidLaunchingEngine,  
   GUID*   rgguidSpecificEngines,  
   DWORD   celtSpecificEngines  
);  
```  
  
```c#  
int AddImplicitProgramNodes(  
   ref Guid guidLaunchingEngine,  
   Guid[]   rgguidSpecificEngines,  
   uint     celtSpecificEngines  
);  
```  
  
#### Parameters  
 `guidLaunchingEngine`  
 [in] The `GUID` of a DE that is to be used to launch programs (and is assumed to add its own program nodes).  
  
 `rgguidSpecificEngines`  
 [in] Array of `GUID`s of DEs for which program nodes will be added.  
  
 `celtSpecificEngines`  
 [in] The number of `GUID`s in the `rgguidSpecificEngines` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [Program Nodes](../extensibility/program-nodes.md) will be added for each DE listed in `rgguidSpecificEngines`—excluding the launching engine (as given in `guidLaunchingEngine`), which is assumed to add its own program node when it launches a program.  
  
## See Also  
 [IDebugProgramEx2](../extensibility/idebugprogramex2.md)   
 [Program Nodes](../extensibility/program-nodes.md)