---
title: "IEnumRemoteDebugApplicationThreads::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplicationThreads.Skip"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplicationThreads::Skip"
ms.assetid: bb13a18b-bcf8-4542-8b1a-55a4f2769536
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplicationThreads::Skip
Skips a specified number of segments in an enumeration sequence.  
  
## Syntax  
  
```cpp
HRESULT Skip(  
   ULONG  celt  
);  
```  
  
#### Parameters  
 `celt`  
 [in] Number of segments in the enumeration sequence to skip.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method skips a specified number of segments in an enumeration sequence.  
  
## See also  
 [IEnumRemoteDebugApplicationThreads Interface](../../winscript/reference/ienumremotedebugapplicationthreads-interface.md)