---
title: "IActiveScriptAuthor::GetEventHandler | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetEventHandler"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetEventHandler"
ms.assetid: 87c7a71d-46b9-448c-b34d-394105e20982
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetEventHandler
Returns the scriptlet that has the specified attributes.  
  
## Syntax  
  
```cpp
HRESULT GetEventHandler(  
   IDispatch          *pdisp,  
   LPCOLESTR          pszItem,  
   LPCOLESTR          pszSubItem,  
   LPCOLESTR          pszEvent,  
   IScriptEntry       **ppse  
);  
```  
  
#### Parameters  
 `pdisp`  
 [in] The `IDispatch` object that corresponds to the `NamedItem` to which the scriptlet is attached.  
  
 `pszItem`  
 [in] The buffer address of the top-level identifier of the fully qualified scriptlet name in the host.  
  
 `pszSubItem`  
 [in] The buffer address of the second-level identifier of the fully qualified scriptlet name in the host. Set to NULL if the name has only one level.  
  
 `pszEvent`  
 [in] The address of a buffer that contains the event name. The scriptlet is an event handler for this event.  
  
 `ppse`  
 [out] The address of a variable that receives a pointer to the `IScriptEntry` interface of the scriptlet that has the specified attributes.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)