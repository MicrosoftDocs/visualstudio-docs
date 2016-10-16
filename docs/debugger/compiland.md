---
title: "Compiland"
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
  - "compiland symbol"
  - "compilands, compiland symbol"
ms.assetid: c798eb2b-664a-41ec-ae90-5e9d292507ca
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
# Compiland
There is one `SymTagCompiland` symbol for each Compiland linked to the .exe file. Compiland information is split between symbols with a `SymTagCompiland` tag, which can be retrieved without loading additional compiland symbols, and symbols with a `SymTagCompilandDetails` tag, which may require loading additional symbols.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_editAndContinueEnabled](../debugger/idiasymbol--get_editandcontinueenabled.md)|`BOOL`|`TRUE` if Edit and Continue was enabled at compilation.|  
|[IDiaSymbol::get_lexicalParent](../debugger/idiasymbol--get_lexicalparent.md)|`IDiaSymbol*`|Symbol for the .exe file.|  
|[IDiaSymbol::get_lexicalParentId](../debugger/idiasymbol--get_lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_libraryName](../debugger/idiasymbol--get_libraryname.md)|`BSTR`|Name of the library or object file where object was loaded from.|  
|[IDiaSymbol::get_name](../debugger/idiasymbol--get_name.md)|`BSTR`|File name of the compiland's object file.|  
|[IDiaSymbol::get_sourceFileName](../debugger/idiasymbol--get_sourcefilename.md)|`BSTR`|Name of the source file.|  
|[IDiaSymbol::get_symIndexId](../debugger/idiasymbol--get_symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../debugger/idiasymbol--get_symtag.md)|`DWORD`|Returns `SymTagCompiland` (one of the [SymTagEnum Enumeration](../debugger/symtagenum.md) values).|  
  
## See Also  
 [CompilandDetails](../debugger/compilanddetails.md)   
 [CompilandEnv](../debugger/compilandenv.md)   
 [Lexical Hierarchy of Symbol Types](../debugger/lexical-hierarchy-of-symbol-types.md)