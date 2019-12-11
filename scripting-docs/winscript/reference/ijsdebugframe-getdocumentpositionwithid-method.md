---
title: "IJsDebugFrame::GetDocumentPositionWithId Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugFrame.GetDocumentPositionWithId"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 48f8eb26-8ae4-4d5c-bd94-796023b03bcb
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame::GetDocumentPositionWithId Method
Returns the current position of this stack frame within the user-level document.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentPositionWithId(  
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
 [IJsDebugFrame Interface](../../winscript/reference/ijsdebugframe-interface.md)