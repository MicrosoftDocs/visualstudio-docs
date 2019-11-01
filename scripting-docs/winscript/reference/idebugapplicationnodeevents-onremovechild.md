---
title: "IDebugApplicationNodeEvents::onRemoveChild | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNodeEvents.onRemoveChild"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugApplicationNodeEvents::onRemoveChild"
ms.assetid: 2e025d29-b8c0-4793-a2d3-c20d548d6386
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNodeEvents::onRemoveChild
Handles the event when a child node is removed from a debug application node object.  
  
## Syntax  
  
```cpp
HRESULT onRemoveChild(  
   IDebugApplicationNode*  prddpChild  
);  
```  
  
#### Parameters  
 `prddpChild`  
 [in] The child application node that was removed.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles the event when a child node is removed from a debug application node object.  
  
 Implementers of the `IDebugApplicationNode` interface raise this event.  
  
## See also  
 [IDebugApplicationNodeEvents Interface](../../winscript/reference/idebugapplicationnodeevents-interface.md)   
 [IDebugApplicationNodeEvents::onAddChild](../../winscript/reference/idebugapplicationnodeevents-onaddchild.md)   
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)