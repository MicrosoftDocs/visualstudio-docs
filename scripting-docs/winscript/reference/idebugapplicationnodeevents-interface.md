---
title: "IDebugApplicationNodeEvents Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationNodeEvents interface"
ms.assetid: 02e0bb17-84ce-458b-bae6-608a9899e535
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNodeEvents Interface
Provides the event interface for the `IDebugApplicationNode` interface.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugApplicationNodeEvents` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugApplicationNodeEvents::onAddChild](../../winscript/reference/idebugapplicationnodeevents-onaddchild.md)|Handles the event when a child node is added to a debug application node object.|  
|[IDebugApplicationNodeEvents::onRemoveChild](../../winscript/reference/idebugapplicationnodeevents-onremovechild.md)|Handles the event when a child node is removed from a debug application node object.|  
|[IDebugApplicationNodeEvents::onDetach](../../winscript/reference/idebugapplicationnodeevents-ondetach.md)|Handles an event signifying that the debug application node object was detached from a parent node.|  
|[IDebugApplicationNodeEvents::onAttach](../../winscript/reference/idebugapplicationnodeevents-onattach.md)|Handles an event signifying that the debug application node object was attached to a parent node.|  
  
## See also  
 [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md)