---
title: "IScriptNode::GetChild | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetChild"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetChild"
ms.assetid: 8cb3f8b0-958b-40bb-a91a-49a788661861
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetChild
Returns the child that is at the specified index in the node.  
  
## Syntax  
  
```cpp
HRESULT GetChild(  
   ULONG              isn,  
   IScriptNode        **ppsn  
);  
```  
  
#### Parameters  
 `isn`  
 [in] The index of the child in the parent.  
  
 `ppsn`  
 [out] The address of a variable that receives a pointer to the `IScriptNode` interface of the child instance.  
  
 For `IScriptNode` objects that represent a Web page, this parameter returns an object that contains a script block.  
  
 For `IScriptEntry` objects that specify a script block, this parameter returns an object that specifies a function.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 For `IScriptEntry` objects that specify a function object and for `IScriptScriptlet` objects, this method fails because there are no child entries.  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)