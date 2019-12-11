---
title: "IRemoteDebugApplicationThread::SetNextStatement | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThread.SetNextStatement"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThread::SetNextStatement"
ms.assetid: 356766da-f7b7-4e8d-b4f3-2ab8da0609b8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThread::SetNextStatement
Forces execution to continue as close as possible to the given code context, in the context of the given frame.  
  
## Syntax  
  
```cpp
HRESULT SetNextStatement(  
   IDebugStackFrame*   pStackFrame,  
   IDebugCodeContext*  pCodeContext  
);  
```  
  
#### Parameters  
 `pStackFrame`  
 [in] The stack frame object. This argument may be NULL, which implies the current stack frame should be used.  
  
 `pCodeContext`  
 [in] The code context. This argument may be NULL, which implies the current code context should be used.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method forces execution to continue as close as possible to the code context specified by `pCodeContext`, in the context of the frame specified by `pStackFrame`. Either of these arguments may be `NULL`, representing the current frame or context.  
  
## See also  
 [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md)