---
title: "IActiveScriptAuthor::GetLanguageFlags | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetLanguageFlags"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetLanguageFlags"
ms.assetid: eb244452-62f7-4a73-b48f-1aa05cbcc32d
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetLanguageFlags
Returns language information.  
  
## Syntax  
  
```cpp
HRESULT GetLanguageFlags(  
   DWORD              *pgrfasa  
);  
```  
  
#### Parameters  
 `pgrfasa`  
 [out] The flags that contain language information. Can be a combination of the following values:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|fasaPreferInternalHandler|0x0001|The language prefers script event handler creation by the script authoring engine instead of the application.|  
|fasaSupportInternalHandler|0x0002|The language supports script event handlers created by the script authoring engine.|  
|fasaCaseSensitive|0x0004|The script language is case sensitive.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 If the script authoring engine manages event handlers, your application should call `CreateChildHandler` from an `IScriptEntry` object. This creates an `IScriptScriptlet` object that corresponds to the event handler. The engine also adds an event handler to the script entry. The event handler is an empty function that contains the specified signature information.  
  
 If your application manages event handlers, it should call `CreateChildHandler` from an `IScriptNode` object that represents an event handler scriptlet. This creates an `IScriptScriptlet` object that is associated with the event handler scriptlet. The application also has to add an empty function as an event handler to a new or existing `IScriptEntry` object.  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)