---
title: "IActiveScriptAuthor::AddNamedItem | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.AddNamedItem"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::AddNamedItem"
ms.assetid: 951003b6-1c4a-4086-b7ce-2f128e007280
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::AddNamedItem
Adds the name of a root-level item to the script authoring engine's namespace. A *root-level item* is an object that can contain properties and methods, and that can also contain an event source.  
  
## Syntax  
  
```cpp
HRESULT AddNamedItem(  
   LPCOLESTR          pszName,  
   DWORD              dwFlags,  
   IDispatch          *pdisp  
);  
```  
  
#### Parameters  
 `pszName`  
 [in] The name of the item as viewed from the script. The name must be unique and persistable.  
  
 `dwFlags`  
 [in] The flags that are associated with the named item. Can be a combination of the following values:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|SCRIPTITEM_ISVISIBLE|0x00000002|Indicates that the item's name is available in the namespace of the script. This allows access to the item's properties, methods, and events.<br /><br /> By convention, the properties of the item include the item's child members. Therefore, all child object properties and methods (and their child members, recursively) are accessible.|  
|SCRIPTITEM_ISSOURCE|0x00000004|Indicates the item source's events that the script can have script event handlers.|  
|SCRIPTITEM_GLOBALMEMBERS|0x00000008|Indicates that the item is a collection of global properties and methods that are associated with the script. Its members are authored as global variables and methods.|  
|SCRIPTITEM_ISPERSISTENT|0x00000040|Indicates that the item should be saved if the script authoring engine is saved.|  
|SCRIPTITEM_CODEONLY|0x00000200|Indicates that the named item represents a code-only object, and it does not have a member to author.|  
|SCRIPTITEM_NOCODE|0x00000400|Indicates that the named item is just a name being added, and it has nothing to author.|  
  
 `pdisp`  
 [in] The `IDispatch` of the `NamedItem` object that is used to collect methods, properties, or the event source.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IActiveScriptAuthor::RemoveNamedItem](../../winscript/reference/iactivescriptauthor-removenameditem.md)