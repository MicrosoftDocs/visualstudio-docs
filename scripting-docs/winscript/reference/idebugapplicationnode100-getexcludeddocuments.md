---
title: "IDebugApplicationNode100::GetExcludedDocuments | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationNode100::GetExcludedDocuments"
ms.assetid: d44583a7-0b0b-4799-b075-837ad1da1946
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode100::GetExcludedDocuments
Gets the text documents that are hidden by the specified filter.  
  
> [!IMPORTANT]
> [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md) is implemented by PDM v10.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT GetExcludedDocuments(        [in] APPLICATION_NODE_EVENT_FILTER filter,        [out] TEXT_DOCUMENT_ARRAY* pDocuments        );  
```  
  
#### Parameters  
 `filter`  
 The filter.  
  
 `pDocuments`  
 The set of documents.  
  
## See also  
 [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md)