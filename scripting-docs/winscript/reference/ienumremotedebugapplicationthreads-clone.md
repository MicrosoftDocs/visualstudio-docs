---
title: "IEnumRemoteDebugApplicationThreads::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplicationThreads.Clone"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplicationThreads::Clone"
ms.assetid: d016e7cf-ae73-48ff-aee7-810222e0b05c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplicationThreads::Clone
Creates an enumerator that contains the same state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
   IEnumRemoteDebugApplicationThreads**  pperdat  
);  
```  
  
#### Parameters  
 `pperdat`  
 [out] Returns the `IEnumRemoteDebugApplicationThreads` interface of the clone of the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates an enumerator that contains the same state as the current enumerator.  
  
## See also  
 [IEnumRemoteDebugApplicationThreads Interface](../../winscript/reference/ienumremotedebugapplicationthreads-interface.md)