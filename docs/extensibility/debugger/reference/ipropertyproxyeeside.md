---
title: "IPropertyProxyEESide | Microsoft Docs"
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
  - "IPropertyProxyEESide"
helpviewer_keywords: 
  - "IPropertyProxyEESide interface"
ms.assetid: cf227cf8-39d9-4758-8f7e-a697aebb1926
caps.latest.revision: 13
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
# IPropertyProxyEESide
This interface provides methods to view data on the associated object. This interface is part of the support for type visualizers.  
  
## Syntax  
  
```  
IPropertyProxyEESide : IUnknown  
```  
  
## Notes for Implementers  
 An expression evaluator implements this interface to support type visualizers.  
  
## Notes for Callers  
 Call [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) to obtain this interface. Call [QueryInterface](/visual-cpp/atl/queryinterface) on an [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface to obtain the [IPropertyProxyProvider](../../../extensibility/debugger/reference/ipropertyproxyprovider.md) interface.  
  
## Methods in Vtable order  
 The following methods are implemented by this interface:  
  
|Method|Description|  
|------------|-----------------|  
|[InitSourceDataProvider](../../../extensibility/debugger/reference/ipropertyproxyeeside-initsourcedataprovider.md)|Initializes a data source provider so that the object's data can be accessed.|  
|[GetManagedViewerCreationData](../../../extensibility/debugger/reference/ipropertyproxyeeside-getmanagedviewercreationdata.md)|Retrieves information about the object's assembly.|  
|[GetInitialData](../../../extensibility/debugger/reference/ipropertyproxyeeside-getinitialdata.md)|Gets the initial data for the object.|  
|[CreateReplacementObject](../../../extensibility/debugger/reference/ipropertyproxyeeside-createreplacementobject.md)|Creates a copy of an existing data storage.|  
|[InPlaceUpdateObject](../../../extensibility/debugger/reference/ipropertyproxyeeside-inplaceupdateobject.md)|Creates a reference to an existing data storage.|  
|[ResolveAssemblyRef](../../../extensibility/debugger/reference/ipropertyproxyeeside-resolveassemblyref.md)|Retrieves information about a specific assembly in context of the assembly containing this object.|  
  
## Remarks  
 A type visualizer uses this interface to access the values associated with the object that this interface is part of. The data is accessed through the [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) interface, which provides a read-only view of the data.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)   
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)