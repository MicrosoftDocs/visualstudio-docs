---
title: "IScriptNode::GetNumberOfChildren | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetNumberOfChildren"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetNumberOfChildren"
ms.assetid: 3451c7e9-cb50-482e-9038-6e7d7ce1ecdf
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetNumberOfChildren
Returns the number of child nodes of the `IScriptNode` object.  
  
## Syntax  
  
```cpp
HRESULT GetNumberOfChildren(  
   ULONG              *pcsn  
);  
```  
  
#### Parameters  
 `pcsn`  
 [out] The number of child nodes that the `IScriptNode` object has.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)