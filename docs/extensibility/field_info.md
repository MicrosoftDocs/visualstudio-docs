---
title: "FIELD_INFO"
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
  - "FIELD_INFO"
helpviewer_keywords: 
  - "FIELD_INFO structure"
ms.assetid: bfafef6d-0c83-43d7-a779-1f0d24b166a1
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
# FIELD_INFO
This structure describes a local variable, parameter, or other field.  
  
## Syntax  
  
```cpp#  
typedef struct _tagFieldInfo {   
   FIELD_INFO_FIELDS dwFields;  
   BSTR              bstrFullName;  
   BSTR              bstrName;  
   BSTR              bstrType;  
   FIELD_MODIFIERS   dwModifiers;  
} FIELD_INFO;  
```  
  
```c#  
public struct FIELD_INFO {  
   public uint   dwFields;  
   public string bstrFullName;  
   public string bstrName;  
   public string bstrType;  
   public uint   dwModifiers;  
};  
```  
  
## Members  
 dwFields  
 A combination of flags from the [FIELD_INFO_FIELDS](../extensibility/field_info_fields.md) enumeration that specifies which members are filled in.  
  
 bstrFullName  
 The full name of the field.  
  
 bstrName  
 The short name of the field.  
  
 bstrType  
 The type of the field.  
  
 dwModifiers  
 A combination of flags from the [FIELD_MODIFIERS](../extensibility/field_modifiers.md) enumeration that describes the field.  
  
## Remarks  
 This structure is passed to the [GetInfo](../extensibility/idebugfield--getinfo.md) method where it is filled in.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [FIELD_INFO_FIELDS](../extensibility/field_info_fields.md)   
 [FIELD_MODIFIERS](../extensibility/field_modifiers.md)   
 [GetInfo](../extensibility/idebugfield--getinfo.md)