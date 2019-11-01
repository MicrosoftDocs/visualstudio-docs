---
title: "IActiveScriptParseProcedureOld Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptParseProcedureOld"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptParseProcedureOld interface"
ms.assetid: d94b391e-4c24-46da-a01f-2c134ca4f041
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptParseProcedureOld Interface
Allows the source code text for procedures to be added to the script. For interpreted scripting languages that do not have an independent authoring environment, such as VBScript, this provides an alternative mechanism (other than `IActiveScriptParse` or `IPersist*`) to add script procedures to the name space.  
  
> [!NOTE]
> This interface is deprecated in favor of the `IActiveScriptParseProcedure` interface.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IActiveScriptParseProcedureOld` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptParseProcedureOld::ParseProcedureText](../../winscript/reference/iactivescriptparseprocedureold-parseproceduretext.md)|Parses the given code procedure and adds the procedure to the name space.|  
  
## See also  
 [IActiveScriptParseProcedure](../../winscript/reference/iactivescriptparseprocedure.md)