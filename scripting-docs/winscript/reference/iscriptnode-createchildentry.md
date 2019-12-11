---
title: "IScriptNode:: CreateChildEntry | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode. CreateChildEntry"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::CreateChildEntry"
ms.assetid: b9682505-4457-40e9-8691-235843637506
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode:: CreateChildEntry
Adds a child instance of `IScriptEntry`.  
  
## Syntax  
  
```cpp
HRESULT CreateChildEntry(  
   ULONG              isn,  
   DWORD              dwCookie,  
   LPCOLESTR          pszDelimiter,  
   IScriptEntry       **ppse  
);  
```  
  
#### Parameters  
 `isn`  
 [in] The index of the child in the parent.  
  
 `dwCookie`  
 [in] An application-defined value used to associate the child entry with the host object.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script-block delimiter. For parsing, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the script block.  
  
 The delimiter enables the script authoring engine to provide preprocessing. For example, the engine might replace a single quotation mark with two single quotation marks for use as a delimiter. The engine determines how the delimiter is used.  
  
 Set to NULL if a delimiter does not mark the end of the script block.  
  
 `ppse`  
 [out] The address of a variable that receives a pointer to the `IScriptEntry` interface of the child instance.  
  
 For `IScriptNode` objects that represent a Web page, this parameter returns an `IScriptEntry` instance that specifies a script block.  
  
 For `IScriptEntry` objects that represent a script block, this parameter returns an `IScriptEntry` instance that specifies a function object.  
  
 For `IScriptEntry` objects that represent a function object, this method fails.  
  
 For `IScriptScriptlet` objects, this method fails.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The `IScriptNode` interface represents a Web page or its elements. The `IScriptEntry` interface (which is derived from `IScriptNode`) represents either a script block or a function object. The `IScriptScriptlet` interface (which is derived from `IScriptEntry`) represents an event handler.  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)   
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)