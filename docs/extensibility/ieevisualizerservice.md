---
title: "IEEVisualizerService"
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
  - "IEEVisualizerService"
helpviewer_keywords: 
  - "IEEVisualizerService interface"
ms.assetid: 3bdb124b-c582-47ba-b465-13c6a1cdb702
caps.latest.revision: 17
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
# IEEVisualizerService
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface implements key methods that supply functionality to the [IDebugProperty3](../extensibility/idebugproperty3.md) and [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md) interfaces.  
  
## Syntax  
  
```  
IEEVisualizerService : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio implements this interface to allow an expression evaluator (EE) to support type visualizers.  
  
## Notes for Callers  
 The EE calls [CreateVisualizerService](../extensibility/ieevisualizerserviceprovider--createvisualizerservice.md) to obtain this interface as part of its support for type visualizers.  
  
## Methods in Vtable order  
  
|Method|Description|  
|------------|-----------------|  
|[GetCustomViewerCount](../extensibility/ieevisualizerservice--getcustomviewercount.md)|Retrieves the number of custom viewers about which this service knows.|  
|[GetCustomViewerList](../extensibility/ieevisualizerservice--getcustomviewerlist.md)|Retrieves the list of custom viewers.|  
|[GetPropertyProxy](../extensibility/ieevisualizerservice--getpropertyproxy.md)|Returns a proxy object for a property.|  
|[GetValueDisplayStringCount](../extensibility/ieevisualizerservice--getvaluedisplaystringcount.md)|Retrieves the number of value strings to display for the specified property or field.|  
  
## Remarks  
 The IDE uses the [IDebugProperty3](../extensibility/idebugproperty3.md) interface to determine if there are any custom viewers or type visualizers for the property. By creating a visualizer service (with [CreateVisualizerService](../extensibility/ieevisualizerserviceprovider--createvisualizerservice.md)), the EE can supply the functionality to the `IDebugProperty3` and [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md) (which supports viewing and changing a property's value) interfaces and thereby support type visualizers.  
  
 If an EE has custom viewers that itself implements, the EE can append the `CLSID`s of those custom viewers to the end of the list returned by [GetCustomViewerList](../extensibility/ieevisualizerservice--getcustomviewerlist.md). This allows an EE to support both type visualizers and its own custom viewers. Just be sure that [GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md) reflects the addition of any custom viewers.  
  
 See [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md) for a discussion of the difference between visualizers and viewers.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [IDebugProperty3](../extensibility/idebugproperty3.md)   
 [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md)   
 [CreateVisualizerService](../extensibility/ieevisualizerserviceprovider--createvisualizerservice.md)   
 [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md)