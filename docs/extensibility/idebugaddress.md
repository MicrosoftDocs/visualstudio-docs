---
title: "IDebugAddress"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugAddress"
helpviewer_keywords: 
  - "IDebugAddress interface"
ms.assetid: bc709ff7-4966-4f36-9af2-690efe2cea1d
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
# IDebugAddress
This interface represents the address of an item. It is returned by the symbol handler.  
  
## Syntax  
  
```  
IDebugAddress : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to represent an address of an object.  
  
## Notes for Callers  
 Many methods on many interfaces return this interface.  
  
## Methods in Vtable Order  
 This interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[GetAddress](../extensibility/idebugaddress--getaddress.md)|Retrieves a [DEBUG_ADDRESS](../extensibility/debug_address.md) structure describing an object and its location.|  
  
## Remarks  
 The symbol provider returns this interface to represent an object and its location within a particular scope (for example, function, method, or class). This interface is returned from and passed to various methods of the symbol provider and expression evaluator. Normally, the symbol provider is the only entity that needs to interpret the contents of this interface.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [DEBUG_ADDRESS](../extensibility/debug_address.md)