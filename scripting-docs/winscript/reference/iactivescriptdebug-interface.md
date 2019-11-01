---
title: "IActiveScriptDebug Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptDebug interface"
ms.assetid: e3e28cba-ee08-4a52-973a-b74be488c348
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptDebug Interface
Implemented by script engines that support debugging. Typically, an object that implements the `IActiveScriptDebug` interface also implements the `IActiveScript` interface. If this is the case, call the `IActiveScript::QueryInterface` method to obtain the `IActiveScriptDebug` interface.  
  
 The `IActiveScriptDebug` interface provides the means for:  
  
- Smart hosts to take over document management.  
  
- Process debug manager to synchronize debugging of multiple script engines.  
  
  In addition to the methods inherited from `IUnknown`, the `IActiveScriptDebug` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptDebug::GetScriptTextAttributes](../../winscript/reference/iactivescriptdebug-getscripttextattributes.md)|Returns the text attributes for an arbitrary block of script text.|  
|[IActiveScriptDebug::GetScriptletTextAttributes](../../winscript/reference/iactivescriptdebug-getscriptlettextattributes.md)|Returns the text attributes for an arbitrary scriptlet.|  
|[IActiveScriptDebug::EnumCodeContextsOfPosition](../../winscript/reference/iactivescriptdebug-enumcodecontextsofposition.md)|Delegates to `IDebugDocumentContext::EnumCodeContexts`.|