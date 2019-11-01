---
title: "IEnumRemoteDebugApplications::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplications.Clone"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplications::Clone"
ms.assetid: 762f6dac-1be4-49ec-afda-68c1b29f7a4b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplications::Clone
Creates an enumerator that contains the same state as the current enumerator.  
  
## Syntax  
  
```cpp
HRESULT Clone(  
   IEnumRemoteDebugApplications**  ppessd  
);  
```  
  
#### Parameters  
 `ppessd`  
 [out] A clone of the enumerator.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method creates an enumerator that contains the same state as the current enumerator.  
  
## See also  
 [IEnumRemoteDebugApplications Interface](../../winscript/reference/ienumremotedebugapplications-interface.md)