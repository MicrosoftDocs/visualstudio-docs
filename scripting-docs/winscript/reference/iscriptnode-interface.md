---
title: "IScriptNode Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IScriptNode interface"
ms.assetid: cfa76c4a-6543-48e8-a946-d212cd0bf934
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode Interface
An object that implements the `IScriptNode` interface represents a Web page.  
  
 In addition to the methods inherited from `IUnknown`, the `IScriptNode` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IScriptNode::Alive](../../winscript/reference/iscriptnode-alive.md)|Indicates whether an object is still active.|  
|[IScriptNode:: CreateChildEntry](../../winscript/reference/iscriptnode-createchildentry.md)|Adds a child instance of `IScriptEntry`.|  
|[IScriptNode::CreateChildHandler](../../winscript/reference/iscriptnode-createchildhandler.md)|Adds a scriptlet as a child instance of an `IScriptNode`.|  
|[IScriptNode::Delete](../../winscript/reference/iscriptnode-delete.md)|Deletes the object tree.|  
|[IScriptNode::GetChild](../../winscript/reference/iscriptnode-getchild.md)|Returns the child that is at the specified index in the node.|  
|[IScriptNode::GetCookie](../../winscript/reference/iscriptnode-getcookie.md)|Returns an application-defined value that is used to associate a scriptlet with the host object.|  
|[IScriptNode::GetIndexInParent](../../winscript/reference/iscriptnode-getindexinparent.md)|Returns the index of an object in the parent's child list.|  
|[IScriptNode::GetLanguage](../../winscript/reference/iscriptnode-getlanguage.md)|Returns the scripting language that is used by the current script node.|  
|[IScriptNode::GetNumberOfChildren](../../winscript/reference/iscriptnode-getnumberofchildren.md)|Returns the number of child nodes of the `IScriptNode` object.|  
|[IScriptNode::GetParent](../../winscript/reference/iscriptnode-getparent.md)|Returns the `IScriptNode` object that is the parent of an object.|  
  
## See also  
 [Active Script Authoring Interfaces](../../winscript/reference/active-script-authoring-interfaces.md)