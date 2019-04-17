---
title: "IActiveScriptTraceInfo::StartScriptTracing Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 90fac5ed-ce15-49b7-a6f1-605ede6f34e2
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptTraceInfo::StartScriptTracing Method
Starts script tracing.  
  
## Syntax  
  
```cpp
HRESULT StartScriptTracing(     [in] IActiveScriptSiteTraceInfo * pSiteTraceInfo,     [in] GUID guidContextID );   
```  
  
#### Parameters  
 `pSiteTraceInfo`  
 A pointer to the host's IActiveScriptSiteTraceInfo.  
  
 `guidContextId`  
 The GUID of the context.  
  
## Return Value  
 The possible return values for this method are the following:  
  
1. S_OK: Success.  
  
2. E_POINTER: `pSiteTraceInfo` is a NULL pointer.  
  
3. E_NOTIMPL: Not implemented.