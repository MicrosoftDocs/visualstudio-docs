---
title: "IEnumDebugExpressionContexts Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IEnumDebugExpressionContexts interface"
ms.assetid: 1c11f9ff-c5a6-48b8-a287-0d782513ba55
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumDebugExpressionContexts Interface
Enumerates a collection of `IDebugExpressionContexts` objects.  
  
 In addition to the methods inherited from `IUnknown`, the `IEnumDebugExpressionContexts` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugExpressionContexts::Next](../../winscript/reference/ienumdebugexpressioncontexts-next.md)|Retrieves a specified number of segments in the enumeration sequence.|  
|[IEnumDebugExpressionContexts::Skip](../../winscript/reference/ienumdebugexpressioncontexts-skip.md)|Skips a specified number of segments in an enumeration sequence.|  
|[IEnumDebugExpressionContexts::Reset](../../winscript/reference/ienumdebugexpressioncontexts-reset.md)|Resets an enumeration sequence to the beginning.|  
|[IEnumDebugExpressionContexts::Clone](../../winscript/reference/ienumdebugexpressioncontexts-clone.md)|Creates an enumerator that contains the same state as the current enumerator.|