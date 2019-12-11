---
title: "IDebugApplicationNode::EnumChildren | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNode.EnumChildren"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationNode::EnumChildren"
ms.assetid: d79b362b-23d5-4a5e-a214-5a78618eaf71
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode::EnumChildren
Enumerates the child nodes of this application node.  
  
## Syntax  
  
```cpp
HRESULT EnumChildren(  
   IEnumDebugApplicationNodes**  pperddp  
);  
```  
  
#### Parameters  
 `pperddp`  
 [out] The enumeration of this node's child nodes.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method enumerates the child nodes of this application node.  
  
## See also  
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)