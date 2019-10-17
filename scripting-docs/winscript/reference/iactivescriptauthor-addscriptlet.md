---
title: "IActiveScriptAuthor::AddScriptlet | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.AddScriptlet"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::AddScriptlet"
ms.assetid: 879a6651-f187-4934-b130-c1247549900b
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::AddScriptlet
Adds a code scriptlet as a child of the root level `IScriptNode` object. In the host, the fully qualified name of the scriptlet is allowed to have only two levels.  
  
## Syntax  
  
```cpp
HRESULT AddScriptlet(  
   LPCOLESTR pszDefaultName,  
   LPCOLESTR pszCode,  
   LPCOLESTR pszItemName,  
   LPCOLESTR pszSubItemName,  
   LPCOLESTR pszEventName,  
   LPCOLESTR pszDelimiter,  
   DWORD dwCookie,  
   DWORD dwFlags  
);  
```  
  
#### Parameters  
 `pszDefaultName`  
 [in] The address of the default name to associate with the scriptlet.  
  
 `pszCode`  
 [in] The address of the scriptlet text.  
  
 `pszItemName`  
 [in] The buffer address of the top-level identifier of the fully qualified scriptlet name in the host.  
  
 `pszSubItemName`  
 [in] The buffer address of the second-level identifier of the fully qualified scriptlet name in the host. Set to NULL if the name has only one level.  
  
 `pszEventName`  
 [in] The address of a buffer that contains the event name for which the scriptlet is an event handler.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script-block delimiter. When `pszCode` is parsed from a stream of text, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the script block. Set this parameter to NULL if a delimiter does not mark the end of the script block.  
  
 `dwCookie`  
 [in] An application-defined value that is used to associate the scriptlet with a host object.  
  
 `dwFlags`  
 [in] Not used.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)