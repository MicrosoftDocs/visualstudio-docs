---
title: "IDebugApplicationNode::Close | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNode.Close"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplicationNode::Close"
ms.assetid: ea8db480-2344-4c7b-960c-4fa97fa6c1b7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode::Close
Causes this application to release all references and enter an inactive state.  
  
## Syntax  
  
```cpp
HRESULT Close();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 Typically, the owner of an application calls this method when the application exits.  
  
## See also  
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)