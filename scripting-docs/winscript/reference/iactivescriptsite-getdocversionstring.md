---
title: "IActiveScriptSite::GetDocVersionString | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSite.GetDocVersionString"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSite_GetDocVersionString"
ms.assetid: ab3f892d-06d3-4cb5-9ea5-20c4a1e518cd
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSite::GetDocVersionString
Retrieves a host-defined string that uniquely identifies the current document version. If the related document has changed outside the scope of Windows Script (as in the case of an HTML page being edited with Notepad), the scripting engine can save this along with its persisted state, forcing a recompile the next time the script is loaded.  
  
## Syntax  
  
```cpp
HRESULT GetDocVersionString(  
    BSTR *pbstrVersionString  // address of document version string  
);  
```  
  
#### Parameters  
 `pstrVersionString`  
 [out] Address of the host-defined document version string.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_NOTIMPL` if this method is not supported.  
  
## Remarks  
 If `E_NOTIMPL` is returned, the scripting engine should assume that the script is in sync with the document.  
  
## See also  
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)