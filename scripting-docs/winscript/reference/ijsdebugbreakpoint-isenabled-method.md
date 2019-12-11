---
title: "IJsDebugBreakPoint::IsEnabled Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJSDebugBreakPoint.IsEnabled"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 39b63f49-2a0d-41b7-a2ba-75dcb06251a9
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugBreakPoint::IsEnabled Method
Determines if the breakpoint is enabled.  
  
## Syntax  
  
```cpp
HRESULT IsEnabled(  
   BOOL *pIsEnabled  
);  
```  
  
#### Parameters  
 `pIsEnabled`  
 [out] Returns true if the breakpoint is enabled; otherwise, returns false.  
  
## Return Value  
  
## Remarks  
 Returns E_UNEXPECTED if called on a deleted breakpoint.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugBreakPoint Interface](../../winscript/reference/ijsdebugbreakpoint-interface.md)