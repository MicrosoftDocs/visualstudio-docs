---
title: "IActiveScriptSiteDebug::GetRootApplicationNode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteDebug.GetRootApplicationNode"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteDebug::GetRootApplicationNode"
ms.assetid: 2393f566-6b97-47c0-8041-4dd7e3b1d3a3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebug::GetRootApplicationNode
Gets the application node under which script documents should be added.  
  
## Syntax  
  
```cpp
HRESULT GetRootApplicationNode(  
   IDebugApplicationNode**  ppdanRoot  
);  
```  
  
#### Parameters  
 `ppdanRoot`  
 [out] The debug application node that holds script documents. Can be `NULL`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the application node under which script documents should be added. The method can return `NULL` for `ppdanRoot` if script documents should be top-level.  
  
## See also  
 [IActiveScriptSiteDebug Interface](../../winscript/reference/iactivescriptsitedebug-interface.md)