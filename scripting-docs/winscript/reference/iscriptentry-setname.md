---
title: "IScriptEntry::SetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.SetName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::SetName"
ms.assetid: dfa33450-87d7-4c8e-bfd8-0cc2d6542a0e
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::SetName
For entries that represent a single object (such as a function), sets the name of the object.  
  
## Syntax  
  
```cpp
HRESULT SetName(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 [in] The new name of the `IScriptEntry` object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)   
 [IScriptEntry::GetName](../../winscript/reference/iscriptentry-getname.md)