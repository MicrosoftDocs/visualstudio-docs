---
title: "IDebugExpression::Abort | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpression.Abort"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpression::Abort"
ms.assetid: dbdb63c1-6c4a-4cef-bb40-1843495ae167
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression::Abort
Stops the expression.  
  
## Syntax  
  
```cpp
HRESULT Abort();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method stops an expression evaluation at the earliest opportunity.  
  
## See also  
 [IDebugExpression Interface](../../winscript/reference/idebugexpression-interface.md)   
 [IDebugExpression::Start](../../winscript/reference/idebugexpression-start.md)