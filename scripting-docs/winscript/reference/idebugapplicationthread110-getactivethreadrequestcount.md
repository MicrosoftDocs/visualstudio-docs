---
title: "IDebugApplicationThread110::GetActiveThreadRequestCount | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationThread110::GetActiveThreadRequestCount"
ms.assetid: 025d2072-1d7f-4448-8aa3-38a014313570
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationThread110::GetActiveThreadRequestCount
Returns the number of thread requests from the PDM's thread switching mechanisms that are currently being processed. This number is usually 0 or 1. However, the number may be higher if one thread call starts processing but triggers a synchronous call out of thread, or otherwise suspends the thread and allows incoming calls to be processed again (for example, by triggering an [IRemoteDebugApplicationEvents Interface](../../winscript/reference/iremotedebugapplicationevents-interface.md) event, which is issued on the debugger thread).  
  
> [!IMPORTANT]
> [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md) is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT GetActiveThreadRequestCount([out, annotation("_Out_")] UINT * puiThreadRequests);  
```  
  
#### Parameters  
 `puiThreadRequests`  
 [out] The number of thread requests.  
  
## See also  
 [IDebugApplicationThread110 Interface](../../winscript/reference/idebugapplicationthread110-interface.md)