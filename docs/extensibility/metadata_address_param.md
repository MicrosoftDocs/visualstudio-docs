---
title: "METADATA_ADDRESS_PARAM"
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
  - "METADATA_ADDRESS_PARAM"
helpviewer_keywords: 
  - "METADATA_ADDRESS_PARAM structure"
ms.assetid: 90904f19-0e71-4cb3-a56e-6a2e92f66dfc
caps.latest.revision: 6
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
# METADATA_ADDRESS_PARAM
This structure represents a parameter of a method or function.  
  
## Syntax  
  
```cpp  
typedef struct _tagMETADATA_ADDRESS_PARAM {  
   _mdToken tokMethod;  
   _mdToken tokParam;  
   DWORD    dwIndex;  
} METADATA_ADDRESS_PARAM;  
```  
  
```c#  
public struct METADATA_ADDRESS_PARAM {  
   public int  tokMethod;  
   public int  tokParam;  
   public uint dwIndex;  
}  
```  
  
## Terms  
 tokMethod  
 The ID of the method the parameter is part of.  
  
 tokParam  
 The ID of the parameter.  
  
 dwIndex  
 The index of the parameter in a list of parameters.  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_PARAM` (a value from the [ADDRESS_KIND](../extensibility/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md)   
 [ADDRESS_KIND](../extensibility/address_kind.md)