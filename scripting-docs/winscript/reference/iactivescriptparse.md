---
title: "IActiveScriptParse | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptParse interface"
ms.assetid: 8c967d70-f582-4f64-9e79-49f40c4dcb7c
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParse
If the Windows Script engine allows raw text code scriptlets to be added to the script or allows expression text to be evaluated at run time, it implements the `IActiveScriptParse` interface. For interpreted scripting languages that have no independent authoring environment, such as VBScript, this provides an alternate mechanism (other than `IPersist*`) to get script code into the scripting engine, and to attach script fragments to various object events.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptParse::InitNew](../../winscript/reference/iactivescriptparse-initnew.md)|Initializes the scripting engine.|  
|[IActiveScriptParse::AddScriptlet](../../winscript/reference/iactivescriptparse-addscriptlet.md)|Adds a code scriptlet to the script.|  
|[IActiveScriptParse::ParseScriptText](../../winscript/reference/iactivescriptparse-parsescripttext.md)|Parses the given code scriptlet, adding declarations into the name space and evaluating code as appropriate.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)