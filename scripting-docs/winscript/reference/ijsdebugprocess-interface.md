---
title: "IJsDebugProcess Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: a7ad5525-55b7-4c68-a4f7-c508f7877712
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProcess Interface
Provides routines for inspecting and controlling the target process.  
  
## Syntax  
  
```cpp
IJsDebugProcess : public IUnknown;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IJsDebugProcess::CreateBreakPoint Method](../../winscript/reference/ijsdebugprocess-createbreakpoint-method.md)|Sets the breakpoint at the specified document position.|  
|[IJsDebugProcess::CreateStackWalker Method](../../winscript/reference/ijsdebugprocess-createstackwalker-method.md)|Factory method for stack walker.|  
|[IJsDebugProcess::PerformAsyncBreak Method](../../winscript/reference/ijsdebugprocess-performasyncbreak-method.md)|Puts the script engine in break mode causing it to break on the next script instruction.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)