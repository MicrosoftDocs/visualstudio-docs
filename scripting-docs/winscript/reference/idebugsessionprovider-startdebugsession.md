---
title: "IDebugSessionProvider::StartDebugSession | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSessionProvider.StartDebugSession"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugSessionProvider::StartDebugSession"
ms.assetid: 47697dfb-d4e1-492c-a14f-753e28195a76
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSessionProvider::StartDebugSession
Initiates a debug session with the specified application.  
  
## Syntax  
  
```cpp
HRESULT StartDebugSession(  
   IRemoteDebugApplication*  pda  
);  
```  
  
#### Parameters  
 `pda`  
 [in] Specifies the debug application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method initiates a debug session with the specified application. The debugger should call `IRemoteDebugApplication::ConnectDebugger` before returning from this call.  
  
## See also  
 [IDebugSessionProvider Interface](../../winscript/reference/idebugsessionprovider-interface.md)   
 [IRemoteDebugApplication::ConnectDebugger](../../winscript/reference/iremotedebugapplication-connectdebugger.md)