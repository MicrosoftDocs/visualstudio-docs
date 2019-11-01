---
title: "IJsDebugBreakPoint::Disable Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJSDebugBreakPoint.Disable"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: f6f2889c-c001-4ee5-8e3f-4f36235e4fad
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugBreakPoint::Disable Method
Disables the breakpoint.  
  
## Syntax  
  
```cpp
HRESULT Disable(void);  
```  
  
## Return Value  
  
## Remarks  
 Returns E_UNEXPECTED if called on a deleted breakpoint. Returns S_FALSE if called on an already disabled breakpoint.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugBreakPoint Interface](../../winscript/reference/ijsdebugbreakpoint-interface.md)