---
title: "IJsDebugStackWalker Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 3fe30394-49c8-48e9-bde9-ffe5d79b2121
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugStackWalker Interface
Represents a stack walker for a specified thread.  
  
## Syntax  
  
```cpp
IJsDebugStackWalker : public IUnknown;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IJsDebugStackWalker::GetNext Method](../../winscript/reference/ijsdebugstackwalker-getnext-method.md)|Gets the next frame.|  
  
## Remarks  
 Stack walkers can only be created while the target is stopped, and are invalid once the target process has been continued again.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)