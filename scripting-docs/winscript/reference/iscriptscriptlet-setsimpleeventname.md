---
title: "IScriptScriptlet::SetSimpleEventName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptScriptlet.SetSimpleEventName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptScriptlet::SetSimpleEventName"
ms.assetid: 7de9132e-635f-45df-9c92-83a24242b477
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet::SetSimpleEventName
Sets the simple event name that is associated with a scriptlet. This is a single-word name that does not contain any white space.  
  
## Syntax  
  
```cpp
HRESULT SetSimpleEventName(  
   LPCOLESTR          psz  
);  
```  
  
#### Parameters  
 `psz`  
 [in] A buffer that contains the simple event name that is associated with the `IScriptScriptlet` object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptScriptlet Interface](../../winscript/reference/iscriptscriptlet-interface.md)