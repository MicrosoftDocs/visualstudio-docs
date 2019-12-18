---
title: "IDebugExpression::Start | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpression.Start"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpression::Start"
ms.assetid: a7af3470-62b5-40f0-987d-63b6b22538b3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression::Start
Begins the evaluation of the expression.  
  
## Syntax  
  
```cpp
HRESULT Start(  
   IDebugExpressionCallBack*  pdecb  
);  
```  
  
#### Parameters  
 `pdecb`  
 [in] Callback for indicating when the expression evaluation is complete. If this parameter is `NULL`, no events are fired and the client must poll the expression state by using `QueryIsComplete`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method begins the evaluation of the expression.  
  
## See also  
 [IDebugExpression::Abort](../../winscript/reference/idebugexpression-abort.md)   
 [IDebugExpression Interface](../../winscript/reference/idebugexpression-interface.md)