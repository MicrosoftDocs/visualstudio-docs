---
title: "IDebugDocumentHelper::GetDebugApplicationNode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugDocumentHelper.GetDebugApplicationNode"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugDocumentHelper::GetDebugApplicationNode"
ms.assetid: ecd18803-beb4-4ac2-9702-cc9e8a12c395
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHelper::GetDebugApplicationNode
Returns the debug application node corresponding to this document.  
  
## Syntax  
  
```cpp
HRESULT GetDebugApplicationNode(  
   IDebugApplicationNode**  ppdan  
);  
```  
  
#### Parameters  
 `ppdan`  
 [out] The debug application node corresponding to this document.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Return the debug application node corresponding to this document.  
  
## See also  
 [IDebugDocumentHelper Interface](../../winscript/reference/idebugdocumenthelper-interface.md)