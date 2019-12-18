---
title: "IRemoteDebugApplicationThread::GetDescription | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationThread.GetDescription"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationThread::GetDescription"
ms.assetid: 69842e9e-7c1c-4841-a6b2-31505fe85738
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationThread::GetDescription
Gets the description and state of this thread.  
  
## Syntax  
  
```cpp
HRESULT GetDescription(  
   BSTR*  pbstrDescription,  
   BSTR*  pbstrState  
);  
```  
  
#### Parameters  
 `pbstrDescription`  
 [out] The description of this thread.  
  
 `pbstrState`  
 [out] The description of the thread state.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method gets the description and state of this thread.  
  
## See also  
 [IRemoteDebugApplicationThread Interface](../../winscript/reference/iremotedebugapplicationthread-interface.md)