---
title: "dwTYPE_KIND"
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
  - "dwTYPE_KIND"
helpviewer_keywords: 
  - "dwTYPE_KIND enumeration"
ms.assetid: 6ff56b0f-c502-4e6c-9829-bfa05361b783
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
# dwTYPE_KIND
Specifies how to interpret the type of an [IDebugField](../extensibility/idebugfield.md) object.  
  
## Syntax  
  
```cpp#  
enum enum_dwTYPE_KIND {  
   TYPE_KIND_METADATA = 0x0001,  
   TYPE_KIND_PDB      = 0x0002,  
   TYPE_KIND_BUILT    = 0x0003,  
};  
  
typedef DWORD dwTYPE_KIND;  
```  
  
```c#  
public enum enum_dwTYPE_KIND {  
   TYPE_KIND_METADATA = 0x0001,  
   TYPE_KIND_PDB      = 0x0002,  
   TYPE_KIND_BUILT    = 0x0003,  
};  
```  
  
#### Parameters  
 TYPE_KIND_METADATA  
 The [TYPE_INFO](../extensibility/type_info.md) union should be interpreted as a [METADATA_TYPE](../extensibility/metadata_type.md) structure.  
  
 TYPE_KIND_PDB  
 The `TYPE_INFO` union should be interpreted as a [PDB_TYPE](../extensibility/pdb_type.md) structure.  
  
 TYPE_KIND_BUILT  
 The `TYPE_INFO` union should be interpreted as a [BUILT_TYPE](../extensibility/built_type.md) structure.  
  
## Remarks  
 The values of this enumeration appear in the `dwKind` field of the [TYPE_INFO](../extensibility/type_info.md) structure and are used to determine how to interpret the `type` union member. The `TYPE_INFO` structure is returned by a call to the [GetTypeInfo](../extensibility/idebugfield--gettypeinfo.md) method.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [TYPE_INFO](../extensibility/type_info.md)   
 [GetTypeInfo](../extensibility/idebugfield--gettypeinfo.md)   
 [METADATA_TYPE](../extensibility/metadata_type.md)   
 [PDB_TYPE](../extensibility/pdb_type.md)   
 [BUILT_TYPE](../extensibility/built_type.md)