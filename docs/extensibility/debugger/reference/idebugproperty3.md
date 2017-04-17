---
title: "IDebugProperty3 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty3"
helpviewer_keywords: 
  - "IDebugProperty3 interface"
ms.assetid: 8f9be68d-4490-4eca-8f6b-8a10ed77e226
caps.latest.revision: 12
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
# IDebugProperty3
This interface provides support for:  
  
-   Retrieving an arbitrarily long string associated with the property.  
  
-   Associating a unique ID with the property.  
  
-   Retrieving a list of custom viewers for the property.  
  
-   Setting the value of a property with the ability to report any resulting errors  
  
## Syntax  
  
```  
IDebugProperty3 : IDebugProperty2  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface on the same object that implements [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) to provide support for long strings, property IDs, and custom viewers.  
  
## Notes for Callers  
 Call [QueryInterface](/cpp/atl/queryinterface) on an `IDebugProperty2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from `IDebugProperty2`, the `IDebugProperty3` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[GetStringCharLength](../../../extensibility/debugger/reference/idebugproperty3-getstringcharlength.md)|Returns the length of the string associated with the property.|  
|[GetStringChars](../../../extensibility/debugger/reference/idebugproperty3-getstringchars.md)|Returns the string in a user-supplied buffer.|  
|[CreateObjectID](../../../extensibility/debugger/reference/idebugproperty3-createobjectid.md)|Creates a unique ID for this property.|  
|[DestroyObjectID](../../../extensibility/debugger/reference/idebugproperty3-destroyobjectid.md)|Destroys the unique ID for this property.|  
|[GetCustomViewerCount](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md)|Returns the number of custom viewers that this property can be viewed with.|  
|[GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md)|Returns the list of custom viewers that this property can be viewed with.|  
|[SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md)|Sets the value of this property, returning an error message if anything went wrong.|  
  
## Remarks  
 [SetValueAsStringWithError](../../../extensibility/debugger/reference/idebugproperty3-setvalueasstringwitherror.md) is the preferred way for the session debug manager (SDM) to set a property's value.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)   
 [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)   
 [IDebugCustomViewer](../../../extensibility/debugger/reference/idebugcustomviewer.md)