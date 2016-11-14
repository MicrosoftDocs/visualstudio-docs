---
title: "IDebugQueryEngine2::GetEngineInterface | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugQueryEngine2::GetEngineInterface"
helpviewer_keywords: 
  - "IDebugQueryEngine2::GetEngineInterface"
ms.assetid: ed84aa98-7ec7-48f3-97ae-821090bc3664
caps.latest.revision: 9
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
# IDebugQueryEngine2::GetEngineInterface
Gets a custom debug engine (DE) interface.  
  
## Syntax  
  
```cpp#  
HRESULT GetEngineInterface(   
   IUnknown** ppUnk  
);  
```  
  
```c#  
int GetEngineInterface(   
   out object ppUnk  
);  
```  
  
#### Parameters  
 `ppUnk`  
 [out] Returns an `IUnknown` object represents the debug engine (DE), and which can be queried for any other valid interface associated with a DE (for example [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) or [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The resulting interface should be used with care because calling through interfaces retrieved from this method circumvents the session debug manager's processing and may result in the SDM getting into a bad state or generating errors while debugging.  
  
## See Also  
 [IDebugQueryEngine2](../../../extensibility/debugger/reference/idebugqueryengine2.md)   
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)   
 [IDebugEngineLaunch2](../../../extensibility/debugger/reference/idebugenginelaunch2.md)