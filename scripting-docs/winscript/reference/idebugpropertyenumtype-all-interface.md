---
title: "IDebugPropertyEnumType_All Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugPropertyEnumType_All"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugPropertyEnumType_All interface"
ms.assetid: 4d0f4fd5-e5f7-47cb-b746-860d6363e2cd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugPropertyEnumType_All Interface
The `IDebugPropertyEnumType` interfaces are defined so that each of their IIDs can be passed as a filter to `IDebugProperty::EnumMembers` while requesting the appropriate enumerator.  
  
## Syntax  
  
```cpp
IDebugPropertyEnumType_All : IUnknown  
```  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugPropertyEnumType_All::GetName](../../winscript/reference/idebugpropertyenumtype-all-getname.md)|Returns a text string describing the name|  
  
 The following interfaces inherit from `IDebugPropertyEnumType_All`, and have no additional methods.  
  
```cpp
IDebugPropertyEnumType_Arguments : IDebugPropertyEnumType_All   
IDebugPropertyEnumType_Locals : IDebugPropertyEnumType_All   
IDebugPropertyEnumType_LocalsPlusArgs : IDebugPropertyEnumType_All   
IDebugPropertyEnumType_Registers : IDebugPropertyEnumType_All  
```  
  
## See also  
 [IDebugProperty::EnumMembers](../../winscript/reference/idebugproperty-enummembers.md)