---
title: "IRemoteDebugApplication::GetRootNode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IRemoteDebugApplication.GetRootNode"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IRemoteDebugApplication::GetRootNode"
ms.assetid: 6c043aba-1dc5-41de-9711-96cde5e040f6
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplication::GetRootNode
Returns the application node under which all nodes associated with the application are added.  
  
## Syntax  
  
```cpp
HRESULT GetRootNode(  
   IDebugApplicationNode**  ppdanRoot  
);  
```  
  
#### Parameters  
 `ppdanRoot`  
 [out] The debug application node under which all nodes associated with the application are added.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the application node under which all nodes associated with the application are added.  
  
## See also  
 [IRemoteDebugApplication Interface](../../winscript/reference/iremotedebugapplication-interface.md)