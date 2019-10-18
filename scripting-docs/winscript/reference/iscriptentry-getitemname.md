---
title: "IScriptEntry::GetItemName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.GetItemName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::GetItemName"
ms.assetid: 8f2562f1-8231-4a39-ad79-074f9ec3d403
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::GetItemName
Returns the item name that identifies an `IScriptEntry` object.  
  
## Syntax  
  
```cpp
HRESULT GetItemName(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] The address of a buffer that contains the item name. The item name is used by the host to identify the entry.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 For `IScriptScriptlet` objects, you set the item name by using [IActiveScriptAuthor::AddScriptlet](../../winscript/reference/iactivescriptauthor-addscriptlet.md). For other interfaces, you set the item name by using [IScriptEntry::SetItemName](../../winscript/reference/iscriptentry-setitemname.md).  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)