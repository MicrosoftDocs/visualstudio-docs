---
title: "IEnumRemoteDebugApplications::Skip | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplications.Skip"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplications::Skip"
ms.assetid: 9f6578d9-8de5-419c-b1b5-7cb07b6367fb
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplications::Skip
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
 [IEnumRemoteDebugApplications Interface](../../winscript/reference/ienumremotedebugapplications-interface.md)