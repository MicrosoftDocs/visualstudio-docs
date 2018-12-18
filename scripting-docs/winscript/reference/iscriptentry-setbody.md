---
title: "IScriptEntry::SetBody | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.SetBody"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::SetBody"
ms.assetid: 719062e4-98e4-4a7b-946d-6e5dbbcc5225
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::SetBody
Sets the text that is in the body of an `IScriptEntry` script block or an `IScriptScriptlet` scriptlet.  
  
## Syntax  
  
```cpp
HRESULT SetBody(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 [in] For an `IScriptEntry` script block, `psz` is the text enclosed in the script tags.  
  
 For an `IScriptEntry` function block, `psz` is the function body.  
  
 For an `IScriptScriptlet` object (which derives from `IScriptEntry`), `psz` is the script text of the scriptlet.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)   
 [IScriptEntry::GetBody](../../winscript/reference/iscriptentry-getbody.md)