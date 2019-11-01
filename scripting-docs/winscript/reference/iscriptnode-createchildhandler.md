---
title: "IScriptNode::CreateChildHandler | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.CreateChildHandler"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::CreateChildHandler"
ms.assetid: 4ce5eb10-1a3f-43b0-a4b7-599a397ed3a2
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::CreateChildHandler
Adds a scriptlet as a child instance of an `IScriptNode`.  
  
## Syntax  
  
```cpp
HRESULT CreateChildHandler(  
   LPCOLESTR          pszDefaultName,  
   LPCOLESTR          *prgpszNames,  
   ULONG              cpszNames,  
   LPCOLESTR          pszEvent,  
   LPCOLESTR          pszDelimiter,  
   ITypeInfo*         ptiSignature,  
   ULONG              iMethodSignature,  
   ULONG              isn,  
   DWORD              dwCookie,  
   IScriptEntry       **ppse  
);  
```  
  
#### Parameters  
 `pszDefaultName`  
 [in] The address of the default name to associate with the scriptlet.  
  
 `prgpszNames`  
 [in, size_is(`cpszNames`)] A list of identifiers from the fully qualified name on the host.  
  
 `cpszNames`  
 [in] The number of identifiers in the `prgpszNames` parameter.  
  
 `pszEvent`  
 [in] The buffer address that identifies the event name associated with the scriptlet.  
  
 `pszDelimiter`  
 [in] The address of the end-of-script-block delimiter. For parsing, the host typically uses a delimiter (such as two single quotation marks), to detect the end of the script block.  
  
 The delimiter enables preprocessing by the script authoring engine. For example, the engine might replace a single quotation mark with two single quotation marks for use as a delimiter. The engine determines how the delimiter is used.  
  
 Set to NULL if no delimiter is used to identify the end of the script block.  
  
 `ptiSignature`  
 [in] The type information for a function object.  
  
 `iMethodSignature`  
 [in] The index of the function in the `ITypeInfo``ptiSignature` parameter.  
  
 `isn`  
 [in] The index of the child in the parent.  
  
 `dwCookie`  
 [in] An application-defined value that is used to associate the entry with the host object.  
  
 `ppse`  
 [out] The address of a variable that receives a pointer to the `IScriptEntry` interface of the child instance.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A scriptlet specifies an event handler. This method creates a scriptlet if it is called by an `IScriptNode` object that represents a Web page. This method does not succeed if it is called by other interfaces.  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)   
 [IScriptEntry Interface](../../winscript/reference/iscriptentry-interface.md)