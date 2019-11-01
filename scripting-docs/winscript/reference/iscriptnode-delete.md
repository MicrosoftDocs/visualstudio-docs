---
title: "IScriptNode::Delete | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.Delete"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::Delete"
ms.assetid: 6765ff80-a9a8-40a3-a669-7fcc284c87af
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::Delete
Deletes this object tree.  
  
## Syntax  
  
```cpp
HRESULT Delete();  
```  
  
#### Parameters  
 The method takes no parameters.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 After the `Delete` method is called, the [IScriptNode::Alive](../../winscript/reference/iscriptnode-alive.md) method should indicate that script node is not active.  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)