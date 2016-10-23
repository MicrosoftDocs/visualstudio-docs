---
title: "CompilandDetails"
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
ms.assetid: ddc7d794-c622-4c63-b2a6-72f8b2d0022a
caps.latest.revision: 19
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
# CompilandDetails
Compiland information is split between symbols with a `SymTagCompiland` tag (low detail) and a `SymTagCompilandDetails` tag (high detail). `SymTagCompilandDetails` requires loading additional symbols. However, it provides a wealth of information about the compiland that is not available with a `SymTagCompiland` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_backEndBuild](../VS_debugger/IDiaSymbol--get_backEndBuild.md)|`DWORD`|Back-end build number of the compiler.|  
|[IDiaSymbol::get_backEndMajor](../VS_debugger/IDiaSymbol--get_backEndMajor.md)|`DWORD`|Back-end major version number of the compiler.|  
|[IDiaSymbol::get_backEndMinor](../VS_debugger/IDiaSymbol--get_backEndMinor.md)|`DWORD`|Back-end minor version number of the compiler.|  
|[IDiaSymbol::get_compilerName](../VS_debugger/IDiaSymbol--get_compilerName.md)|`BSTR`|Name of the compiler that produced this compiland (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_editAndContinueEnabled](../VS_debugger/IDiaSymbol--get_editAndContinueEnabled.md)|`BOOL`|`TRUE` if Edit and Continue were enabled at compilation.|  
|[IDiaSymbol::get_frontEndBuild](../VS_debugger/IDiaSymbol--get_frontEndBuild.md)|`DWORD`|Front-end build number of the compiler.|  
|[IDiaSymbol::get_frontEndMajor](../VS_debugger/IDiaSymbol--get_frontEndMajor.md)|`DWORD`|Front-end major version number of the compiler.|  
|[IDiaSymbol::get_frontEndMinor](../VS_debugger/IDiaSymbol--get_frontEndMinor.md)|`DWORD`|Front-end minor version number of the compiler.|  
|[IDiaSymbol::get_hasDebugInfo](../VS_debugger/IDiaSymbol--get_hasDebugInfo.md)|`BOOL`|`TRUE` if this compiland has debug information (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasManagedCode](../VS_debugger/IDiaSymbol--get_hasManagedCode.md)|`BOOL`|`TRUE` if this compiland contains managed code (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_hasSecurityChecks](../VS_debugger/IDiaSymbol--get_hasSecurityChecks.md)|`BOOL`|`TRUE` if the compiland was compiled with the [/GS (Buffer Security Check)](../Topic/-GS%20\(Buffer%20Security%20Check\).md) compiler switch (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_isCVTCIL](../VS_debugger/IDiaSymbol--get_isCVTCIL.md)|`BOOL`|`TRUE` if compiland was converted from Common Intermediate Language (CIL) code to native code.|  
|[IDiaSymbol::get_isDataAligned](../VS_debugger/IDiaSymbol--get_isDataAligned.md)|`BOOL`|`TRUE` if user-defined types (UDT) have been aligned to some specified memory boundary (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_isHotpatchable](../VS_debugger/IDiaSymbol--get_isHotpatchable.md)|`BOOL`|`TRUE` if compiland was compiled with the [/hotpatch (Create Hotpatchable Image)](../Topic/-hotpatch%20\(Create%20Hotpatchable%20Image\).md) compiler switch (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_isLTCG](../VS_debugger/IDiaSymbol--get_isLTCG.md)|`BOOL`|`TRUE` if compiland was compiled with the [/LTCG (Link-time Code Generation)](../Topic/-LTCG%20\(Link-time%20Code%20Generation\).md) compiler switch (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_isMSILNetmodule](../VS_debugger/IDiaSymbol--get_isMSILNetmodule.md)|`BOOL`|TRUE if compiland is a Microsoft Intermediate Language (MSIL) module (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_language](../VS_debugger/IDiaSymbol--get_language.md)|`DWORD`|Source code language.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol for the compiland.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_platform](../VS_debugger/IDiaSymbol--get_platform.md)|`DWORD`|Platform on which the compiland was compiled (one of the [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md) values).|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagCompilandDetails` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
  
## Remarks  
 Compilers often come in a form known as a two-pass compiler; in some compiler versions, each pass is handled by a separate program. These are known as front-end and back-end compilers, respectively, hence the symbol properties for back-end and front-end version numbers.  
  
## See Also  
 [Compiland](../VS_debugger/Compiland.md)   
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)