---
title: "IScriptScriptlet Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IScriptScriptlet interface"
ms.assetid: b9981908-a337-4228-864c-c741f111ab2d
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet Interface
An object that implements the `IScriptScriptlet` interface represents an event handler script.  
  
 In addition to the methods inherited from `IScriptEntry`, the `IScriptScriptlet` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IScriptScriptlet::GetEventName](../../winscript/reference/iscriptscriptlet-geteventname.md)|Returns the name of the event that is associated with the scriptlet.|  
|[IScriptScriptlet:: GetSimpleEventName](../../winscript/reference/iscriptscriptlet-getsimpleeventname.md)|Returns the simple event name that is associated with a scriptlet. This is a single-word name that does not contain any white space.|  
|[IScriptScriptlet::GetSubItemName](../../winscript/reference/iscriptscriptlet-getsubitemname.md)|Returns the last identifier in the fully qualified name of a scriptlet's object host.|  
|[IScriptScriptlet::SetEventName](../../winscript/reference/iscriptscriptlet-seteventname.md)|Sets the name of the event that is associated with the scriptlet.|  
|[IScriptScriptlet::SetSimpleEventName](../../winscript/reference/iscriptscriptlet-setsimpleeventname.md)|Sets the simple event name that is associated with a scriptlet. This is a single-word name that does not contain any white space.|  
|[IScriptScriptlet::SetSubItemName](../../winscript/reference/iscriptscriptlet-setsubitemname.md)|Sets the last identifier in the fully qualified name of a scriptlet's object host.|  
  
## See also  
 [Active Script Authoring Interfaces](../../winscript/reference/active-script-authoring-interfaces.md)