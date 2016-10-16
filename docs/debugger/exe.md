---
title: "Exe"
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
  - ".dll files"
  - "Exe symbol"
  - ".exe files"
  - "executable files, Exe symbol"
ms.assetid: a781d2cf-55fe-4373-9cf1-b732864244e0
caps.latest.revision: 17
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
# Exe
Exe is the only symbol without either a lexical or class parent, as it represents the global scope of the .exe or .dll file. There is only one symbol with the `SymTagExe` tag per file. The [IDiaSession::get_globalScope](../debugger/idiasession--get_globalscope.md) method returns the symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_age](../debugger/idiasymbol--get_age.md)|`DWORD`|Age of this executable.|  
|[IDiaSymbol::get_guid](../debugger/idiasymbol--get_guid.md)|`GUID`|`GUID` of this executable.|  
|[IDiaSymbol::get_isCTypes](../debugger/idiasymbol--get_isctypes.md)|`BOOL`|`TRUE` if the symbol file associated with this executable contains C types (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_isStripped](../debugger/idiasymbol--get_isstripped.md)|`BOOL`|`TRUE` if private symbols have been stripped from the symbol file associated with this executable (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_machineType](../debugger/idiasymbol--get_machinetype.md)|`DWORD`|Value indicating target CPU (one of the [CV_CPU_TYPE_e Enumeration](../debugger/cv_cpu_type_e.md) values).|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|Name of the .exe file.|  
|[IDiaSymbol::get_signature](../debugger/idiasymbol--get_signature.md)|`DWORD`|Signature of the executable.|  
|[IDiaSymbol::get_symbolsFileName](../debugger/idiasymbol--get_symbolsfilename.md)|`BSTR`|Full path for the .exe file's .pdb or .dbg file.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagExe` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
  
## See Also  
 [IDiaSession::get_globalScope](../debugger/idiasession--get_globalscope.md)   
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)