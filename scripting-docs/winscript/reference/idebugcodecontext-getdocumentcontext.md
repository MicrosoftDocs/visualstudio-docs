---
title: "IDebugCodeContext::GetDocumentContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugCodeContext.GetDocumentContext"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugCodeContext::GetDocumentContext"
ms.assetid: 9fe17b65-3a8c-4d21-9b66-0e4ff303af72
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugCodeContext::GetDocumentContext
Returns the document context associated with this code context.  
  
## Syntax  
  
```cpp
HRESULT GetDocumentContext(  
   IDebugDocumentContext**  ppsc  
);  
```  
  
#### Parameters  
 `ppsc`  
 [out] The document context associated with this code context.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 For text documents, the character-position range should include the text for the entire statement. This allows the debugger IDE to highlight the current source statement.  
  
## See also  
 [IDebugCodeContext Interface](../../winscript/reference/idebugcodecontext-interface.md)