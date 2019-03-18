---
title: "IActiveScriptSiteTraceInfo::SendScriptTraceInfo Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 0419e4c5-eb7c-45a3-b6dc-1a5e157d95f9
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteTraceInfo::SendScriptTraceInfo Method
Sends trace information that includes the event type, context, and the script statement.  
  
## Syntax  
  
```cpp
HRESULT SendScriptTraceInfo(     [in] SCRIPTTRACEINFO stiEventType,     [in] GUID guidContextID,     [in] DWORD dwScriptContextCookie,     [in] LONG lScriptStatementStart,     [in] LONG lScriptStatementEnd,     [in] DWORD64 dwReserved );   
```  
  
#### Parameters  
 `stiEventType`  
 The event type.  
  
 `guidContextId`  
 The GUID of the context.  
  
 `dwScriptContextCookie`  
 The cookie of the context.  
  
 `lScriptStatementStart`  
 The location of the start of the script statement.  
  
 `lScriptStatementEnd`  
 The location of the end of the script statement.  
  
 `dwReserved`  
 Reserved.