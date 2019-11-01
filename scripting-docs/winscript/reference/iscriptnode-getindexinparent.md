---
title: "IScriptNode::GetIndexInParent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetIndexInParent"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetIndexInParent"
ms.assetid: 521c1ca1-2d27-4344-bf3b-d8b53132b648
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetIndexInParent
Returns the index of an object in the parent's child list.  
  
## Syntax  
  
```cpp
HRESULT GetIndexInParent(  
   ULONG              pisn,  
);  
```  
  
#### Parameters  
 `pisn`  
 [out] Returns the index of an object in the parent's child list.  
  
 If this method is called by an `IScriptNode` object that represents a Web page, this parameter returns 0.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)