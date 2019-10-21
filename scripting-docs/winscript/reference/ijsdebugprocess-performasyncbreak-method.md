---
title: "IJsDebugProcess::PerformAsyncBreak Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugProcess.PerformAsyncBreak"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 2a6ee369-ea99-4332-8521-a1741ccb6292
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProcess::PerformAsyncBreak Method
Puts the script engine in break mode causing it to break on the next script instruction.  
  
## Syntax  
  
```cpp
HRESULT PerformAsyncBreak(  
   DWORD threadId  
);  
```  
  
#### Parameters  
 `threadId`  
 [in] The thread ID.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugProcess Interface](../../winscript/reference/ijsdebugprocess-interface.md)