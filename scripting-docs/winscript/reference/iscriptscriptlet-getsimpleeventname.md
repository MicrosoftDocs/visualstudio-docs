---
title: "IScriptScriptlet:: GetSimpleEventName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptScriptlet. GetSimpleEventName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptScriptlet::GetSimpleEventName"
ms.assetid: 012eb555-b26c-4248-bbcc-fc30e6f2b308
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet:: GetSimpleEventName
Returns the simple event name that is associated with a scriptlet. This is a single-word name that does not contain any white space.  
  
## Syntax  
  
```cpp
HRESULT GetSimpleEventName(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] A buffer that contains the simple event name that is associated with the `IScriptScriptlet` object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptScriptlet Interface](../../winscript/reference/iscriptscriptlet-interface.md)