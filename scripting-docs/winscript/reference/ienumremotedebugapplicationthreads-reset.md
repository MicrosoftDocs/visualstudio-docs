---
title: "IEnumRemoteDebugApplicationThreads::Reset | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IEnumRemoteDebugApplicationThreads.Reset"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IEnumRemoteDebugApplicationThreads::Reset"
ms.assetid: a6ad8a01-4cc0-4f9c-9cfe-c7448c753473
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumRemoteDebugApplicationThreads::Reset
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
 [IEnumRemoteDebugApplicationThreads Interface](../../winscript/reference/ienumremotedebugapplicationthreads-interface.md)