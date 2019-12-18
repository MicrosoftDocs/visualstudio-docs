---
title: "IScriptScriptlet::GetSubItemName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptScriptlet.GetSubItemName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptScriptlet::GetSubItemName"
ms.assetid: 9ad963fc-9ce8-4b77-92c1-fb90d6307801
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet::GetSubItemName
Returns the last identifier in the fully qualified name of a scriptlet's object host.  
  
## Syntax  
  
```cpp
HRESULT GetSubItemName(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] If the host's fully qualified scriptlet name has more than one level, `pbstr` returns the buffer address of the identifier at the second level.  
  
 If the host's fully qualified scriptlet name has one level, `pbstr` returns the buffer address of the identifier at the first level.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptScriptlet Interface](../../winscript/reference/iscriptscriptlet-interface.md)