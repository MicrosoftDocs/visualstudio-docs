---
title: "IEnumDebugCustomAttributes"
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
  - "IEnumCustomAttributes"
helpviewer_keywords: 
  - "IEnumDebugCustomAttributes interface"
ms.assetid: 11aa768d-1852-44d6-9de3-17f9bafaded2
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
# IEnumDebugCustomAttributes
Enumerates custom attributes.  
  
## Syntax  
  
```  
IEnumCustomAttributes : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to support custom attributes (through the [IDebugCustomAttribute](../extensibility/idebugcustomattribute.md) interface).  
  
## Notes for Callers  
 [EnumCustomAttributes](../extensibility/idebugcustomattributequery2--enumcustomattributes.md) returns this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugCustomAttributes`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugcustomattributes--next.md)|Retrieves a specified number of custom attributes in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugcustomattributes--skip.md)|Skips a specified number of custom attributes in an enumeration sequence.|  
|[Reset](../extensibility/ienumdebugcustomattributes--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugcustomattributes--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugcustomattributes--getcount.md)|Gets the number of custom attributes in an enumerator.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [EnumCustomAttributes](../extensibility/idebugcustomattributequery2--enumcustomattributes.md)   
 [IDebugCustomAttribute](../extensibility/idebugcustomattribute.md)