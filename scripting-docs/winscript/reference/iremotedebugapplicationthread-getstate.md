---
title: "IRemoteDebugApplicationThread::GetState | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThread.GetState"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThread::GetState"
ms.assetid: 44503a78-efa9-4fbf-98be-a5dcfa329c5a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThread::GetState
Gets the state of this thread.  
  
## Syntax  
  
```cpp
HRESULT GetState(  
   DWORD*  pState  
);  
```  
  
#### Parameters  
 `pState`  
 [out] Combination of the following thread state flags:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|THREAD_STATE_RUNNING|0x00000001|The thread is running.|  
|THREAD_STATE_SUSPENDED|0x00000002|The thread is suspended.|  
|THREAD_BLOCKED|0x00000004|The thread is blocked.|  
|THREAD_OUT_OF_CONTEXT|0x00000008|The thread is out of content.|  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method gets the state of this thread.  
  
## See also  
 [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md)