---
title: "IEEDataStorage | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEEDataStorage"
helpviewer_keywords: 
  - "IEEDataStorage interface"
ms.assetid: 704e932d-2325-410e-89c4-ce88c6ec19da
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
# IEEDataStorage
This interface represents an array of bytes.  
  
## Syntax  
  
```  
IEEDataStorage : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator (EE) implements this interface to represent an array of bytes (used by type visualizers to retrieve and change data through the [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) interface). The EE typically implements this interface to support external type visualizers.  
  
## Notes for Callers  
 The methods on the `IPropertyProxyEESide` interface all return this interface. Call [GetPropertyProxy](../../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) to obtain the [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md) interface. Call [QueryInterface](/cpp/atl/queryinterface) on an [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface to obtain the [IPropertyProxyProvider](../../../extensibility/debugger/reference/ipropertyproxyprovider.md) interface.  
  
## Methods in Vtable order  
 The `IEEDataStorage` interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetData](../../../extensibility/debugger/reference/ieedatastorage-getdata.md)|Retrieves the specified number of data bytes to a supplied buffer.|  
|[GetSize](../../../extensibility/debugger/reference/ieedatastorage-getsize.md)|Retrieves the number of data bytes available.|  
  
## Remarks  
 This interface is used by a type visualizer to access data held by a specific object. The data is treated as an array of bytes, allowing the type visualizer to manipulate it in whatever way is required to present it to the user.  
  
 A custom viewer can also use this interface, if desired, although more typically, a custom viewer would use a custom interface, [GetMemoryBytes](../../../extensibility/debugger/reference/idebugproperty2-getmemorybytes.md) or [GetStringChars](../../../extensibility/debugger/reference/idebugproperty3-getstringchars.md) (for string-oriented data).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [Type Visualizer and Custom Viewer](../../../extensibility/debugger/type-visualizer-and-custom-viewer.md)