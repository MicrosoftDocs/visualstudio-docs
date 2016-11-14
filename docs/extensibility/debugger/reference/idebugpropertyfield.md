---
title: "IDebugPropertyField | Microsoft Docs"
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
  - "IDebugPropertyField"
helpviewer_keywords: 
  - "IDebugPropertyField interface"
ms.assetid: b50edb2c-fb8d-4def-993d-17d23d2027c1
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
# IDebugPropertyField
This interface provides the functions that allow getting and setting a property.  
  
## Syntax  
  
```  
IDebugPropertyField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md). This interface is a specialization that supports the concept of properties on a class.  
  
## Notes for Callers  
 Use [QueryInterface](/visual-cpp/atl/queryinterface) to obtain this interface from the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface if the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method returns `FIELD_KIND_PROP`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) and [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetPropertyGetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertygetter.md)|Gets the method that gets the property.|  
|[GetPropertySetter](../../../extensibility/debugger/reference/idebugpropertyfield-getpropertysetter.md)|Gets the method that sets the property.|  
  
## Remarks  
 A property is a managed code concept and represents a method that is treated as a variable. Properties do not exist in unmanaged C++.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)