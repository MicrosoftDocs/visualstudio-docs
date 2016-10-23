---
title: "Exe"
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
ms.assetid: a781d2cf-55fe-4373-9cf1-b732864244e0
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
# Exe
Exe is the only symbol without either a lexical or class parent, as it represents the global scope of the .exe or .dll file. There is only one symbol with the `SymTagExe` tag per file. The [IDiaSession::get_globalScope](../VS_debugger/IDiaSession--get_globalScope.md) method returns the symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_age](../VS_debugger/IDiaSymbol--get_age.md)|`DWORD`|Age of this executable.|  
|[IDiaSymbol::get_guid](../VS_debugger/IDiaSymbol--get_guid.md)|`GUID`|`GUID` of this executable.|  
|[IDiaSymbol::get_isCTypes](../VS_debugger/IDiaSymbol--get_isCTypes.md)|`BOOL`|`TRUE` if the symbol file associated with this executable contains C types (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_isStripped](../VS_debugger/IDiaSymbol--get_isStripped.md)|`BOOL`|`TRUE` if private symbols have been stripped from the symbol file associated with this executable (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_machineType](../VS_debugger/IDiaSymbol--get_machineType.md)|`DWORD`|Value indicating target CPU (one of the [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md) values).|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the .exe file.|  
|[IDiaSymbol::get_signature](../VS_debugger/IDiaSymbol--get_signature.md)|`DWORD`|Signature of the executable.|  
|[IDiaSymbol::get_symbolsFileName](../VS_debugger/IDiaSymbol--get_symbolsFileName.md)|`BSTR`|Full path for the .exe file's .pdb or .dbg file.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagExe` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
  
## See Also  
 [IDiaSession::get_globalScope](../VS_debugger/IDiaSession--get_globalScope.md)   
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)