---
title: "IScriptNode::Alive | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.Alive"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::Alive"
ms.assetid: d2755c83-e9b9-4c0a-acb7-25b554fc9fe8
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::Alive
Indicates whether an object is still active.  
  
## Syntax  
  
```cpp
HRESULT Alive();  
```  
  
#### Parameters  
 The method takes no parameters.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The script node is still active.|  
  
## Remarks  
 If the object is not active, Component Object Model (COM) returns an error from the marshaling proxy for calls to this method.  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)