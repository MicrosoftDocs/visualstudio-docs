---
title: "IEEVisualizerDataProvider::GetNewObjectForVisualizer | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEEVisualizerDataProvider::GetNewObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::GetNewObjectForVisualizer method"
ms.assetid: a898d549-4898-4fde-aad1-e8bb89129652
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IEEVisualizerDataProvider::GetNewObjectForVisualizer
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEEVisualizerDataProvider::GetNewObjectForVisualizer](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ieevisualizerdataprovider-getnewobjectforvisualizer).  
  
This method gets a new object for the visualizer. This method will always create a new object from the existing object.  
  
## Syntax  
  
```cpp  
HRESULT GetNewObjectForVisualizer(  
   IDebugObject** ppObject  
);  
```  
  
```csharp  
int GetNewObjectForVisualizer(  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] The new object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 `This method` re-evaluates the object it currently represents and returns the result as a new object. The existing object will be updated as a result of the evaluation.  
  
## See Also  
 [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)   
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)

