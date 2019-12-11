---
title: "ISetNextStatement::SetNextStatement | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ISetNextStatement.SetNextStatement"
apilocation: 
  - "scrobj.dll"
ms.assetid: c5534f3b-39a5-4466-b8fc-69b717c6eee9
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISetNextStatement::SetNextStatement
This method updates the next code context that the script interpreter can execute.  
  
## Syntax  
  
```cpp
HRESULT SetNextStatement(  
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
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [ISetNextStatement Interface](../../winscript/reference/isetnextstatement-interface.md)