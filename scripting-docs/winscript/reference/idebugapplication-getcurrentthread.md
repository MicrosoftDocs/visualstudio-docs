---
title: "IDebugApplication::GetCurrentThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.GetCurrentThread"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::GetCurrentThread"
ms.assetid: 15128e77-6fc6-42a2-8c04-20e22ef03f29
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::GetCurrentThread
Returns the thread associated with the currently running thread.  
  
## Syntax  
  
```cpp
HRESULT GetCurrentThread(  
   IDebugApplicationThread**  pat  
);  
```  
  
#### Parameters  
 `pat`  
 [out] The thread associated with the currently running thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the thread associated with the currently running thread.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)