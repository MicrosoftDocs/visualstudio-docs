---
title: "IDebugCodeContext::SetBreakPoint | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugCodeContext.SetBreakPoint"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugCodeContext::SetBreakPoint"
ms.assetid: ecd42eae-66fa-40d3-9e47-08b826784108
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugCodeContext::SetBreakPoint
Sets or clears a breakpoint at this code context.  
  
## Syntax  
  
```cpp
HRESULT SetBreakPoint(  
   BREAKPOINT_STATE  bps  
);  
```  
  
#### Parameters  
 `bps`  
 [in] Specifies the breakpoint state for this code context.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method sets or clears a breakpoint at this code context.  
  
## See also  
 [IDebugCodeContext Interface](../../winscript/reference/idebugcodecontext-interface.md)   
 [BREAKPOINT_STATE Enumeration](../../winscript/reference/breakpoint-state-enumeration.md)