---
title: "METADATA_TYPE"
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
  - "METADATA_TYPE"
helpviewer_keywords: 
  - "METADATA_TYPE structure"
ms.assetid: 2d8b78f6-0aef-4d79-809a-cff9b2c24659
caps.latest.revision: 7
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
# METADATA_TYPE
This structure specifies information about a field type taken from metadata.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTYPE_METADATA {  
   ULONG32  ulAppDomainID;  
   GUID     guidModule;  
   _mdToken tokClass;  
} METADATA_TYPE;  
```  
  
```c#  
public struct METADATA_TYPE {  
   public uint ulAppDomainID;  
   public Guid guidModule;  
   public int  tokClass;  
};  
```  
  
#### Parameters  
 ulAppDomainID  
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.  
  
 guidModule  
 The GUID of the module that contains this field.  
  
 tokClass  
 The metadata token ID of this type.  
  
 [C++] `_mdToken` is a `typedef` for a 32-bit `int`.  
  
## Remarks  
 This structure appears as part of the union in the [TYPE_INFO](../extensibility/type_info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_METADATA` (a value from the [dwTYPE_KIND](../extensibility/dwtype_kind.md) enumeration).  
  
 The `tokClass` value is a metadata token that uniquely identifies a type. For details on how to interpret the upper bits of the metadata token ID, see the `CorTokenType` enumeration in the corhdr.h file in the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)] SDK.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [TYPE_INFO](../extensibility/type_info.md)   
 [dwTYPE_KIND](../extensibility/dwtype_kind.md)