---
title: "IScriptEntry::SetItemName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.SetItemName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::SetItemName"
ms.assetid: 9551a7ec-38f8-466a-9722-09367763f380
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::SetItemName
Sets the item name that identifies an `IScriptEntry` object.  
  
## Syntax  
  
```cpp
HRESULT SetItemName(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 [in] The address of a buffer that contains the item name. The item name is used by the host to identify the entry.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|The method did not succeed.|  
  
## Remarks  
 For `IScriptEntry` objects, this method returns `S_OK`.  
  
 For `IScriptScriptlet` objects (which derive from `IScriptEntry`), this method returns `E_FAIL`. For `IScriptScriptlet` objects, the item name is set by [IActiveScriptAuthor::AddScriptlet](../../winscript/reference/iactivescriptauthor-addscriptlet.md) and cannot be changed.  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)   
 [IScriptEntry::GetItemName](../../winscript/reference/iscriptentry-getitemname.md)