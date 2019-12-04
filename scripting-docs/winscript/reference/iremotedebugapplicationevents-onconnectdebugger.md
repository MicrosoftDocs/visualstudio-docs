---
title: "IRemoteDebugApplicationEvents::OnConnectDebugger | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnConnectDebugger"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnConnectDebugger"
ms.assetid: 8c9c19b8-5426-4643-83e6-b68803ff69c4
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnConnectDebugger
Handles a debugger connect event.  
  
## Syntax  
  
```cpp
HRESULT OnConnectDebugger(  
   IApplicationDebugger*  pad  
);  
```  
  
#### Parameters  
 `pad`  
 [in] The newly connected debugger.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the debugger connect event.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)