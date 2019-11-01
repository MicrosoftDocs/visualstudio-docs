---
title: "IActiveScriptAuthor::GetRoot | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetRoot"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetRoot"
ms.assetid: 8e55a0c0-dd35-43d5-bf6f-e2f59c1e88d1
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetRoot
Returns the `IScriptNode` root of the author's script tree.  
  
## Syntax  
  
```cpp
HRESULT GetRoot(  
   IScriptNode        **ppsp  
);  
```  
  
#### Parameters  
 `ppsp`  
 [out] The address of a variable that receives a pointer to the `IScriptNode` interface of the root node.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)