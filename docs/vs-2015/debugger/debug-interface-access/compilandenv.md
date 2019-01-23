---
title: "CompilandEnv | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CompilandEnv symbol"
ms.assetid: 808404bb-ece1-47f1-b9ea-c76d4d86ddd9
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CompilandEnv
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The compiler may include additional environment variables with symbols. There is one `SymTagCompilandEnv` symbol for each of these variables.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|`IDiaSymbol*`|Symbol for the parent compiland.|  
|[IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_name](../../debugger/debug-interface-access/idiasymbol-get-name.md)|`BSTR`|Name of the variable.|  
|[IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|`DWORD`|Returns `SymTagCompilandEnv` (one of the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) values).|  
|[IDiaSymbol::get_value](../../debugger/debug-interface-access/idiasymbol-get-value.md)|`VARIANT`|String-valued contents of the variable (`VT_BSTR`).|  
  
## See Also  
 [Compiland](../../debugger/debug-interface-access/compiland.md)   
 [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
