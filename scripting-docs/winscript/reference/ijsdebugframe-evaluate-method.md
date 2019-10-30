---
title: "IJsDebugFrame::Evaluate Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugFrame.Evaluate"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 0ee61340-37b8-4fbb-a028-748b5315e279
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame::Evaluate Method
Evaluate an expression in the context of this stack frame.  
  
## Syntax  
  
```cpp
HRESULT Evaluate(  
   LPCOLESTR pExpressionText,  
   IJsDebugProperty **ppDebugProperty,  
   BSTR *pError  
);  
```  
  
#### Parameters  
 `pExpressionText`  
 [in] The expression to evaluate.  
  
 `ppDebugProperty`  
 [out] Object representing the property browser.  
  
 `pError`  
 [out] The error message, if an error occurs.  
  
## Return Value  
  
## Remarks  
 Returns the following: S_OK: Evaluation succeeds, *ppDebugProperty contains evaluation result. S_FALSE: Evaluation throws an error (or the evaluation operation is not supported), \*pError contains the error message.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugFrame Interface](../../winscript/reference/ijsdebugframe-interface.md)