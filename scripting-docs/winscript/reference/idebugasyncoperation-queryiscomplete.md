---
title: "IDebugAsyncOperation::QueryIsComplete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugAsyncOperation.QueryIsComplete"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugAsyncOperation::QueryIsComplete"
ms.assetid: fcf6e229-4d40-46d9-ab81-d3561bc8e084
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation::QueryIsComplete
Determines if the debug operation has completed.  
  
## Syntax  
  
```cpp
HRESULT QueryIsComplete();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The operation is complete.|  
|`S_FALSE`|The operation is not complete.|  
  
## Remarks  
 This method determines if the debug operation has completed.  
  
## See also  
 [IDebugAsyncOperation Interface](../../winscript/reference/idebugasyncoperation-interface.md)