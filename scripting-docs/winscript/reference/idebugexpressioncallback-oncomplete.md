---
title: "IDebugExpressionCallBack::onComplete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpressionCallBack.onComplete"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugExpressionCallBack::onComplete"
ms.assetid: d0b89db3-38e7-44e0-93fe-60205f9149dd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpressionCallBack::onComplete
Indicates that the expression evaluation is complete.  
  
## Syntax  
  
```cpp
HRESULT onComplete();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is called when the expression evaluation is complete. The `IDebugExpression::GetResultAsString` method can be called from within this event handler.  
  
## See also  
 [IDebugExpressionCallBack Interface](../../winscript/reference/idebugexpressioncallback-interface.md)   
 [IDebugExpression::GetResultAsString](../../winscript/reference/idebugexpression-getresultasstring.md)