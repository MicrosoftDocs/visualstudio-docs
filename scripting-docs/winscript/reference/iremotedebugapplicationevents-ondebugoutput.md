---
title: "IRemoteDebugApplicationEvents::OnDebugOutput | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEvents.OnDebugOutput"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEvents::OnDebugOutput"
ms.assetid: db08872e-3d84-4d7f-bf94-a851bf43a333
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEvents::OnDebugOutput
Handles a debugger output event.  
  
## Syntax  
  
```cpp
HRESULT OnDebugOutput(  
   LPCOLESTR  pstr  
);  
```  
  
#### Parameters  
 `pstr`  
 [in] The debug output string.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the debugger output event.  
  
## See also  
 [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md)