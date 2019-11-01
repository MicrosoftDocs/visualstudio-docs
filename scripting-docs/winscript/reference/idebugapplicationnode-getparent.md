---
title: "IDebugApplicationNode::GetParent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNode.GetParent"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationNode::GetParent"
ms.assetid: 88ba3a53-0cd7-4e1f-8558-79c20ac76cc9
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode::GetParent
Returns the parent node of this application node.  
  
## Syntax  
  
```cpp
HRESULT GetParent(  
   IDebugApplicationNode**  pprddp  
);  
```  
  
#### Parameters  
 `pprddp`  
 [out] Parent application node of this application node.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the parent node of this application node.  
  
## See also  
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)