---
title: "IActiveScriptSiteDebug32 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 03f42217-303d-46e7-9792-61a5ab95252c
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptSiteDebug32 Interface
Smart hosts implement the `IActiveScriptSiteDebug32` interface to perform document management and to participate in debugging. The `IActiveScriptSite` object typically provides an implementation of the `IActiveScriptSiteDebug32` interface. If this is done, call the `IActiveScriptSite::QueryInterface` method to obtain the `IActiveScriptSiteDebug32` interface.  
  
 In addition to the methods inherited from `IUnknown`, the `IActiveScriptSiteDebug32` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptSiteDebug32::GetApplication](../../winscript/reference/iactivescriptsitedebug32-getapplication.md)|Returns the debug application object associated with this script site.|  
|[IActiveScriptSiteDebug32::GetDocumentContextFromPosition](../../winscript/reference/iactivescriptsitedebug32-getdocumentcontextfromposition.md)|Used by the language engine to delegate `IDebugCodeContext::GetSourceContext`.|