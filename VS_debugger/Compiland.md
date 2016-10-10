---
title: "Compiland"
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
ms.assetid: c798eb2b-664a-41ec-ae90-5e9d292507ca
caps.latest.revision: 17
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
# Compiland
There is one `SymTagCompiland` symbol for each Compiland linked to the .exe file. Compiland information is split between symbols with a `SymTagCompiland` tag, which can be retrieved without loading additional compiland symbols, and symbols with a `SymTagCompilandDetails` tag, which may require loading additional symbols.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_editAndContinueEnabled](../VS_debugger/IDiaSymbol--get_editAndContinueEnabled.md)|`BOOL`|`TRUE` if Edit and Continue was enabled at compilation.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the .exe file.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_libraryName](../VS_debugger/IDiaSymbol--get_libraryName.md)|`BSTR`|Name of the library or object file where object was loaded from.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|File name of the compiland's object file.|  
|[IDiaSymbol::get_sourceFileName](../VS_debugger/IDiaSymbol--get_sourceFileName.md)|`BSTR`|Name of the source file.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagCompiland` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
  
## See Also  
 [CompilandDetails](../VS_debugger/CompilandDetails.md)   
 [CompilandEnv](../VS_debugger/CompilandEnv.md)   
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)