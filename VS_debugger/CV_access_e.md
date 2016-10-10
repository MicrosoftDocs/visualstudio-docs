---
title: "CV_access_e"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 33c05d65-abb4-4800-a382-54a3805ea7b0
caps.latest.revision: 7
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CV_access_e
Specifies the scope of visibility (access level) of member functions and variables.  
  
## Syntax  
  
```cpp#  
typedef enum CV_access_e {   
   CV_private   = 1,  
   CV_protected = 2,  
   CV_public    = 3  
} CV_access_e;  
```  
  
## Elements  
 CV_private  
 Member has private access.  
  
 CV_protected  
 Member has protected access.  
  
 CV_public  
 Member has public access.  
  
## Remarks  
 The `friend` access specifier is not included here because it is typically used by non-member functions that have access to both private and protected elements of the class. Use the [IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md) method to find symbols with `SymTagFriend` access.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../VS_debugger/Enumerations-and-Structures.md)   
 [IDiaSymbol::get_access](../VS_debugger/IDiaSymbol--get_access.md)   
 [IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)