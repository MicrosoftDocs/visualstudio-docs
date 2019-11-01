---
title: "DBGPROP_ATTRIB_FLAGS | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "DBGPROP_ATTRIB_FLAGS"
apilocation: 
  - "scrobj.dll"
f1_keywords: 
  - "DBGPROP_ATTRIB_FLAGS"
helpviewer_keywords: 
  - "DBGPROP_ATTRIB_FLAGS"
ms.assetid: 90314496-527b-4357-9df8-125a360bf216
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DBGPROP_ATTRIB_FLAGS
Describes various attributes for an `IDebugProperty`. Member of the `DebugPropertyInfo` structure.  
  
## Syntax  
  
```cpp
enum {  
DBGPROP_ATTRIB_NO_ATTRIB  =0x00000000,  
   DBGPROP_ATTRIB_VALUE_IS_INVALID  =0x00000008,  
   DBGPROP_ATTRIB_VALUE_IS_EXPANDABLE  =0x00000010,  
   DBGPROP_ATTRIB_VALUE_READONLY  =0x00000800,  
   DBGPROP_ATTRIB_ACCESS_PUBLIC  =0x00001000,  
   DBGPROP_ATTRIB_ACCESS_PRIVATE  =0x00002000,  
   DBGPROP_ATTRIB_ACCESS_PROTECTED  =0x00004000,  
   DBGPROP_ATTRIB_ACCESS_FINAL  =0x00008000,  
   DBGPROP_ATTRIB_STORAGE_GLOBAL  =0x00010000,  
   DBGPROP_ATTRIB_STORAGE_STATIC  =0x00020000,  
   DBGPROP_ATTRIB_STORAGE_FIELD  =0x00040000,  
   DBGPROP_ATTRIB_STORAGE_VIRTUAL  =0x00080000,  
   DBGPROP_ATTRIB_TYPE_IS_CONSTANT  =0x00100000,  
   DBGPROP_ATTRIB_TYPE_IS_SYNCHRONIZED  =0x00200000,  
   DBGPROP_ATTRIB_TYPE_IS_VOLATILE  =0x00400000,  
   DBGPROP_ATTRIB_HAS_EXTENDED_ATTRIBS  =0x00800000  
   DBGPROP_ATTRIB_VALUE_IS_RETURN_VALUE  =0x08000000,  
};  
  
```  
  
## Members  
 DBGPROP_ATTRIB_NO_ATTRIB  
 Indicates no attributes.  
  
 DBGPROP_ATTRIB_VALUE_IS_INVALID  
 Indicates that the value in `DebugPropertyInfo::bstrValue` is not valid.  
  
 DBGPROP_ATTRIB_VALUE_IS_EXPANDABLE  
 Indicates that the reference or property has children.  
  
 DBGPROP_ATTRIB_VALUE_READONLY  
 Indicates that the value is read-only.  
  
 DBGPROP_ATTRIB_ACCESS_PUBLIC  
 Indicates an object that has public access.  
  
 DBGPROP_ATTRIB_ACCESS_PRIVATE  
 Indicates an object that has private access.  
  
 DBGPROP_ATTRIB_ACCESS_PROTECTED  
 Indicates an object that has protected access.  
  
 DBGPROP_ATTRIB_ACCESS_FINAL  
 Indicates an object that has final access.  
  
 DBGPROP_ATTRIB_STORAGE_GLOBAL  
 Indicates global storage.  
  
 DBGPROP_ATTRIB_STORAGE_STATIC  
 Indicates static storage.  
  
 DBGPROP_ATTRIB_STORAGE_FIELD  
 Indicates an object that is a property.  
  
 DBGPROP_ATTRIB_STORAGE_VIRTUAL  
 Indicates virtual storage.  
  
 DBGPROP_ATTRIB_TYPE_IS_CONSTANT  
 Indicates that the type of object is constant.  
  
 DBGPROP_ATTRIB_TYPE_IS_SYNCHRONIZED  
 Indicates that this slot is thread synchronized.  
  
 DBGPROP_ATTRIB_TYPE_IS_VOLATILE  
 Indicates that this slot is volatile with respect to persistent storage.  
  
 DBGPROP_ATTRIB_HAS_EXTENDED_ATTRIBS  
 Indicates that this slot has attributes above and beyond these predefined bits.  
  
 DBGPROP_ATTRIB_VALUE_IS_RETURN_VALUE  
 Indicates that the value is a return value from a function.  
  
## Remarks  
 These flags are also used to filter children of an object. The values may be combined with a bitwise OR.  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)   
 [DebugPropertyInfo Structure](../../winscript/reference/debugpropertyinfo-structure.md)