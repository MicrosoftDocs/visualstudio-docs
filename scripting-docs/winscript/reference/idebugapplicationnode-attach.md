---
title: "IDebugApplicationNode::Attach | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNode.Attach"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationNode::Attach"
ms.assetid: f4aad4ae-5bb0-4b5e-8f70-912a677f8f7a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode::Attach
Adds this application node to the specified project tree.  
  
## Syntax  
  
```cpp
HRESULT Attach(  
   IDebugApplicationNode*  pdanParent  
);  
```  
  
#### Parameters  
 `pdanParent`  
 [in] The project tree where this application node is to be added.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method adds this application node to the project tree, using `pdanParent` as the parent. If `pdanParent` is `NULL`, this application node will be the top-level node.  
  
## See also  
 [IDebugApplicationNode::Detach](../../winscript/reference/idebugapplicationnode-detach.md)   
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)