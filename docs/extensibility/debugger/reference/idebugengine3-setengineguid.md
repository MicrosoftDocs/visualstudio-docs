---
title: "IDebugEngine3::SetEngineGuid | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugEngine3::SetEngineGuid"
helpviewer_keywords: 
  - "IDebugEngine3::SetEngineGuid"
ms.assetid: 8bdfa05d-feb7-4d98-abac-77825a04c50f
caps.latest.revision: 10
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugEngine3::SetEngineGuid
This method sets the debug engine's (DE) `GUID`.  
  
## Syntax  
  
```cpp  
HRESULT SetEngineGuid(  
   GUID* guidEngine  
);  
```  
  
```  
[C#]  
int SetEngineGuid(  
   ref Guid guidEngine  
);  
```  
  
#### Parameters  
 `guidEngine`  
 [in] `GUID` of the engine.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)