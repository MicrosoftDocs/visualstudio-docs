---
title: "IScriptNode::GetParent | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetParent"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetParent"
ms.assetid: 0fb813f6-ab94-46b2-b0cf-ef5d1cd38ae4
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetParent
Returns the `IScriptNode` object that is the parent of an object.  
  
## Syntax  
  
```cpp
HRESULT GetParent(  
   IScriptNode       **ppsnParent  
);  
```  
  
#### Parameters  
 `ppsnParent`  
 [out] The address of a variable that receives a pointer to the `IScriptNode` interface of the parent instance.  
  
 If the class implements `IScriptEntry` or `IScriptScriptlet`, an `IScriptNode` object is returned.  
  
 If the class implements `IScriptNode` (representing a Web page), NULL is returned.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)