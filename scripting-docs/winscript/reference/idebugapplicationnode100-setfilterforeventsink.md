---
title: "IDebugApplicationNode100::SetFilterForEventSink | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationNode100::SetFilterForEventSink"
ms.assetid: cfb34efe-c6e1-4692-8ffd-3ede3a24cd4b
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode100::SetFilterForEventSink
Sets the filter on a particular [IDebugApplicationNodeEvents Interface](../../winscript/reference/idebugapplicationnodeevents-interface.md) implementation. It allows script debuggers to filter out compiler-generated child application nodes so that the PDM will no longer send events when these are created or removed. By default, all nodes will be sent.  
  
> [!IMPORTANT]
> [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md) is implemented by PDM v10.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT SetFilterForEventSink(        [in] DWORD dwCookie,        [in] APPLICATION_NODE_EVENT_FILTER filter        );  
```  
  
#### Parameters  
 `dwCookie`  
 The cookie of the filter.  
  
 `filter`  
 The filter.  
  
## See also  
 [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md)