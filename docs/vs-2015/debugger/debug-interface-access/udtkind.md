---
title: "UdtKind | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UdtKind enumeration"
ms.assetid: 400b59b9-373c-42cb-aae1-570494214328
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# UdtKind
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Describes the variety of user-defined type (UDT).  
  
## Syntax  
  
```cpp#  
enum UdtKind {   
   UdtStruct,  
   UdtClass,  
   UdtUnion,  
   UdtInterface  
};  
```  
  
## Elements  
 UdtStruct  
 UDT is a structure.  
  
 UdtClass  
 UDT is a class.  
  
 UdtUnion  
 UDT is a union.  
  
 UdtInterface  
 UDT is an interface.  
  
## Remarks  
 The values in this enumeration are returned by the [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaSymbol::get_udtKind](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md)
