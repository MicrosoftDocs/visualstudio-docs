---
title: "IEnumRemoteDebugApplications::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplications.Reset"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplications::Reset"
ms.assetid: a2c03728-999f-400c-bf40-4ced6cd88410
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplications::Reset
Resets an enumeration sequence to the beginning.  
  
## Syntax  
  
```cpp
HRESULT Reset();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method resets an enumeration sequence to the beginning.  
  
## See also  
 [IEnumRemoteDebugApplications Interface](../../winscript/reference/ienumremotedebugapplications-interface.md)