---
title: "IDebugSessionProviderEx:StartDebugSession | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSessionProviderEx:StartDebugSession"
apilocation: 
  - "scrobj.dll"
ms.assetid: 247337ca-476c-4aa7-8500-d84fd1d98176
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSessionProviderEx:StartDebugSession
Initiates a debug session with the specified application.  
  
## Syntax  
  
```cpp
HRESULT StartDebugSession(  
   IRemoteDebugApplication*  pda  
   BOOL  fQuery  
);  
```  
  
#### Parameters  
 `pda`  
 [in] Specifies the debug application.  
  
 `fQuery`  
 [in] True indicates a query.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method initiates a debug session with the specified application. The debugger should call `IRemoteDebugApplication::ConnectDebugger` before returning from this call.  
  
## See also  
 [IDebugSessionProviderEx Interface](../../winscript/reference/idebugsessionproviderex-interface.md)   
 [IRemoteDebugApplication::ConnectDebugger](../../winscript/reference/iremotedebugapplication-connectdebugger.md)