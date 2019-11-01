---
title: "IDebugApplicationNodeEvents::onDetach | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplicationNodeEvents.onDetach"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDebugApplicationNodeEvents::onDetach"
ms.assetid: ef0cbe40-8c52-4bc9-bed0-9fc508abec6e
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNodeEvents::onDetach
Handles an event signifying that the debug application node object was detached from a parent node.  
  
## Syntax  
  
```cpp
HRESULT onDetach();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method handles an event signifying that the debug application node object was detached from a parent node.  
  
 Implementers of the `IDebugApplicationNode` interface raise this event.  
  
## See also  
 [IDebugApplicationNodeEvents Interface](../../winscript/reference/idebugapplicationnodeevents-interface.md)   
 [IDebugApplicationNodeEvents::onAttach](../../winscript/reference/idebugapplicationnodeevents-onattach.md)   
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)