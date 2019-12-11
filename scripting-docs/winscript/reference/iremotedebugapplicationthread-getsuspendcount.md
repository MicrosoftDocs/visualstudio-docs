---
title: "IRemoteDebugApplicationThread::GetSuspendCount | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThread.GetSuspendCount"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThread::GetSuspendCount"
ms.assetid: 37f9936c-fd7c-412d-9a7f-628ca3a90438
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThread::GetSuspendCount
Returns the suspend count for the thread.  
  
## Syntax  
  
```cpp
HRESULT GetSuspendCount(  
   DWORD*  pdwCount  
);  
```  
  
#### Parameters  
 `pdwCount`  
 [out] The suspend count for the thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the suspend count for the thread.  
  
## See also  
 [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md)