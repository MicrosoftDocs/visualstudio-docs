---
title: "IDebugApplication::HandleRuntimeError | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.HandleRuntimeError"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::HandleRuntimeError"
ms.assetid: f8f3bbaf-09e5-4d01-8a35-f380bc7ff8ed
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::HandleRuntimeError
Causes the current thread to block and sends a notification of the error to the debugger IDE.  
  
## Syntax  
  
```cpp
HRESULT HandleRuntimeError(  
   IActiveScriptErrorDebug*  pErrorDebug,  
   IActiveScriptSite*        pScriptSite,  
   BREAKRESUMEACTION*        pbra,  
   ERRORRESUMEACTION*        perra,  
   BOOL*                     pfCallOnScriptError  
);  
```  
  
#### Parameters  
 `pErrorDebug`  
 [in] The error that occurred.  
  
 `pScriptSite`  
 [in] The script site of the thread.  
  
 `pbra`  
 [out] Action to take when the debugger resumes the application.  
  
 `perra`  
 [out] Action to take when the debugger resumes the application if there is an error.  
  
 `pfCallOnScriptError`  
 [out] Flag which is `TRUE` if the engine should call the `IActiveScriptSite::OnScriptError` method.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A language engine calls this method in the context of a thread that causes a run-time error. This method causes the current thread to block and sends an error notification to be sent to the debugger IDE. When the debugger IDE resumes the application, this method returns with the action to be taken.  
  
> [!NOTE]
> While in the run-time fault, the language engine may be called by the thread to do such tasks as enumerate stack frames or evaluate expressions.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IActiveScriptErrorDebug Interface](../../winscript/reference/iactivescripterrordebug-interface.md)   
 [IActiveScriptSite](../../winscript/reference/iactivescriptsite.md)   
 [BREAKRESUMEACTION Enumeration](../../winscript/reference/breakresumeaction-enumeration.md)   
 [ERRORRESUMEACTION Enumeration](../../winscript/reference/errorresumeaction-enumeration.md)