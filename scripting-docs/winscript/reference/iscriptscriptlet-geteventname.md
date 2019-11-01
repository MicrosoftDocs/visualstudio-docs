---
title: "IScriptScriptlet::GetEventName | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptScriptlet.GetEventName"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptScriptlet::GetEventName"
ms.assetid: 548fa650-808e-4c96-8253-5c72e67e8215
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptScriptlet::GetEventName
Returns the name of the event associated with the scriptlet.  
  
## Syntax  
  
```cpp
HRESULT GetEventName(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] A buffer that contains the event name that is associated with the `IScriptScriptlet` object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptScriptlet Interface](../../winscript/reference/iscriptscriptlet-interface.md)