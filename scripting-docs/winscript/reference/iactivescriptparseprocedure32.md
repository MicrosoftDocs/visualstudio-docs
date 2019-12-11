---
title: "IActiveScriptParseProcedure32 | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 387a856b-f5dc-4371-8620-bd574e046c2c
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptParseProcedure32
If the Windows Script engine allows the source code text for procedures to be added to the script, it implements the `IActiveScriptParseProcedure32` interface. For interpreted scripting languages that have no independent authoring environment, such as VBScript, this provides an alternate mechanism (other than `IActiveScriptParse32` or `IPersist`*) to add script procedures to the namespace.  
  
## Methods in Vtable Order  
  
|||  
|-|-|  
|Method|Description|  
|[IActiveScriptParseProcedure32::ParseProcedureText](../../winscript/reference/iactivescriptparseprocedure32-parseproceduretext.md)|Parses the given code procedure and adds the procedure to the namespace.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)