---
title: "IJsDebugFrame::GetDocumentPositionWithName Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugFrame.GetDocumentPositionWithName"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 1d994714-2c87-4a9e-ae14-a15eec9520c7
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame::GetDocumentPositionWithName Method
Returns the current position of this stack frame within the user-level document.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentPositionWithName(  
   BSTR *pDocumentName,  
   DWORD *pLine,  
   DWORD *pColumn  
);  
```  
  
#### Parameters  
 `pDocumentName`  
 [out] For static scripts, a URL to document. For dynamic scripts, a name containing the type of script (for example, eval code, function code etc.) is returned.  
  
 `pLine`  
 [out] 1-based line position within the document.  
  
 `pColumn`  
 [out] 1-based line position within the document.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugFrame Interface](../../winscript/reference/ijsdebugframe-interface.md)