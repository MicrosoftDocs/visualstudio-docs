---
title: "IJsDebugFrame Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 5af46b18-9d25-4a23-b8d1-fa23bea3efcf
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame Interface
Represents a stack frame.  
  
## Syntax  
  
```cpp
IJsDebugFrame : public IUnknown;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IJsDebugFrame::Evaluate Method](../../winscript/reference/ijsdebugframe-evaluate-method.md)|Evaluate an expression in the context of this stack frame.|  
|[IJsDebugFrame::GetDebugProperty Method](../../winscript/reference/ijsdebugframe-getdebugproperty-method.md)|Returns a property browser for this stack frame.|  
|[IJsDebugFrame::GetDocumentPositionWithId Method](../../winscript/reference/ijsdebugframe-getdocumentpositionwithid-method.md)|Returns the current position of this stack frame within the user-level document.|  
|[IJsDebugFrame::GetDocumentPositionWithName Method](../../winscript/reference/ijsdebugframe-getdocumentpositionwithname-method.md)|Returns the current position of this stack frame within the user-level document.|  
|[IJsDebugFrame::GetName Method](../../winscript/reference/ijsdebugframe-getname-method.md)|Gets the user-friendly name of the stack frame.|  
|[IJsDebugFrame::GetReturnAddress Method](../../winscript/reference/ijsdebugframe-getreturnaddress-method.md)|Gets the return address pushed at the 'start' (see GetStackRange) of the frame.|  
|[IJsDebugFrame::GetStackRange Method](../../winscript/reference/ijsdebugframe-getstackrange-method.md)|Returns the absolute address range of the logical JavaScript stack frame.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)