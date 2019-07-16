---
title: "IDebugProgramEngines2::SetEngine | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramEngines2::SetEngine"
helpviewer_keywords: 
  - "IDebugProgramEngines2::SetEngine"
ms.assetid: c05857ee-89cf-455e-8f1e-300cce4a2eab
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramEngines2::SetEngine
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Tells the program or program node which debug engine (DE) to use to debug this program.  
  
## Syntax  
  
```cpp#  
HRESULT SetEngine(   
   REFGUID guidEngine  
);  
```  
  
```csharp  
int SetEngine(   
   ref Guid guidEngine  
);  
```  
  
#### Parameters  
 `guidEngine`  
 [in] The GUID of the DE.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramEngines2](../../../extensibility/debugger/reference/idebugprogramengines2.md)
