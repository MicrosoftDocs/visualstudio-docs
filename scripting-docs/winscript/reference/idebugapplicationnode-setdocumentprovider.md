---
title: "IDebugApplicationNode::SetDocumentProvider | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNode.SetDocumentProvider"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationNode::SetDocumentProvider"
ms.assetid: 7cb587ca-d84e-4b5e-9b94-e973cca55a03
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode::SetDocumentProvider
Sets the document provider for this application node.  
  
## Syntax  
  
```cpp
HRESULT SetDocumentProvider(  
   IDebugDocumentProvider*  pddp  
);  
```  
  
#### Parameters  
 `pddp`  
 [in] The document provider for this application node.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method sets the document provider for this application node.  
  
## See also  
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)