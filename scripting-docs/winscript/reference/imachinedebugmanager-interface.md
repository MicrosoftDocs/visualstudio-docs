---
title: "IMachineDebugManager Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IMachineDebugManager interface"
ms.assetid: 0b7133bb-5a52-4036-b4db-d69260790db7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IMachineDebugManager Interface
The primary interface to the Machine Debug Manager. This interface is similar to the `IMachineDebugManagerCookie` interface.  
  
 In addition to the methods inherited from `IUnknown`, the `IMachineDebugManager` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IMachineDebugManager::AddApplication](../../winscript/reference/imachinedebugmanager-addapplication.md)|Adds an application to the running application list.|  
|[IMachineDebugManager::RemoveApplication](../../winscript/reference/imachinedebugmanager-removeapplication.md)|Removes an application from the running application list.|  
|[IMachineDebugManager::EnumApplications](../../winscript/reference/imachinedebugmanager-enumapplications.md)|Returns an enumerator of the current list of running applications.|  
  
## See also  
 [IMachineDebugManagerCookie Interface](../../winscript/reference/imachinedebugmanagercookie-interface.md)