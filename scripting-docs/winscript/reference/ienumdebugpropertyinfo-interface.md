---
title: "IEnumDebugPropertyInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IEnumDebugPropertyInfo interface"
ms.assetid: c5eea4da-8414-408a-a8f6-6a9ca8745868
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugPropertyInfo Interface
Enumerates `DebugPropertyInfo` structures.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPropertyInfo`.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugPropertyInfo::Next](../../winscript/reference/ienumdebugpropertyinfo-next.md)|Retrieves a specified number of `DebugPropertyInfo` structures in an enumeration sequence.|  
|[IEnumDebugPropertyInfo::Skip](../../winscript/reference/ienumdebugpropertyinfo-skip.md)|Skips a specified number of `DebugPropertyInfo` structures in an enumeration sequence.|  
|[IEnumDebugPropertyInfo::Reset](../../winscript/reference/ienumdebugpropertyinfo-reset.md)|Resets the enumeration sequence to the beginning.|  
|[IEnumDebugPropertyInfo::Clone](../../winscript/reference/ienumdebugpropertyinfo-clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[IEnumDebugPropertyInfo::GetCount](../../winscript/reference/ienumdebugpropertyinfo-getcount.md)|Gets the number of `DebugPropertyInfo` structures in an enumerator.|  
  
## Requirements  
 Header: dbgprop.h  
  
## See also  
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)