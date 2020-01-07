---
title: "IApplicationDebugger::onHandleBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IApplicationDebugger.onHandleBreakPoint"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IApplicationDebugger::onHandleBreakPoint"
ms.assetid: 31adcecd-d6c1-4222-ab2c-32ec2fefb322
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebugger::onHandleBreakPoint
Handles a breakpoint event.  
  
## Syntax  
  
```cpp
HRESULT onHandleBreakPoint(  
   IRemoteDebugApplicationThread*  prpt,  
   BREAKREASON                     br,  
   IActiveScriptErrorDebug*        pError  
);  
```  
  
#### Parameters  
 `prpt`  
 [in] The thread where the breakpoint occurred.  
  
 `br`  
 [in] The reason for the breakpoint.  
  
 `pError`  
 [in] Runtime error information, provided when the value of `br` is BREAKREASON_ERROR.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method is called when a breakpoint is hit and `IDebugApplication::HandleBreakPoint` is called.  
  
 The application will remain suspended until the debugger IDE calls `IRemoteDebugApplication::ResumeFromBreakPoint`.  
  
## See also  
 [IApplicationDebugger Interface](../../winscript/reference/iapplicationdebugger-interface.md)   
 [IDebugApplication::HandleBreakPoint](../../winscript/reference/idebugapplication-handlebreakpoint.md)   
 [IRemoteDebugApplication::ResumeFromBreakPoint](../../winscript/reference/iremotedebugapplication-resumefrombreakpoint.md)   
 [BREAKREASON Enumeration](../../winscript/reference/breakreason-enumeration.md)