---
title: "IScriptEntry::GetRange | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.GetRange"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::GetRange"
ms.assetid: 3ac18f0a-b470-4f4d-b8f5-2da3fdef74f1
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::GetRange
Returns the start position and length of an entry.  
  
## Syntax  
  
```cpp
HRESULT GetRange(  
   ULONG              *pichMin  
   ULONG              *pcch  
);  
```  
  
#### Parameters  
 `pichMin`  
 [out] For `IScriptEntry` objects that specify a script block, returns 0.  
  
 For `IScriptEntry` objects that specify a function object, returns the start position of the function in the current script block.  
  
 For `IScriptScriptlet` objects, returns 0.  
  
 `pcch`  
 [out] For `IScriptEntry` objects that specify a script block, returns the length of the text.  
  
 For `IScriptEntry` objects that specify a function object, returns the length of the function definition.  
  
 For `IScriptScriptlet` objects, returns the length of the entry.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)