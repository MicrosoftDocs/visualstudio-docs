---
title: "IActiveScriptParseProcedure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptParseProcedure interface"
ms.assetid: 741a35bb-5b92-489e-ba8a-a406b42125fc
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParseProcedure
If the Windows Script engine allows the source code text for procedures to be added to the script, it implements the `IActiveScriptParseProcedure` interface. For interpreted scripting languages that have no independent authoring environment, such as VBScript, this provides an alternate mechanism (other than `IActiveScriptParse` or `IPersist`*) to add script procedures to the namespace.  
  
## Methods in Vtable Order  
  
|||  
|-|-|  
|Method|Description|  
|[IActiveScriptParseProcedure::ParseProcedureText](../../winscript/reference/iactivescriptparseprocedure-parseproceduretext.md)|Parses the given code procedure and adds the procedure to the namespace.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)