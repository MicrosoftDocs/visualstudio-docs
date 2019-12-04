---
title: "IMachineDebugManagerCookie Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IMachineDebugManagerCookie interface"
ms.assetid: 04770935-3ccf-41e9-b0c1-c78376ab1e3c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManagerCookie Interface
Similar to the `IMachineDebugManager` interface, the `IMachineDebugManagerCookie` interface supports debug cookies.  
  
 This interface (along with the `IDebugCookie` interface) allow scripts to run in a script debugger process without requiring that the debugger keep track of those scripts.  
  
 A script debugger calls the `IDebugCookie::SetDebugCookie` method on the Process Debug Manager (PDM). Then, the PDM sends this cookie along with any request to add or remove a script application to or from the Machine Debug Manager (MDM), using the methods of the `IMachineDebugManagerCookie` interface. The MDM then notifies every debugger of the change, except for the one that has that cookie.  
  
 In addition to the methods inherited from `IUnknown`, the `IMachineDebugManagerCookie` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IMachineDebugManagerCookie::AddApplication](../../winscript/reference/imachinedebugmanagercookie-addapplication.md)|Adds an application to the running application list.|  
|[IMachineDebugManagerCookie::EnumApplications](../../winscript/reference/imachinedebugmanagercookie-enumapplications.md)|Returns an enumerator of the current list of running applications.|  
|[IMachineDebugManagerCookie::RemoveApplication](../../winscript/reference/imachinedebugmanagercookie-removeapplication.md)|Removes an application from the running application list.|  
  
## See also  
 [IMachineDebugManager Interface](../../winscript/reference/imachinedebugmanager-interface.md)   
 [IDebugCookie Interface](../../winscript/reference/idebugcookie-interface.md)