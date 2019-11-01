---
title: "IDebugExpression::QueryIsComplete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpression.QueryIsComplete"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpression::QueryIsComplete"
ms.assetid: 510d62e5-a316-46fb-b23f-d3ba902b295c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression::QueryIsComplete
Determines if the operation is complete.  
  
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
|`S_OK`|The method succeeded, and the operation is complete.|  
|`S_FALSE`|The operation is still pending.|  
  
## Remarks  
 This method determines if the operation is complete.  
  
## See also  
 [IDebugExpression Interface](../../winscript/reference/idebugexpression-interface.md)