---
title: "IDebugSyncOperation::GetTargetThread | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSyncOperation.GetTargetThread"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugSyncOperation::GetTargetThread"
ms.assetid: e6eeeb90-b5ed-4727-8434-fa3186c25013
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSyncOperation::GetTargetThread
Returns the target application thread for this synchronous operation.  
  
## Syntax  
  
```cpp
HRESULT GetTargetThread(  
   IDebugApplicationThread**  ppatTarget  
);  
```  
  
#### Parameters  
 `ppatTarget`  
 [out] The target application thread for this synchronous operation.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the target application thread for this synchronous operation.  
  
## See also  
 [IDebugSyncOperation Interface](../../winscript/reference/idebugsyncoperation-interface.md)