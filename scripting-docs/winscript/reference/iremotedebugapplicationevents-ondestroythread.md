---
title: "IRemoteDebugApplicationEvents::OnDestroyThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnDestroyThread"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnDestroyThread"
ms.assetid: 7c716ccc-7b82-41b2-9a16-d0366999dee8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnDestroyThread
Handles a thread-destroyed event.  
  
## Syntax  
  
```cpp
HRESULT OnDestroyThread(  
   IRemoteDebugApplicationThread*  prdat  
);  
```  
  
#### Parameters  
 `prdat`  
 [in] The thread that was destroyed.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the thread-destroyed event.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)