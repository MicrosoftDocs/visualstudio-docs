---
title: "FIELD_INFO | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "FIELD_INFO"
helpviewer_keywords: 
  - "FIELD_INFO structure"
ms.assetid: bfafef6d-0c83-43d7-a779-1f0d24b166a1
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# FIELD_INFO
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

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
  
```csharp  
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
 A combination of flags from the [FIELD_INFO_FIELDS](../../../extensibility/debugger/reference/field-info-fields.md) enumeration that specifies which members are filled in.  
  
 bstrFullName  
 The full name of the field.  
  
 bstrName  
 The short name of the field.  
  
 bstrType  
 The type of the field.  
  
 dwModifiers  
 A combination of flags from the [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md) enumeration that describes the field.  
  
## Remarks  
 This structure is passed to the [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md) method where it is filled in.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [FIELD_INFO_FIELDS](../../../extensibility/debugger/reference/field-info-fields.md)   
 [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md)   
 [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md)
