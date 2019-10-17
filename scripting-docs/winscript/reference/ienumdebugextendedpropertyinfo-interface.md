---
title: "IEnumDebugExtendedPropertyInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumDebugExtendedPropertyInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumDebugExtendedPropertyInfo interface"
ms.assetid: 316d5aa7-c949-48fc-89c1-239f00566cae
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExtendedPropertyInfo Interface
Enumerates `ExtendedDebugPropertyInfo` structures.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugExtendedPropertyInfo`.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugExtendedPropertyInfo::Clone](../../winscript/reference/ienumdebugextendedpropertyinfo-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[IEnumDebugExtendedPropertyInfo::GetCount](../../winscript/reference/ienumdebugextendedpropertyinfo-getcount.md)|Gets the number of `ExtendedDebugPropertyInfo` structures in an enumerator.|  
|[IEnumDebugExtendedPropertyInfo::Next](../../winscript/reference/ienumdebugextendedpropertyinfo-next.md)|Retrieves a specified number of `ExtendedDebugPropertyInfo` structures in an enumeration sequence.|  
|[IEnumDebugExtendedPropertyInfo::Skip](../../winscript/reference/ienumdebugextendedpropertyinfo-skip.md)|Skips a specified number of `ExtendedDebugPropertyInfo` structures in an enumeration sequence.|  
|[IEnumDebugExtendedPropertyInfo::Reset](../../winscript/reference/ienumdebugextendedpropertyinfo-reset.md)|Resets the enumeration sequence to the beginning.|  
  
## Requirements  
 Header: dbgprop.h  
  
## See also  
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)