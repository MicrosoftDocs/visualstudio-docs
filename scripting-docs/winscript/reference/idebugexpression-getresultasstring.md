---
title: "IDebugExpression::GetResultAsString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpression.GetResultAsString"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpression::GetResultAsString"
ms.assetid: edadd2ad-9369-4878-bf87-cea15be9f363
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression::GetResultAsString
Returns the result of the expression evaluation as a string and the operation's return value.  
  
## Syntax  
  
```cpp
HRESULT GetResultAsString(  
   HRESULT*  phrResult,  
   BSTR*     pbstrResult  
);  
```  
  
#### Parameters  
 `phrResult`  
 [out] The operation's return value.  
  
 `pbstrResult`  
 [out] The result of the expression evaluation.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_PENDING`|The operation is still pending.|  
  
## Remarks  
 This method returns the result of the expression evaluation as a string and the operation's `HRESULT`.  
  
 This method returns `S_OK` and `phrResult` returns `E_ABORT` if `Abort` aborts the operation.  
  
## See also  
 [IDebugExpression Interface](../../winscript/reference/idebugexpression-interface.md)