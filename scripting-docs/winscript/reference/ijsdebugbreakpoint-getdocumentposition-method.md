---
title: "IJsDebugBreakPoint::GetDocumentPosition Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJSDebugBreakPoint.GetDocumentPosition"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 886df8ba-a59a-48a7-87f2-3b669e71528f
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugBreakPoint::GetDocumentPosition Method
Returns the position of the statement where the breakpoint was bound.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentPosition(  
   UINT64 *pDocumentId,  
   DWORD *pCharacterOffset,  
   DWORD *pStatementCharCount  
);  
```  
  
#### Parameters  
 `pDocumentId`  
 [out] Unique ID for a source document (pointer to the IDebugDocumentText).  
  
 `pCharacterOffset`  
 [out] The zero-based character offset from the start of the script.  
  
 `pStatementCharCount`  
 [out] The length of current statement, which starts at *pCharacterOffset, in characters.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugBreakPoint Interface](../../winscript/reference/ijsdebugbreakpoint-interface.md)