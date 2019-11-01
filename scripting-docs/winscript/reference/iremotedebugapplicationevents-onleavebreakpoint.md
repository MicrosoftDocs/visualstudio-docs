---
title: "IRemoteDebugApplicationEvents::OnLeaveBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnLeaveBreakPoint"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnLeaveBreakPoint"
ms.assetid: 00449a23-1f67-4078-ad06-4c426abf7587
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnLeaveBreakPoint
Handles an event for leaving a breakpoint.  
  
## Syntax  
  
```cpp
HRESULT OnLeaveBreakPoint(  
   IRemoteDebugApplicationThread*  prdat  
);  
```  
  
#### Parameters  
 `prdat`  
 [in] The application thread that left the breakpoint.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles an event for leaving a breakpoint.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)