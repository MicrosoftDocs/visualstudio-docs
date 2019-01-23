---
title: "IDebugProperty3::GetCustomViewerList | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProperty3::GetCustomViewerList"
helpviewer_keywords: 
  - "IDebugProperty3::GetCustomViewerList"
ms.assetid: 74490fd8-6f44-4618-beea-dab64961bb8a
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProperty3::GetCustomViewerList
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets a list of custom viewers associated with this property.  
  
## Syntax  
  
```cpp  
HRESULT GetCustomViewerList(  
   ULONG                celtSkip,  
   ULONG                celtRequested,  
   DEBUG_CUSTOM_VIEWER* rgViewers,  
   ULONG*               pceltFetched  
);  
```  
  
```csharp  
int GetCustomViewerList(  
   uint                  celtSkip,  
   uint                  celtRequested,  
   DEBUG_CUSTOM_VIEWER[] rgViewers,  
   out uint              pceltFetched  
);  
```  
  
#### Parameters  
 `celtSkip`  
 [in] The number of viewers to skip over.  
  
 `celtRequested`  
 [in] The number of viewers to retrieve (also specifies the size of the `rgViewers` array).  
  
 `rgViewers`  
 [in, out] Array of [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) structures to be filled in.  
  
 `pceltFetched`  
 [out] The actual number of viewers returned.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To support type visualizers, this method forwards the call to the [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md) method. If the expression evaluator also supports custom viewers for this property's type, this method can append the appropriate custom viewers to the list.  
  
 See [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md) for details on the differences between type visualizers and custom viewers.  
  
## Example  
 The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface.  
  
```cpp#  
STDMETHODIMP CProperty::GetCustomViewerList(ULONG celtSkip, ULONG celtRequested, DEBUG_CUSTOM_VIEWER* prgViewers, ULONG* pceltFetched)  
{  
    if (NULL == prgViewers)  
    {  
        return E_POINTER;  
    }  
  
    if (GetVisualizerService())  
    {  
        return m_pIEEVisualizerService->GetCustomViewerList(celtSkip, celtRequested, prgViewers, pceltFetched);  
    }  
    else  
    {  
        return E_NOTIMPL;  
    }  
}  
```  
  
## See Also  
 [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)   
 [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md)   
 [GetCustomViewerList](../../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md)   
 [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
