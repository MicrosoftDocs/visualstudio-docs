---
title: "IScriptEntry::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.GetName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::GetName"
ms.assetid: 56daa288-618f-497c-a360-7d443afd478b
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::GetName
For entries that represent a single object (such as a function), returns the name of the object.  
  
## Syntax  
  
```cpp
HRESULT GetName(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] The name of the object represented by the `IScriptEntry` script block. If an entry does not represent a single object, NULL is returned.  
  
 Child entries represent a single function object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)   
 [IScriptNode:: CreateChildEntry](../../winscript/reference/iscriptnode-createchildentry.md)