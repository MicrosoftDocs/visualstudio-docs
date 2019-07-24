---
title: "IEnumRemoteDebugApplications Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplications interface"
ms.assetid: ceb5fbe7-d131-4352-9dd1-af80acd3f3f7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplications Interface
Enumerates application objects. This interface can be used to enumerate the running applications on a machine for an "attach to application" dialog box.  
  
 In addition to the methods inherited from `IUnknown`, the `IEnumRemoteDebugApplications` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumRemoteDebugApplications::Clone](../../winscript/reference/ienumremotedebugapplications-clone.md)|Creates an enumerator that contains the same state as the current enumerator.|  
|[IEnumRemoteDebugApplications::Next](../../winscript/reference/ienumremotedebugapplications-next.md)|Retrieves a specified number of segments in an enumeration sequence.|  
|[IEnumRemoteDebugApplications::Reset](../../winscript/reference/ienumremotedebugapplications-reset.md)|Resets an enumeration sequence to the beginning.|  
|[IEnumRemoteDebugApplications::Skip](../../winscript/reference/ienumremotedebugapplications-skip.md)|Skips a specified number of segments in an enumeration sequence.|