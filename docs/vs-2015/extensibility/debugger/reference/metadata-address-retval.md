---
title: "METADATA_ADDRESS_RETVAL | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "METADATA_ADDRESS_RETVAL"
helpviewer_keywords: 
  - "METADATA_ADDRESS_RETVAL structure"
ms.assetid: 5b0ec0fb-84b3-4ce7-8e24-becf3d881d7d
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# METADATA_ADDRESS_RETVAL
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This structure represents a return value from a method or function.  
  
## Syntax  
  
```cpp  
typedef struct _tagMETADATA_ADDRESS_RETVAL {  
   _mdToken tokMethod;  
   DWORD    dwCorType;  
   DWORD    dwSigSize;  
   BYTE     rgSig[10];  
} METADATA_ADDRESS_RETVAL;  
```  
  
```csharp  
public struct METADATA_ADDRESS_RETVAL {  
   public int    tokMethod;  
   public uint   dwCorType;  
   public uint   dwSigSize;  
   public byte[] rgSig;  
}  
```  
  
## Terms  
 tokMethod  
 The ID of the method this return value is for.  
  
 dwCorType  
 The base type of return value. This is a value from the `CorElementType` enumeration defined in the [!INCLUDE[dnprdnshort](../../../includes/dnprdnshort-md.md)] SDK corhdr.h file.  
  
 dwSigSize  
 The size of the return value signature (as stored in `rgSig`).  
  
 rgSig  
 An array of bytes forming the signature of the return value.  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_RETVAL` (a value from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)   
 [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)
