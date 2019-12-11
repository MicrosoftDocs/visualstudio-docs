---
title: "IActiveScriptAuthor::RemoveNamedItem | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.RemoveNamedItem"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::RemoveNamedItem"
ms.assetid: 1173ef46-39a5-4bc1-8e0c-89259a16be16
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::RemoveNamedItem
Removes a `NamedItem` object from the namespace of the script authoring engine.  
  
## Syntax  
  
```cpp
HRESULT RemoveNamedItem(  
   LPCOLESTR          pszName  
);  
```  
  
#### Parameters  
 `pszName`  
 [in] The address of the buffer that identifies the `NamedItem` object to remove.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`S_FALSE`|The `NamedItem` object is not present in the namespace of the script authoring engine.|  
  
## Remarks  
 [IActiveScript::AddNamedItem](../../winscript/reference/iactivescript-addnameditem.md) is used to inject the `NamedItem` object into the script authoring engine's namespace.  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IActiveScriptAuthor::AddNamedItem](../../winscript/reference/iactivescriptauthor-addnameditem.md)