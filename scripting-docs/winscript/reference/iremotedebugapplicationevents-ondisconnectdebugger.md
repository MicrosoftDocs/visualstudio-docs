---
title: "IRemoteDebugApplicationEvents::OnDisconnectDebugger | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnDisconnectDebugger"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnDisconnectDebugger"
ms.assetid: ea11cde0-1484-4181-a5dd-a1f6cf788892
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnDisconnectDebugger
Handles a debugger disconnect event.  
  
## Syntax  
  
```cpp
HRESULT OnDisconnectDebugger();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the debugger disconnect event.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)