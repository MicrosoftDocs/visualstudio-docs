---
title: "IScriptScriptlet::SetSubItemName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptScriptlet.SetSubItemName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptScriptlet::SetSubItemName"
ms.assetid: 619f222f-b4c3-4c7b-9d19-e4e7037343a6
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet::SetSubItemName
Sets the last identifier in the fully qualified name of a scriptlet's object host.  
  
## Syntax  
  
```cpp
HRESULT SetSubItemName(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 If the host's fully qualified scriptlet name has more than one level, `psz` is the buffer address of the identifier at the second level.  
  
 If the host's fully qualified scriptlet name has one level, `psz` is the buffer address of the identifier at the first level.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptScriptlet Interface](../../winscript/reference/iscriptscriptlet-interface.md)