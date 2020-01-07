---
title: "IDebugExpression::GetResultAsDebugProperty | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpression.GetResultAsDebugProperty"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpression::GetResultAsDebugProperty"
ms.assetid: 9075bf2f-d5bb-464e-b6c2-3fa3215e9ae0
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression::GetResultAsDebugProperty
Returns the result of the expression evaluation as a debug property and the operation's return value.  
  
## Syntax  
  
```cpp
HRESULT GetResultAsDebugProperty(  
   HRESULT*          phrResult,  
   IDebugProperty**  ppdp  
);  
```  
  
#### Parameters  
 `phrResult`  
 [out] The operation's return value.  
  
 `ppdp`  
 [out] The debug property for the expression.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_PENDING`|The operation is still pending.|  
  
## Remarks  
 This method returns the result of the expression evaluation as an `IDebugProperty` and the operation's `HRESULT`.  
  
 This method returns `S_OK` and `phrResult` returns `E_ABORT` if `Abort` aborts the operation.  
  
## See also  
 [IDebugExpression Interface](../../winscript/reference/idebugexpression-interface.md)   
 [IDebugExpression::Abort](../../winscript/reference/idebugexpression-abort.md)