---
title: "IDebugApplication::HandleBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugApplication.HandleBreakPoint"
apilocation: 
  - "pdm.dll"
helpviewer_keywords: 
  - "IDebugApplication::HandleBreakPoint"
ms.assetid: 97219bdf-a39a-4e69-81ac-4ca2afe77ce5
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplication::HandleBreakPoint
Causes the current thread to block and sends a notification of the breakpoint to the debugger IDE.  
  
## Syntax  
  
```cpp
HRESULT HandleBreakPoint(  
   BREAKREASON         br,  
   BREAKRESUMEACTION*  pbra  
);  
```  
  
#### Parameters  
 `br`  
 [in] The reason for the break.  
  
 `pbra`  
 [out] Action to take when the debugger resumes the application.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 A language engine calls this method in the context of a thread that hits a breakpoint. This method blocks the current thread and sends a breakpoint notification to the debugger IDE. When the debugger resumes the application, the `pbra` parameter specifies what action to take.  
  
> [!NOTE]
> The language engine may be called by the thread to do tasks such as enumerate stack frames or evaluate expressions during the breakpoint.  
  
 This method causes `IApplicationDebugger::onHandleBreakPoint` to be called.  
  
## See also  
 [IDebugApplication Interface](../../winscript/reference/idebugapplication-interface.md)   
 [IApplicationDebugger::onHandleBreakPoint](../../winscript/reference/iapplicationdebugger-onhandlebreakpoint.md)   
 [BREAKREASON Enumeration](../../winscript/reference/breakreason-enumeration.md)   
 [BREAKRESUMEACTION Enumeration](../../winscript/reference/breakresumeaction-enumeration.md)