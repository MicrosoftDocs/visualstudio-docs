---
title: "IDebugProperty Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugProperty interface"
ms.assetid: 7e8f5341-23ef-4029-814d-f5c2307b9203
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugProperty Interface
Used to describe any hierarchical property of the entity being debugged that has a name, type, and value. Most commonly, `IDebugProperty` is used to describe the result of expression evaluation, statement evaluation, or register evaluation.  
  
## Methods in Vtable Order  
 The following table shows the methods of the `IDebugProperty` Interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugProperty::GetPropertyInfo](../../winscript/reference/idebugproperty-getpropertyinfo.md)|Get the `DebugPropertyInfo` that describes this `IDebugProperty``.`|  
|[IDebugProperty::GetExtendedInfo](../../winscript/reference/idebugproperty-getextendedinfo.md)|Gets the extended information on a property.|  
|[IDebugProperty::SetValueAsString](../../winscript/reference/idebugproperty-setvalueasstring.md)|Sets the value of a property from a string.|  
|[IDebugProperty::EnumMembers](../../winscript/reference/idebugproperty-enummembers.md)|Enumerates the members of a property.|  
|[IDebugProperty::GetParent](../../winscript/reference/idebugproperty-getparent.md)|Gets the parent of a property.|  
  
## Requirements  
 Header: dbgprop.h