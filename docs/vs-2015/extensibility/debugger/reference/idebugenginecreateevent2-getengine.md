---
title: "IDebugEngineCreateEvent2::GetEngine | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngineCreateEvent2::GetEngine"
helpviewer_keywords: 
  - "IDebugEngineCreateEvent2::GetEngine"
ms.assetid: 187d24ed-9f9a-4418-a0ef-b8a19f54652c
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugEngineCreateEvent2::GetEngine
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the object that represents the newly created debug engine (DE).  
  
## Syntax  
  
```cpp#  
HRESULT GetEngine(   
   IDebugEngine2** pEngine  
);  
```  
  
```csharp  
int GetEngine(   
   out IDebugEngine2 pEngine  
);  
```  
  
#### Parameters  
 `pEngine`  
 [out] Returns an [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) object that represents the newly created DE.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugEngineCreateEvent2](../../../extensibility/debugger/reference/idebugenginecreateevent2.md)   
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
