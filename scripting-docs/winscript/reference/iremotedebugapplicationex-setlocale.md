---
title: "IRemoteDebugApplicationEx:SetLocale | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplicationEx:SetLocale"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplicationEx:SetLocale"
ms.assetid: cd19f725-f4cd-453a-95e1-0bad676451da
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEx:SetLocale
Sets the language for the debugger localization.  
  
## Syntax  
  
```cpp
HRESULT SetLocale(  
   DWORD  dwLangID  
);  
```  
  
#### Parameters  
 `dwLangID`  
 [in] The language ID.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [ISetNextStatement Interface](../../winscript/reference/isetnextstatement-interface.md)