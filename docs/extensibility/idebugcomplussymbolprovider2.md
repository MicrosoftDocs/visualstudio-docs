---
title: "IDebugComPlusSymbolProvider2"
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
  - "IDebugComPlusSymbolProvider2 interface"
ms.assetid: fa2f9b49-03ad-43c7-92d6-6dcb9c3d0531
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
# IDebugComPlusSymbolProvider2
Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**[IDebugComPlusSymbolProvider](../extensibility/idebugcomplussymbolprovider.md).  
  
## Syntax  
  
```  
IDebugComPlusSymbolProvider2 : IDebugComPlusSymbolProvider  
```  
  
## Methods  
 In addition to the methods on the [IDebugComPlusSymbolProvider](../extensibility/idebugcomplussymbolprovider.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[FunctionHasLineInfo](../extensibility/idebugcomplussymbolprovider2--functionhaslineinfo.md)|Determines if the specified method has line information.|  
|[GetTypesByName](../extensibility/idebugcomplussymbolprovider2--gettypesbyname.md)|Retrieves a type given its name.|  
|[GetTypeFromToken](../extensibility/idebugcomplussymbolprovider2--gettypefromtoken.md)|Retrieves a type given its token.|  
|[IsAddressSequencePoint](../extensibility/idebugcomplussymbolprovider2--isaddresssequencepoint.md)|Determines if the specified debug address is a sequence point.|  
|[LoadSymbolsFromCallback](../extensibility/idebugcomplussymbolprovider2--loadsymbolsfromcallback.md)|Loads debug symbols using the specified callback method.|  
|[LoadSymbolsFromStreamWithCorModule](../extensibility/idebugcomplussymbolprovider2--loadsymbolsfromstreamwithcormodule.md)|Load debug symbols from a data stream given the **ICorDebugModule** object.|  
|[LoadSymbolsWithCorModule](../extensibility/idebugcomplussymbolprovider2--loadsymbolswithcormodule.md)|Loads debug symbols given the **ICorDebugModule** object.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll