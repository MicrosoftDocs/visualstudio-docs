---
title: "IEEVisualizerDataProvider::GetObjectForVisualizer | Microsoft Docs"
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
  - "IEEVisualizerDataProvider::GetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::GetObjectForVisualizer method"
ms.assetid: bd5376fc-13b4-40b7-9a5d-7ba8289f1b24
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
# IEEVisualizerDataProvider::GetObjectForVisualizer
This method gets the object that this visualizer represents.  
  
## Syntax  
  
```cpp  
HRESULT GetObjectForVisualizer(  
   IDebugObject** ppObject  
);  
```  
  
```c#  
int GetObjectForVisualizer(  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] The object being represented by this visualizer  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 `GetObjectForVisualizer` is allowed to return a cached version of the object. If the caller wants to make sure that the object is up to date, then it will call [GetNewObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer.md).  
  
## See Also  
 [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)   
 [GetNewObjectForVisualizer](../../../extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer.md)   
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)