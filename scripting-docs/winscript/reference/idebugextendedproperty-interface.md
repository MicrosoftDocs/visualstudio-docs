---
title: "IDebugExtendedProperty Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugExtendedProperty interface"
ms.assetid: e92ea064-0d92-44cf-bb9f-abda783d84be
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExtendedProperty Interface
Extends `IDebugProperty` interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from `IDebugProperty`, this interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugExtendedProperty::GetExtendedPropertyInfo](../../winscript/reference/idebugextendedproperty-getextendedpropertyinfo.md)|Gets the `ExtendedDebugPropertyInfo` that describes this `IDebugExtendedProperty``.`|  
|[IDebugExtendedProperty::EnumExtendedMembers](../../winscript/reference/idebugextendedproperty-enumextendedmembers.md)|Enumerates the members of an extended property.|  
  
## Requirements  
 Header: dbgprop.h  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)