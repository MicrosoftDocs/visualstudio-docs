---
title: "IDebugAsyncOperation::GetSyncDebugOperation | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperation.GetSyncDebugOperation"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperation::GetSyncDebugOperation"
ms.assetid: ff89a3bc-57d7-4cb9-9818-8d73ed71af73
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation::GetSyncDebugOperation
Returns the synchronous debug operation associated with this object.  
  
## Syntax  
  
```cpp
HRESULT GetSyncDebugOperation(  
   IDebugSyncOperation**  ppsdo  
);  
```  
  
#### Parameters  
 `ppsdo`  
 [out] The synchronous debug operation associated with this object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the synchronous debug operation associated with this object.  
  
## See also  
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)