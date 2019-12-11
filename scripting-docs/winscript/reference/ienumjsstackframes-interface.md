---
title: "IEnumJsStackFrames Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 49e7b425-df17-4d7f-87ff-0bc82715c911
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IEnumJsStackFrames Interface
Implemented by the debugger to provide stack unwind to jscript9diag.dll for JavaScript.  
  
## Syntax  
  
```cpp
IEnumJsStackFrames : public IUnknown;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IEnumJsStackFrames::Next Method](../../winscript/reference/ienumjsstackframes-next-method.md)|Gets the specified number of frames.|  
|[IEnumJsStackFrames::Reset Method](../../winscript/reference/ienumjsstackframes-reset-method.md)|Resets the stack frame to the position before the first element.|  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [Windows Script Interfaces Reference](../../winscript/reference/windows-script-interfaces-reference.md)