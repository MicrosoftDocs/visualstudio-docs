---
title: "IDebugProperty3"
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
 The debug engine (DE) implements this interface on the same object that implements [IDebugProperty2](../extensibility/idebugproperty2.md) to provide support for long strings, property IDs, and custom viewers.  
  
## Notes for Callers  
 Call [QueryInterface](../Topic/QueryInterface.md) on an `IDebugProperty2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from `IDebugProperty2`, the `IDebugProperty3` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[GetStringCharLength](../extensibility/idebugproperty3--getstringcharlength.md)|Returns the length of the string associated with the property.|  
|[GetStringChars](../extensibility/idebugproperty3--getstringchars.md)|Returns the string in a user-supplied buffer.|  
|[CreateObjectID](../extensibility/idebugproperty3--createobjectid.md)|Creates a unique ID for this property.|  
|[DestroyObjectID](../extensibility/idebugproperty3--destroyobjectid.md)|Destroys the unique ID for this property.|  
|[GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md)|Returns the number of custom viewers that this property can be viewed with.|  
|[GetCustomViewerList](../extensibility/idebugproperty3--getcustomviewerlist.md)|Returns the list of custom viewers that this property can be viewed with.|  
|[SetValueAsStringWithError](../extensibility/idebugproperty3--setvalueasstringwitherror.md)|Sets the value of this property, returning an error message if anything went wrong.|  
  
## Remarks  
 [SetValueAsStringWithError](../extensibility/idebugproperty3--setvalueasstringwitherror.md) is the preferred way for the session debug manager (SDM) to set a property's value.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)   
 [IDebugCustomViewer](../extensibility/idebugcustomviewer.md)