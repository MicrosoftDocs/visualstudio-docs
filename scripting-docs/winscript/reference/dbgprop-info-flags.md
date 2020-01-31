---
title: "DBGPROP_INFO_FLAGS | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "DBGPROP_INFO_FLAGS"
apilocation: 
  - "scrobj.dll"
f1_keywords: 
  - "DBGPROP_INFO_FLAGS"
helpviewer_keywords: 
  - "DBGPROP_INFO_FLAGS"
ms.assetid: e9450a21-a802-4c3e-8b3d-8e202f555de1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DBGPROP_INFO_FLAGS
Used to specify `DebugPropertyInfo` fields  
  
## Syntax  
  
```cpp
enum {  
   DBGPROP_INFO_NAME  =0x001,  
   DBGPROP_INFO_TYPE  =0x002,  
   DBGPROP_INFO_VALUE  =0x004,  
   DBGPROP_INFO_FULLNAME  =0x020,  
   DBGPROP_INFO_ATTRIBUTES  =0x008,  
   DBGPROP_INFO_DEBUGPROP  =0x010,  
   DBGPROP_INFO_AUTOEXPAND  =0x8000000  
};  
```  
  
## Members  
 DBGPROP_INFO_NAME  
 Initializes the `bstrName` field.  
  
 DBGPROP_INFO_TYPE  
 Initializes the `bstrType` field.  
  
 DBGPROP_INFO_VALUE  
 Initializes the `bstrValue` field.  
  
 DBGPROP_INFO_FULLNAME  
 Initializes the `bstrFullName` field.  
  
 DBGPROP_INFO_ATTRIBUTES  
 Initializes the `dwAttrib` field.  
  
 DBGPROP_INFO_DEBUGPROP  
 Initializes the `pDebugProp` field that contains an `IDebugProperty` interface.  
  
 DBGPROP_INFO_AUTOEXPAND  
 Specifies that the value field should contain the auto-expanded value, if available, for this type of object.  
  
## See also  
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)   
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)