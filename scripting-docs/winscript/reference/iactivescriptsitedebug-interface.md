---
title: "IActiveScriptSiteDebug Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptSiteDebug interface"
ms.assetid: 2557ee09-688b-4c03-a821-180c24dfa0e6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebug Interface
Smart hosts implement the `IActiveScriptSiteDebug` interface to perform document management and to participate in debugging. The `IActiveScriptSite` object typically provides an implementation of the `IActiveScriptSiteDebug` interface. If this is done, call the `IActiveScriptSite::QueryInterface` method to obtain the `IActiveScriptSiteDebug` interface.  
  
 In addition to the methods inherited from `IUnknown`, the `IActiveScriptSiteDebug` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptSiteDebug::GetDocumentContextFromPosition](../../winscript/reference/iactivescriptsitedebug-getdocumentcontextfromposition.md)|Used by the language engine to delegate `IDebugCodeContext::GetSourceContext`.|  
|[IActiveScriptSiteDebug::GetApplication](../../winscript/reference/iactivescriptsitedebug-getapplication.md)|Returns the debug application object associated with this script site.|  
|[IActiveScriptSiteDebug::GetRootApplicationNode](../../winscript/reference/iactivescriptsitedebug-getrootapplicationnode.md)|Gets the application node under which script documents should be added.|  
|[IActiveScriptSiteDebug::OnScriptErrorDebug](../../winscript/reference/iactivescriptsitedebug-onscripterrordebug.md)|Allows a smart host to determine how to handle run-time errors.|