---
title: "IPropertyProxyProvider"
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
  - "IPropertyProxyProvider"
helpviewer_keywords: 
  - "IPropertyProxyProvider interface"
ms.assetid: 52e9f7fc-6fe0-4d23-890b-5673dca8c3cb
caps.latest.revision: 11
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
# IPropertyProxyProvider
This interface supplies a proxy interface to view and change an object's data.  
  
## Syntax  
  
```  
IPropertyProxyProvider : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator (EE) implements this interface on the same object that implements the [IDebugProperty3](../extensibility/idebugproperty3.md) interface as part of the EE's support of type visualizers.  
  
## Notes for Callers  
 Call [QueryInterface](../Topic/QueryInterface.md) on an `IDebugProperty3` interface to obtain this interface.  
  
## Methods in Vtable order  
 The `IPropertyProxyProvider` interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[GetPropertyProxy](../extensibility/ipropertyproxyprovider--getpropertyproxy.md)|Retrieves a property proxy interface to view data on an object.|  
  
## Remarks  
 Although the EE implements this interface, the implementation of [GetPropertyProxy](../extensibility/ipropertyproxyprovider--getpropertyproxy.md) is typically handled by [GetPropertyProxy](../extensibility/ieevisualizerservice--getpropertyproxy.md). See [Visualizing and Viewing Data](../extensibility/visualizing-and-viewing-data.md) for details on obtaining the IEEVisualizerService interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [GetPropertyProxy](../extensibility/ieevisualizerservice--getpropertyproxy.md)   
 [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md)   
 [Visualizing and Viewing Data](../extensibility/visualizing-and-viewing-data.md)