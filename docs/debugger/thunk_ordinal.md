---
title: "THUNK_ORDINAL"
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
  - "Thunk_Ordinal enumeration"
ms.assetid: 026f98a9-36b8-41ef-8a72-12d7cbc2d362
caps.latest.revision: 9
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
# THUNK_ORDINAL
Designates thunk types.  
  
## Syntax  
  
```cpp#  
typedef enum THUNK_ORDINAL {   
   THUNK_ORDINAL_NOTYPE,  
   THUNK_ORDINAL_ADJUSTOR,  
   THUNK_ORDINAL_VCALL,  
   THUNK_ORDINAL_PCODE,  
   THUNK_ORDINAL_LOAD   
  
   // trampoline thunk ordinals - only for use in Trampoline thunk symbols  
   THUNK_ORDINAL_TRAMP_INCREMENTAL,  
   THUNK_ORDINAL_TRAMP_BRANCHISLAND,  
} THUNK_ORDINAL;  
```  
  
## Elements  
 THUNK_ORDINAL_NOTYPE  
 Standard thunk.  
  
 THUNK_ORDINAL_ADJUSTOR  
 A `this` adjustor thunk.  
  
 THUNK_ORDINAL_VCALL  
 Virtual call thunk.  
  
 THUNK_ORDINAL_PCODE  
 P-code thunk.  
  
 THUNK_ORDINAL_LOAD  
 Delay load thunk.  
  
 THUNK_ORDINAL_TRAMP_INCREMENTAL  
 Incremental trampoline thunk (a trampoline thunk is used to bounce calls from one memory space to another).  
  
 THUNK_ORDINAL_TRAMP_BRANCHISLAND  
 Branch point trampoline thunk.  
  
## Remarks  
 The values in this enumeration are returned from a call to the [IDiaSymbol::get_thunkOrdinal](../debugger/idiasymbol--get_thunkordinal.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../debugger/enumerations-and-structures.md)   
 [IDiaSymbol::get_thunkOrdinal](../debugger/idiasymbol--get_thunkordinal.md)