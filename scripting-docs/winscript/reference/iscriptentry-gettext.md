---
title: "IScriptEntry::GetText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptEntry.GetText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptEntry::GetText"
ms.assetid: 105b8244-1972-4b39-ac18-965f1f345ef2
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptEntry::GetText
Returns the text that corresponds to the `IScriptEntry` script block, or the source code that is contained in the `IScriptScriptlet` event handler.  
  
## Syntax  
  
```cpp
HRESULT GetText(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] The text in the `IScriptEntry` script block, or the source code that is contained in the `IScriptScriptlet` event handler.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)