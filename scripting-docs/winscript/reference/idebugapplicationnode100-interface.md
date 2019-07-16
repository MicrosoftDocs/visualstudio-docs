---
title: "IDebugApplicationNode100 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationNode100 Interface"
ms.assetid: 43966d4e-5f89-4a04-a08d-782347d00c2d
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode100 Interface
The `IDebugApplicationNode100` interface extends the functionality of the [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md). You can get an instance of this interface by calling QueryInterface on an implementation of [IDebugApplicationNode Interface](../../winscript/reference/idebugapplicationnode-interface.md).  
  
> [!IMPORTANT]
> This interface is implemented by PDM v10.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IDebugApplicationNode100` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugApplicationNode100::GetExcludedDocuments](../../winscript/reference/idebugapplicationnode100-getexcludeddocuments.md)|Gets the text documents that are hidden by the specified filter.|  
|[IDebugApplicationNode100::QueryIsChildNode](../../winscript/reference/idebugapplicationnode100-queryischildnode.md)|Determines whether the specified document belongs to one of the child nodes of this node.|  
|[IDebugApplicationNode100::SetFilterForEventSink](../../winscript/reference/idebugapplicationnode100-setfilterforeventsink.md)|Sets the filter on a particular [IDebugApplicationNodeEvents Interface](../../winscript/reference/idebugapplicationnodeevents-interface.md) implementation. It allows script debuggers to filter out compiler-generated child application nodes so that the PDM will no longer send events when the nodes are created or removed. By default, all nodes will be sent.|