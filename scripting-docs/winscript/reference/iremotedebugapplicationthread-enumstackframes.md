---
title: "IRemoteDebugApplicationThread::EnumStackFrames | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThread.EnumStackFrames"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThread::EnumStackFrames"
ms.assetid: 605ce83d-43d2-47ea-b066-ec8f0da50ca6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThread::EnumStackFrames
Returns an enumerator for the stack frames associated with this thread.  
  
## Syntax  
  
```cpp
HRESULT EnumStackFrames(  
   IEnumDebugStackFrames**  ppedsf  
);  
```  
  
#### Parameters  
 `ppedsf`  
 [out] An enumerator for the stack frames associated with this thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method must be called from within a breakpoint. The stack frame enumerator should return the frames starting at the top of the stack, starting with the most recently pushed frame.  
  
## See also  
 [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md)