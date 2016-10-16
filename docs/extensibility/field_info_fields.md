---
title: "FIELD_INFO_FIELDS"
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
  - "FIELD_INFO_FIELDS"
helpviewer_keywords: 
  - "FIELD_INFO_FIELDS enumeration"
ms.assetid: a69487d2-e701-4165-804a-8a011df9a3bd
caps.latest.revision: 14
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
# FIELD_INFO_FIELDS
Specifies what information to retrieve about an [IDebugField](../extensibility/idebugfield.md) object.  
  
## Syntax  
  
```cpp#  
enum enum_FIELD_INFO_FIELDS {   
   FIF_FULLNAME  = 0x0001,  
   FIF_NAME      = 0x0002,  
   FIF_TYPE      = 0x0004,  
   FIF_MODIFIERS = 0x0008,  
   FIF_ALL       = 0xffffffff,  
   FIF_NONE      = 0x0000  
};  
typedef DWORD FIELD_INFO_FIELDS;  
```  
  
```c#  
public enum enum_FIELD_INFO_FIELDS {  
   FIF_FULLNAME  = 0x0001,  
   FIF_NAME      = 0x0002,  
   FIF_TYPE      = 0x0004,  
   FIF_MODIFIERS = 0x0008,  
   FIF_ALL       = 0xffffffff,  
   FIF_NONE      = 0x0000  
};  
```  
  
## Members  
 FIF_FULLNAME  
 Initialize/use the `bstrFullName` field in the [FIELD_INFO](../extensibility/field_info.md) structure.  
  
 FIF_NAME  
 Initialize/use the `bstrName` field in the `FIELD_INFO` structure.  
  
 FIF_TYPE  
 Initialize/use the `bstrType` field in the `FIELD_INFO` structure.  
  
 FIF_MODIFIERS  
 Initialize/use the `bstrModifiers` field in the `FIELD_INFO` structure.  
  
## Remarks  
 These values are also passed as an argument to the [GetInfo](../extensibility/idebugfield--getinfo.md) method to specify which fields of the [FIELD_INFO](../extensibility/field_info.md) structure are to be initialized.  
  
 These values are also used in the `dwFields` member of the `FIELD_INFO` structure to indicate which fields are used and valid.  
  
 These flags may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [FIELD_INFO](../extensibility/field_info.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [GetInfo](../extensibility/idebugfield--getinfo.md)