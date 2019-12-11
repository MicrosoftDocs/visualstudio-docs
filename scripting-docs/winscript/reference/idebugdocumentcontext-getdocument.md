---
title: "IDebugDocumentContext::GetDocument | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentContext.GetDocument"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentContext::GetDocument"
ms.assetid: 32db2fea-4938-4644-b39a-8fae05960d1d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentContext::GetDocument
Returns the document that contains this context.  
  
## Syntax  
  
```cpp
HRESULT GetDocument(  
   IDebugDocument**  ppsd  
);  
```  
  
#### Parameters  
 `ppsd`  
 [out] The document that contains this context.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `GetDocument` method returns the document that contains this context.  
  
## See also  
 [IDebugDocumentContext Interface](../../winscript/reference/idebugdocumentcontext-interface.md)