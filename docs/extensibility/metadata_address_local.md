---
title: "METADATA_ADDRESS_LOCAL"
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
  - "METADATA_ADDRESS_LOCAL"
helpviewer_keywords: 
  - "METADATA_ADDRESS_LOCAL structure"
ms.assetid: 635f6bc5-c486-4e0e-83db-36f15e543843
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
# METADATA_ADDRESS_LOCAL
This structure represents the address of a local variable within a scope (usually a function or method).  
  
## Syntax  
  
```cpp  
typedef struct _tagMETADATA_ADDRESS_LOCAL {  
   _mdToken  tokMethod;  
   IUnknown* pLocal;  
   DWORD     dwIndex;  
} METADATA_ADDRESS_LOCAL;  
```  
  
```c#  
public struct METADATA_ADDRESS_LOCAL {  
   public int    tokMethod;  
   public object pLocal;  
   public uint   dwIndex;  
}  
```  
  
## Terms  
 tokMethod  
 The ID of the method or function the local variable is part of.  
  
 [C++] `_mdToken` is a `typedef` for a 32-bit `int`.  
  
 pLocal  
 The token whose address this structure represents.  
  
 dwIndex  
 Can be the index of this local variable in the method or function, or some other value (language-specific).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_LOCAL` (a value from the [ADDRESS_KIND](../extensibility/address_kind.md) enumeration).  
  
 `Warning:` [C++ only]  If `pLocal` is not null, then you must call `Release` on the token pointer (`addr` is a field in the [DEBUG_ADDRESS](../extensibility/debug_address.md) structure):  
  
```  
if (addr.dwKind == ADDRESS_KIND_METADATA_LOCAL &&  addr.addr.addrLocal.pLocal != NULL)  
{  
    addr.addr.addrLocal.pLocal->Release();  
}  
```  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md)   
 [DEBUG_ADDRESS](../extensibility/debug_address.md)   
 [ADDRESS_KIND](../extensibility/address_kind.md)