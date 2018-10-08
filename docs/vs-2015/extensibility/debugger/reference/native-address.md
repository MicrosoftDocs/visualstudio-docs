---
title: "NATIVE_ADDRESS | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "NATIVE_ADDRESS"
helpviewer_keywords: 
  - "NATIVE_ADDRESS structure"
ms.assetid: 7a0cd085-bfc8-45cc-a3d4-4459070e207a
caps.latest.revision: 7
ms.author: "gregvanl"
manager: "ghogen"
---
# NATIVE_ADDRESS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [NATIVE_ADDRESS](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/native-address).  
  
This structure represents a native address.  
  
## Syntax  
  
```cpp  
typedef struct _tagNATIVE_ADDRESS {  
   DWORD unknown;  
} NATIVE_ADDRESS;  
```  
  
```csharp  
public struct NATIVE_ADDRESS {  
   public uint unknown;  
}  
```  
  
## Terms  
 unknown  
 The native address (the meaning of this depends on the runtime and operating system).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) structure when the `dwKind` field of the `DEBUG_ADDRESS_UNION` structure is set to `ADDRESS_KIND_NATIVE` (a value from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)

