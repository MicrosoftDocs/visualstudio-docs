---
title: "IEnumDebugReferenceInfo2"
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
  - "IEnumDebugReferenceInfo2"
helpviewer_keywords: 
  - "IEnumDebugReferenceInfo2"
ms.assetid: 7ed01441-686f-4032-8268-a4c750f19f85
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
# IEnumDebugReferenceInfo2
This interface enumerates [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md) structures.  
  
## Syntax  
  
```  
IEnumDebugReferenceInfo2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for references to objects in memory. This interface must be implemented only if references are supported.  
  
## Notes for Callers  
 Visual Studio calls [EnumChildren](../extensibility/idebugreference2--enumchildren.md) to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugReferenceInfo2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../extensibility/ienumdebugreferenceinfo2--next.md)|Retrieves a specified number of [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md) structures in an enumeration sequence.|  
|[Skip](../extensibility/ienumdebugreferenceinfo2--skip.md)|Skips a specified number of [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md) structures in the enumeration sequence.|  
|[Reset](../extensibility/ienumdebugreferenceinfo2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../extensibility/ienumdebugreferenceinfo2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../extensibility/ienumdebugreferenceinfo2--getcount.md)|Gets the number of [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md) structures in an enumerator.|  
  
## Remarks  
 A reference is essentially a type and an address, whereas a property is a name, type, and address. A reference persists as long as the object referred to exists in memory. See [IDebugReference2](../extensibility/idebugreference2.md) for more details.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../extensibility/core-interfaces.md)   
 [DEBUG_REFERENCE_INFO](../extensibility/debug_reference_info.md)   
 [IDebugReference2](../extensibility/idebugreference2.md)   
 [EnumChildren](../extensibility/idebugreference2--enumchildren.md)