---
title: "IActiveScriptParse32 | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c39c14aa-beb7-4eca-8b8c-2181da1c2e3e
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptParse32
If the Windows Script engine allows raw text code scriptlets to be added to the script or allows expression text to be evaluated at run time, it implements the `IActiveScriptParse32` interface. For interpreted scripting languages that have no independent authoring environment, such as VBScript, this provides an alternate mechanism (other than `IPersist*`) to get script code into the scripting engine, and to attach script fragments to various object events.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptParse32::AddScriptlet](../../winscript/reference/iactivescriptparse32-addscriptlet.md)|Adds a code scriptlet to the script.|  
|[IActiveScriptParse32::InitNew](../../winscript/reference/iactivescriptparse32-initnew.md)|Initializes the scripting engine.|  
|[IActiveScriptParse32::ParseScriptText](../../winscript/reference/iactivescriptparse32-parsescripttext.md)|Parses the given code scriptlet, adding declarations into the name space and evaluating code as appropriate.|