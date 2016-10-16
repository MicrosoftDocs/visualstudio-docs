---
title: "UdtKind"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UdtKind enumeration"
ms.assetid: 400b59b9-373c-42cb-aae1-570494214328
caps.latest.revision: 8
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# UdtKind
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
 The values in this enumeration are returned by the [IDiaSymbol::get_udtKind](../debugger/idiasymbol--get_udtkind.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../debugger/enumerations-and-structures.md)   
 [IDiaSymbol::get_udtKind](../debugger/idiasymbol--get_udtkind.md)