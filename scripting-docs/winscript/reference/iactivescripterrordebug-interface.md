---
title: "IActiveScriptErrorDebug Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptErrorDebug interface"
ms.assetid: e5d50427-c033-4138-ac6e-3b2dfb3b750a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptErrorDebug Interface
Provides document context information for compile-time errors and run-time exceptions. The `IActiveScriptError::QueryInterface` method supports the `IActiveScriptErrorDebug` interface.  
  
 In addition to the methods inherited from `IActiveScriptError`, the `IActiveScriptErrorDebug` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptErrorDebug::GetDocumentContext](../../winscript/reference/iactivescripterrordebug-getdocumentcontext.md)|Provides the document context for this error.|  
|[IActiveScriptErrorDebug::GetStackFrame](../../winscript/reference/iactivescripterrordebug-getstackframe.md)|Provides the stack frame that is in effect for runtime errors.|