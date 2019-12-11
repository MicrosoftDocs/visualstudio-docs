---
title: "DataKind | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DataKind enumeration"
ms.assetid: b64be708-22d6-4360-99e7-8f4e6b196de7
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DataKind
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Indicates the particular scope of a data value.  
  
## Syntax  
  
```cpp#  
enum DataKind {   
   DataIsUnknown,  
   DataIsLocal,  
   DataIsStaticLocal,  
   DataIsParam,  
   DataIsObjectPtr,  
   DataIsFileStatic,  
   DataIsGlobal,  
   DataIsMember,  
   DataIsStaticMember,  
   DataIsConstant  
};  
```  
  
## Elements  
 DataIsUnknown  
 Data symbol cannot be determined.  
  
 DataIsLocal  
 Data item is a local variable.  
  
 DataIsStaticLocal  
 Data item is a static local variable.  
  
 DataIsParam  
 Data item is a formal parameter.  
  
 DataIsObjectPtr  
 Data item is an object pointer (`this`).  
  
 DataIsFileStatic  
 Data item is a file-scoped variable.  
  
 DataIsGlobal  
 Data item is a global variable.  
  
 DataIsMember  
 Data item is an object member variable.  
  
 DataIsStaticMember  
 Data item is a class static variable.  
  
 DataIsConstant  
 Data item is a constant value.  
  
## Remarks  
 The values in this enumeration are returned by the [IDiaSymbol::get_dataKind](../../debugger/debug-interface-access/idiasymbol-get-datakind.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaSymbol::get_dataKind](../../debugger/debug-interface-access/idiasymbol-get-datakind.md)
