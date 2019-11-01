---
title: "IDebugApplicationNodeEvents::onAddChild | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNodeEvents.onAddChild"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugApplicationNodeEvents::onAddChild"
ms.assetid: 59ce33cf-1843-4b03-98a2-34859d3023f7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNodeEvents::onAddChild
Handles the event when a child node is added to a debug application node object.  
  
## Syntax  
  
```cpp
HRESULT onAddChild(  
   IDebugApplicationNode*  prddpChild  
);  
```  
  
#### Parameters  
 `prddpChild`  
 [in] The child debug application node that was added.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the event when a child node is added to a debug application node object.  
  
 Implementers of the `IDebugApplicationNode` interface raise this event  
  
## See also  
 [IDebugApplicationNodeEvents Interface](../../winscript/reference/idebugapplicationnodeevents-interface.md)   
 [IDebugApplicationNodeEvents::onRemoveChild](../../winscript/reference/idebugapplicationnodeevents-onremovechild.md)   
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)