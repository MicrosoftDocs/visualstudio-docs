---
title: "NameSearchOptions"
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
ms.assetid: 67dfbede-2678-47df-b664-5c49841d0b9b
caps.latest.revision: 15
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
# NameSearchOptions
Specifies the search options for symbol and file names.  
  
## Syntax  
  
```cpp#  
enum NameSearchOptions {   
   nsNone,  
   nsfCaseSensitive     = 0x1,  
   nsfCaseInsensitive   = 0x2,  
   nsfFNameExt          = 0x4,  
   nsfRegularExpression = 0x8,  
   nsfUndecoratedName   = 0x10,  
  
// For backward compatibility:  
   nsCaseSensitive           = nsfCaseSensitive,  
   nsCaseInsensitive         = nsfCaseInsensitive,  
   nsFNameExt                = nsfCaseInsensitive | nsfFNameExt,  
   nsRegularExpression       = nsfRegularExpression | nsfCaseSensitive,  
   nsCaseInRegularExpression = nsfRegularExpression | nsfCaseInsensitive  
};  
```  
  
## Elements  
 `nsNone`  
 No options are specified.  
  
 `nsfCaseSensitive`  
 Applies a case-sensitive name match.  
  
 `nsfCaseInsensitive`  
 Applies a case-insensitive name match.  
  
 `nsfFNameExt`  
 Treats names as paths and applies a filename.ext name match.  
  
 `nsfRegularExpression`  
 Applies a case-sensitive name match using asterisks (*) and question marks (?) as wildcards.  
  
 `nsfUndecoratedName`  
 Applies only to symbols that have both undecorated and decorated names.  
  
## Remarks  
 The values from this enumeration are passed to the following methods:  
  
-   [IDiaSession::findChildren](../VS_debugger/IDiaSession--findChildren.md)  
  
-   [IDiaSession::findFile](../VS_debugger/IDiaSession--findFile.md)  
  
-   [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [Enumerations and Structures](../VS_debugger/Enumerations-and-Structures.md)   
 [IDiaSession::findChildren](../VS_debugger/IDiaSession--findChildren.md)   
 [IDiaSession::findFile](../VS_debugger/IDiaSession--findFile.md)   
 [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)