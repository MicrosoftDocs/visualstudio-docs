---
title: "IActiveScriptSiteDebug::OnScriptErrorDebug | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptSiteDebug.OnScriptErrorDebug"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptSiteDebug::OnScriptErrorDebug"
ms.assetid: 87f201da-36eb-49a2-b000-e1e1e8c4cdb7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteDebug::OnScriptErrorDebug
Allows a smart host to determine how to handle run-time errors.  
  
## Syntax  
  
```cpp
HRESULT OnScriptErrorDebug(  
   IActiveScriptErrorDebug*  pErrorDebug,  
   BOOL*                     pfEnterDebugger,  
   BOOL*                     pfCallOnScriptErrorWhenContinuing  
);  
```  
  
#### Parameters  
 `pErrorDebug`  
 [in] The run-time error that occurred  
  
 `pfEnterDebugger`  
 [out] Flag indicating whether to pass the error to the debugger to do JIT debugging.  
  
 `pfCallOnScriptErrorWhenContinuing`  
 [out] Flag indicating whether to call `IActiveScriptSite::OnScriptError` when the user decides to continue without debugging.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to the value in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A smart host can use this method to determine how to handle run-time errors.  
  
## See also  
 [IActiveScriptSiteDebug Interface](../../winscript/reference/iactivescriptsitedebug-interface.md)