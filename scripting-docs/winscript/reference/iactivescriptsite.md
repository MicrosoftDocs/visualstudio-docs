---
title: "IActiveScriptSite | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptSite interface"
ms.assetid: 4d604a11-5365-46cf-ab71-39b3dbbe9f22
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite
Implemented by the host to create a site for the Windows Script engine. Usually, this site will be associated with the container of all the objects that are visible to the script (for example, the ActiveX Controls). Typically, this container will correspond to the document or page being viewed. Microsoft Internet Explorer, for example, would create such a container for each HTML page being displayed. Each ActiveX control (or other automation object) on the page, and the scripting engine itself, would be enumerable within this container.  
  
## Methods in Vtable Order  
  
|||  
|-|-|  
|Method|Description|  
|[IActiveScriptSite::GetLCID](../../winscript/reference/iactivescriptsite-getlcid.md)|Retrieves the locale identifier that the host uses for displaying user-interface elements.|  
|[IActiveScriptSite::GetItemInfo](../../winscript/reference/iactivescriptsite-getiteminfo.md)|Obtains information about an item that was added to an engine through a call to the [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) method.|  
|[IActiveScriptSite::GetDocVersionString](../../winscript/reference/iactivescriptsite-getdocversionstring.md)|Retrieves a host-defined string that uniquely identifies the current document version from the host's point of view.|  
|[IActiveScriptSite::OnScriptTerminate](../../winscript/reference/iactivescriptsite-onscriptterminate.md)|Called when the script has completed execution.|  
|[IActiveScriptSite::OnStateChange](../../winscript/reference/iactivescriptsite-onstatechange.md)|Informs the host that the scripting engine has changed states.|  
|[IActiveScriptSite::OnScriptError](../../winscript/reference/iactivescriptsite-onscripterror.md)|Informs the host that an execution error occurred while the engine was running the script.|  
|[IActiveScriptSite::OnEnterScript](../../winscript/reference/iactivescriptsite-onenterscript.md)|Informs the host that the scripting engine has begun executing the script code.|  
|[IActiveScriptSite::OnLeaveScript](../../winscript/reference/iactivescriptsite-onleavescript.md)|Informs the host that the scripting engine has returned from executing script code.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)