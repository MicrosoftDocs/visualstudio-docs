---
title: "IScriptEntry Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IScriptEntry interface"
ms.assetid: 86da3bc1-58b7-4d73-87ab-bc3ce34e3f41
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry Interface
An object that implements the `IScriptEntry` interface represents either a script block or a function object.  
  
 In addition to the methods inherited from `IScriptNode`, the `IScriptEntry` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IScriptEntry::GetBody](../../winscript/reference/iscriptentry-getbody.md)|Returns the text that corresponds to the body of an `IScriptEntry` script block, function block, or scriptlet.|  
|[IScriptEntry::GetItemName](../../winscript/reference/iscriptentry-getitemname.md)|Returns the item name that identifies an `IScriptEntry` object.|  
|[IScriptEntry::GetName](../../winscript/reference/iscriptentry-getname.md)|For entries that represent a single object (such as a function), returns the name of the object.|  
|[IScriptEntry::GetRange](../../winscript/reference/iscriptentry-getrange.md)|Returns the start position and length of an entry.|  
|[IScriptEntry::GetSignature](../../winscript/reference/iscriptentry-getsignature.md)|Returns type information for an `IScriptEntry` function object.|  
|[IScriptEntry::GetText](../../winscript/reference/iscriptentry-gettext.md)|Returns the text that corresponds to an `IScriptEntry` script block, or the source code that is contained in an `IScriptScriptlet` event handler.|  
|[IScriptEntry::SetBody](../../winscript/reference/iscriptentry-setbody.md)|Sets the text that is in the body of an `IScriptEntry` script block or an `IScriptScriptlet` scriptlet.|  
|[IScriptEntry::SetItemName](../../winscript/reference/iscriptentry-setitemname.md)|Sets the item name that identifies an `IScriptEntry` object.|  
|[IScriptEntry::SetName](../../winscript/reference/iscriptentry-setname.md)|For entries that represent a single object (such as a function), sets the name of the object.|  
|[IScriptEntry::SetSignature](../../winscript/reference/iscriptentry-setsignature.md)|Sets type information for an `IScriptEntry` function object.|  
|[IScriptEntry::SetText](../../winscript/reference/iscriptentry-settext.md)|Sets the text that corresponds to an `IScriptEntry` script block, or the source code that is contained in an `IScriptScriptlet` event handler.|  
  
## See also  
 [Active Script Authoring Interfaces](../../winscript/reference/active-script-authoring-interfaces.md)