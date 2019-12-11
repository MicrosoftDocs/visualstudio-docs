---
title: "IScriptNode::GetCookie | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetCookie"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetCookie"
ms.assetid: 007339c6-a73a-4147-b3c0-cc041e467ecd
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetCookie
Returns an application-defined value that is used to associate a scriptlet with the host object.  
  
## Syntax  
  
```cpp
HRESULT GetCookie(  
   DWORD              *pdwCookie  
);  
```  
  
#### Parameters  
 `pdwCookie`  
 [out] For an `IScriptEntry` object, returns the application-defined cookie value.  
  
 For an `IScriptNode` object that represents a Web page, returns 0.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)