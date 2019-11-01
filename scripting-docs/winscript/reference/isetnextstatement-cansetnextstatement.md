---
title: "ISetNextStatement::CanSetNextStatement | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISetNextStatement.CanSetNextStatement"
apilocation: 
  - "scrobj.dll"
ms.assetid: e2a54634-31ec-4d16-84e8-2b123845d876
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISetNextStatement::CanSetNextStatement
This method determines whether the execution point, which determines the next statement of code to be executed, can be set to the specified location.  
  
## Syntax  
  
```cpp
HRESULT CanSetNextStatement(  
   IDebugStackFrame*  pStackFrame,  
   IDebugCodeContext*  pCodeContext  
)  
```  
  
#### Parameters  
 `pStackFrame`  
 [in] Pointer to a stack frame object.  
  
 `pCodeContext`  
 [in] Pointer to a code context object.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The next statement can be updated to the specified code context.|  
|`S_FALSE`|The next statement cannot be updated to the specified code context.|  
  
## Remarks  
  
## See also  
 [ISetNextStatement Interface](../../winscript/reference/isetnextstatement-interface.md)