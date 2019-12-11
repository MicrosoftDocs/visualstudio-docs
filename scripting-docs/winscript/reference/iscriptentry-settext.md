---
title: "IScriptEntry::SetText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.SetText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "ISetEntry::SetText"
ms.assetid: 4605481b-7707-43d1-ab78-a9207d0cf6fe
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::SetText
Sets the text that corresponds to an `IScriptEntry` script block, or the source code that is contained in an `IScriptScriptlet` event handler.  
  
## Syntax  
  
```cpp
HRESULT SetText(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 [in] The text of the `IScriptEntry` script block, or the source code of the `IScriptScriptlet` event handler.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)