---
title: "IRemoteDebugApplication::ConnectDebugger | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.ConnectDebugger"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::ConnectDebugger"
ms.assetid: ded94101-7efe-466f-aa70-b3e30a38c4d8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::ConnectDebugger
Connects a debugger to this application.  
  
## Syntax  
  
```cpp
HRESULT ConnectDebugger(  
   IApplicationDebugger*  pad  
);  
```  
  
#### Parameters  
 `pad`  
 [in] The debugger to attach to this application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|A debugger is already connected to this application.|  
  
## Remarks  
 An application can have only one debugger connected at a time. This method fails if a debugger is already connected.  
  
## See also  
 [IRemoteDebugApplication::GetDebugger](../../winscript/reference/iremotedebugapplication-getdebugger.md)   
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)