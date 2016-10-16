---
title: "UNMANAGED_ADDRESS_THIS_RELATIVE"
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
  - "UNMANAGED_ADDRESS_THIS_RELATIVE"
helpviewer_keywords: 
  - "UNMANAGED_ADDRESS_THIS_RELATIVE structure"
ms.assetid: e6a91ace-2d47-4ff9-aefb-8d8b68eab0b2
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
# UNMANAGED_ADDRESS_THIS_RELATIVE
This structure represents an address that is relative to a `this` pointer (`Me` in Visual Basic).  
  
## Syntax  
  
```cpp  
typedef struct _tagUNMANAGED_THIS_RELATIVE {  
   DWORD dwOffset;  
   DWORD dwBitOffset;  
   DWORD dwBitLength;  
} UNMANAGED_ADDRESS_THIS_RELATIVE;  
```  
  
```c#  
public struct UNMANAGED_THIS_RELATIVE {  
   public uint dwOffset;  
   public uint dwBitOffset;  
   public uint dwBitLength;  
}  
```  
  
## Terms  
 dwOffset  
 Byte offset from a base position (for example, start of a class vtable).  
  
 dwBitOffset  
 Offset in bits from a base position (always 0 unless referring to a bit field).  
  
 dwBitLength  
 Number of bits representing the address (always 0 unless referring to a bit field).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_UNMANAGED_THIS_RELATIVE` (a value from the [ADDRESS_KIND](../extensibility/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../extensibility/debug_address_union.md)