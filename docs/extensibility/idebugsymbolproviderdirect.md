---
title: "IDebugSymbolProviderDirect"
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
  - "IDebugSymbolProviderDirect interface"
ms.assetid: 872b04a8-70de-4ab5-aceb-684c81828545
caps.latest.revision: 6
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
# IDebugSymbolProviderDirect
Represents a symbol provider that has direct access to metadata and core symbol interfaces.  
  
## Syntax  
  
```  
IDebugSymbolProviderDirect: IUnknown  
```  
  
## Methods  
 This interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetAppIDFromAddress](../extensibility/idebugsymbolproviderdirect--getappidfromaddress.md)|Retrieves the application domain identifier given the debug address.|  
|[GetCurrentModulesInfo](../extensibility/idebugsymbolproviderdirect--getcurrentmodulesinfo.md)|Retrieves information about the modules in the symbol group.|  
|[GetCurrentModulesState](../extensibility/idebugsymbolproviderdirect--getcurrentmodulesstate.md)|Retrieves information about the symbol group of which the symbol provider is a member.|  
|[GetMetaDataImport](../extensibility/idebugsymbolproviderdirect--getmetadataimport.md)|Retrieves the metadata import information.|  
|[GetMethodFromAddress](../extensibility/idebugsymbolproviderdirect--getmethodfromaddress.md)|Retrieves information about the method at the specified debug address.|  
|[GetSymUnmanagedReader](../extensibility/idebugsymbolproviderdirect--getsymunmanagedreader.md)|Retrieves a symbol reader for unmanaged code.|  
  
## Remarks  
 This interface can be used instead of most of the other symbol provider interfaces. It provides direct access to the metadata and `CorSym` interfaces.  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll