---
title: "EX_DBGPROP_INFO_FLAGS | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "EX_DBGPROP_INFO_FLAGS"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "EX_DBGPROP_INFO_FLAGS"
ms.assetid: ee309dfe-9432-4dff-8756-7a8d677f9dcc
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# EX_DBGPROP_INFO_FLAGS
Used to specify `ExtendedDebugPropertyInfo` fields.  
  
## Syntax  
  
```cpp
enum {  
   EX_DBGPROP_INFO_ID  =0x0100,  
   EX_DBGPROP_INFO_NTYPE  =0x0200,  
   EX_DBGPROP_INFO_NVALUE  =0x0400,  
   EX_DBGPROP_INFO_LOCKBYTES  =0x0800,  
   EX_DBGPROP_INFO_DEBUGEXTPROP  =0x1000  
};  
```  
  
## Members  
 EX_DBGPROP_INFO_ID  
 Initializes identifier for the property.  
  
 EX_DBGPROP_INFO_NTYPE  
 Initializes type of the property.  
  
 EX_DBGPROP_INFO_NVALUE  
 Initializes value of the property.  
  
 EX_DBGPROP_INFO_LOCKBYTES  
 Initializes the `plb` field.  
  
 EX_DBGPROP_INFO_DEBUGEXTPROP  
 Initializes the `pDebugExtProp` field that contains an `IDebugExtendedProperty` interface.  
  
## See also  
 [ExtendedDebugPropertyInfo Structure](../../winscript/reference/extendeddebugpropertyinfo-structure.md)   
 [IDebugExtendedProperty Interface](../../winscript/reference/idebugextendedproperty-interface.md)