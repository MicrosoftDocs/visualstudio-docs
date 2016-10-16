---
title: "IEEVisualizerService::GetCustomViewerList"
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
  - "IEEVisualizerService::GetCustomViewerList"
helpviewer_keywords: 
  - "IEEVisualizerService::GetCustomViewerList method"
ms.assetid: 249d26ca-914f-43af-a400-8162477223f4
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
# IEEVisualizerService::GetCustomViewerList
This method returns a list of type visualizers that this service knows about.  
  
## Syntax  
  
```cpp  
HRESULT GetCustomViewerList(  
   ULONG                celtSkip,  
   ULONG                celtRequested,  
   DEBUG_CUSTOM_VIEWER* rgViewers,  
   ULONG*               pceltFetched  
);  
```  
  
```c#  
int GetCustomViewerList(  
   uint                  celtSkip,  
   uint                  celtRequested,  
   DEBUG_CUSTOM_VIEWER[] rgViewers,  
   out uint              pceltFetched  
);  
```  
  
#### Parameters  
 `celtSkip`  
 [in] Number of visualizers to skip over.  
  
 `celRequested`  
 [in] Number of visualizers to retrieve (also specifies size of the `rgViewers` array).  
  
 `rgViewers`  
 [in, out] Array of [DEBUG_CUSTOM_VIEWER](../extensibility/debug_custom_viewer.md) structures to be filled in.  
  
 `pceltFetched`  
 [out] Number of visualizers actually retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [GetCustomViewerList](../extensibility/idebugproperty3--getcustomviewerlist.md) passes the request to this method as part of its support for type visualizers. If the expression evaluator also supplies custom viewers for the same type, it can append appropriately filled-out [DEBUG_CUSTOM_VIEWER](../extensibility/debug_custom_viewer.md) structures for those custom viewers to the list. Make sure that [GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md) reflects those additional viewers.  
  
 See [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md) for details on the differences between visualizers and viewers.  
  
## See Also  
 [IEEVisualizerService](../extensibility/ieevisualizerservice.md)   
 [DEBUG_CUSTOM_VIEWER](../extensibility/debug_custom_viewer.md)   
 [GetCustomViewerList](../extensibility/idebugproperty3--getcustomviewerlist.md)   
 [GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md)   
 [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md)