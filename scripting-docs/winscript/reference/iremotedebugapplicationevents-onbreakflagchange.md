---
title: "IRemoteDebugApplicationEvents::OnBreakFlagChange | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnBreakFlagChange"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnBreakFlagChange"
ms.assetid: 25684454-a0d8-47e0-85f5-2217069a9f45
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnBreakFlagChange
Handles an event when the break flags change.  
  
## Syntax  
  
```cpp
HRESULT OnBreakFlagChange(  
   APPBREAKFLAGS                   abf,  
   IRemoteDebugApplicationThread*  prdatSteppingThread  
);  
```  
  
#### Parameters  
 `abf`  
 [in] The current break flags for the application.  
  
 `prdatSteppingThread`  
 [in] The currently running thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the event when the break flag change.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)   
 [APPBREAKFLAGS Enumeration](../../winscript/reference/appbreakflags-enumeration.md)