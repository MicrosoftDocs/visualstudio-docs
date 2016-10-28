---
title: "IDebugComPlusSymbolProvider"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugComPlusSymbolProvider interface"
ms.assetid: 5b98e908-fd15-49a6-9010-933c9b948085
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugComPlusSymbolProvider
Represents a COM+ symbol provider with methods that are specific to managed code.  
  
## Syntax  
  
```  
IDebugComPlusSymbolProvider : IDebugSymbolProvider  
```  
  
## Notes for Implementers  
 Although there is no separation between interfaces that are useful to an expression evaluator (EE) and those that are intended to be used by a debug engine (DE), the following methods will probably interest DE developers only: AreSymbolsLoaded, GetAddressesInModuleFromPosition, GetEntryPoint, GetFunctionLineOffset, GetLocalVariableLayout, IsFunctionStale, LoadSymbols, LoadSymbolsFromStream, ReplaceSymbols, UnloadSymbols, and UpdateSymbols.  
  
## Methods  
 In addition to the methods on the [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[AreSymbolsLoaded](../extensibility/idebugcomplussymbolprovider--aresymbolsloaded.md)|Determines if the debug symbols are loaded for the specified module given the application domain identifier.|  
|[CreateTypeFromPrimitive](../extensibility/idebugcomplussymbolprovider--createtypefromprimitive.md)|Creates a type from the specified primitive type.|  
|[GetAddressesInModuleFromPosition](../extensibility/idebugcomplussymbolprovider--getaddressesinmodulefromposition.md)|Maps a document position in the specified module to an array of debug addresses.|  
|[GetArrayTypeFromAddress](../extensibility/idebugcomplussymbolprovider--getarraytypefromaddress.md)|Retrieves type information about the specified array given its debug address.|  
|[GetAssemblyName](../extensibility/idebugcomplussymbolprovider--getassemblyname.md)|Retrieves the name of the assembly given its module and application domain.|  
|[GetAttributedClassesForLanguage](../extensibility/idebugcomplussymbolprovider--getattributedclassesforlanguage.md)|Retrieves the classes with the specified attribute that are implemented in the given programming language.|  
|[GetAttributedClassesinModule](../extensibility/idebugcomplussymbolprovider--getattributedclassesinmodule.md)|Retrieves the classes with the specified attribute in a given module.|  
|[GetEntryPoint](../extensibility/idebugcomplussymbolprovider--getentrypoint.md)|Retrieves the application entry point.|  
|[GetFunctionLineOffset](../extensibility/idebugcomplussymbolprovider--getfunctionlineoffset.md)|Retrieves the address within a function that represents the given line offset.|  
|[GetLocalVariablelayout](../extensibility/idebugcomplussymbolprovider--getlocalvariablelayout.md)|Retrieves the layout of local variables for a set of methods.|  
|[GetNameFromToken](../extensibility/idebugcomplussymbolprovider--getnamefromtoken.md)|Returns the name associated with the specified token given its metadata object.|  
|[GetSymAttribute](../extensibility/idebugcomplussymbolprovider--getsymattribute.md)|Retrieves the debug symbols with the given parent attribute for the specified module.|  
|[GetSymUnmanagedReader](../extensibility/idebugcomplussymbolprovider--getsymunmanagedreader.md)|Retrieves the symbol reader to be used by unmanaged code.|  
|[GetTypeFromAddress](../extensibility/idebugcomplussymbolprovider--gettypefromaddress.md)|Retrieves to a symbol type given its debug address.|  
|[IsFunctionDeleted](../extensibility/idebugcomplussymbolprovider--isfunctiondeleted.md)|Determines if the function at the specified debug address is deleted.|  
|[IsFunctionStale](../extensibility/idebugcomplussymbolprovider--isfunctionstale.md)|Determines if the function at the specified debug address is considered stale.|  
|[IsHiddenCode](../extensibility/idebugcomplussymbolprovider--ishiddencode.md)|Determines if the code at the specified debugger address is hidden.|  
|[LoadSymbols](../extensibility/idebugcomplussymbolprovider--loadsymbols.md)|Loads the specified debug symbols in memory.|  
|[LoadSymbolsFromStream](../extensibility/idebugcomplussymbolprovider--loadsymbolsfromstream.md)|Loads debug symbols given the data stream.|  
|[ReplaceSymbols](../extensibility/idebugcomplussymbolprovider--replacesymbols.md)|Replaces the current debug symbols with those in the specified data stream.|  
|[UnloadSymbols](../extensibility/idebugcomplussymbolprovider--unloadsymbols.md)|Unloads the debug symbols for the specified module from memory.|  
|[UpdateSymbols](../extensibility/idebugcomplussymbolprovider--updatesymbols.md)|Updates the debug symbols in memory with those the specified data stream.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll