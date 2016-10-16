---
title: "ADDRESS_KIND"
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
  - "ADDRESS_KIND"
helpviewer_keywords: 
  - "ADDRESS_KIND enumeration"
ms.assetid: 3a12fbec-7088-4cf9-8f6f-ad8ddec6009a
caps.latest.revision: 8
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
# ADDRESS_KIND
Specifies the kinds of addresses.  
  
## Syntax  
  
```cpp  
enum enum_ADDRESS_KIND {  
   ADDRESS_KIND_NATIVE                  = 0x0001,  
   ADDRESS_KIND_UNMANAGED_THIS_RELATIVE = 0x0002,  
   ADDRESS_KIND_UNMANAGED_PHYSICAL      = 0x0005,  
   ADDRESS_KIND_METADATA_METHOD         = 0x0010,  
   ADDRESS_KIND_METADATA_FIELD          = 0x0011,  
   ADDRESS_KIND_METADATA_LOCAL          = 0x0012,  
   ADDRESS_KIND_METADATA_PARAM          = 0x0013,  
   ADDRESS_KIND_METADATA_ARRAYELEM      = 0x0014,  
   ADDRESS_KIND_METADATA_RETVAL         = 0x0015,  
};  
typedef DWORD ADDRESS_KIND;  
```  
  
```c#  
public enum enum_ADDRESS_KIND {  
   ADDRESS_KIND_NATIVE                  = 0x0001,  
   ADDRESS_KIND_UNMANAGED_THIS_RELATIVE = 0x0002,  
   ADDRESS_KIND_UNMANAGED_PHYSICAL      = 0x0005,  
   ADDRESS_KIND_METADATA_METHOD         = 0x0010,  
   ADDRESS_KIND_METADATA_FIELD          = 0x0011,  
   ADDRESS_KIND_METADATA_LOCAL          = 0x0012,  
   ADDRESS_KIND_METADATA_PARAM          = 0x0013,  
   ADDRESS_KIND_METADATA_ARRAYELEM      = 0x0014,  
   ADDRESS_KIND_METADATA_RETVAL         = 0x0015,  
};  
```  
  
## Terms  
 ADDRESS_KIND_NATIVE  
 A native address, represented by the [NATIVE_ADDRESS](../extensibility/native_address.md) structure.  
  
 ADDRESS_KIND_UNMANAGED_THIS_RELATIVE  
 An unmanaged address relative to a `this` (`Me` in Visual Basic) pointer and represented by the [UNMANAGED_ADDRESS_THIS_RELATIVE](../extensibility/unmanaged_address_this_relative.md) structure.  
  
 ADDRESS_KIND_UNMANAGED_PHYSICAL  
 An unmanaged physical address, represented by the [UNMANAGED_ADDRESS_PHYSICAL](../extensibility/unmanaged_address_physical.md) structure.  
  
 ADDRESS_KIND_METHOD  
 A method of a class, represented by the [METADATA_ADDRESS_METHOD](../extensibility/metadata_address_method.md) structure.  
  
 ADDRESS_KIND_FIELD  
 A field of a class, represented by the [METADATA_ADDRESS_FIELD](../extensibility/metadata_address_field.md) structure.  
  
 ADDRESS_KIND_LOCAL  
 The address is for a local variable and is represented by the [METADATA_ADDRESS_LOCAL](../extensibility/metadata_address_local.md) structure.  
  
 ADDRESS_KIND_PARAM  
 A method or function parameter, represented by the [METADATA_ADDRESS_PARAM](../extensibility/metadata_address_param.md) structure.  
  
 ADDRESS_KIND_ARRAYELEM  
 An array element, represented by the [METADATA_ADDRESS_ARRAYELEM](../extensibility/metadata_address_arrayelem.md) structure.  
  
 ADDRESS_KIND_RETVAL  
 A return value, represented by the [METADATA_ADDRESS_RETVAL](../extensibility/metadata_address_retval.md) structure.  
  
## Remarks  
 The [GetAddress](../extensibility/idebugaddress--getaddress.md) method returns the [DEBUG_ADDRESS](../extensibility/debug_address.md) structure which contains a union of possible structures, the [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md) structure. The `dwKind` field of the `DEBUG_ADDRESS_UNION` structure holds the `ADDRESS_KIND` value and describes how to interpret the union field.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [GetAddress](../extensibility/idebugaddress--getaddress.md)   
 [DEBUG_ADDRESS](../extensibility/debug_address.md)   
 [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md)