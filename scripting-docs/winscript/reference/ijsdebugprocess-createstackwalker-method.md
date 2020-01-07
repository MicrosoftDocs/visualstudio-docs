---
title: "IJsDebugProcess::CreateStackWalker Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugProcess.CreateStackWalker"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 9d02e21d-7900-4942-8d17-cd04a2261463
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugProcess::CreateStackWalker Method
Factory method for stack walker.  
  
## Syntax  
  
```cpp
HRESULT CreateStackWalker(  
   DWORD threadId,  
   IJsDebugStackWalker **ppStackWalker  
);  
```  
  
#### Parameters  
 `threadId`  
 [in] The thread ID.  
  
 `ppStackWalker`  
 [out] The new stack walker object.  
  
## Return Value  
  
## Remarks  
 Returns E_JsDEBUG_UNKNOWN_THREAD if the thread does not have JavaScript on it. This method may only be called while the target process is stopped.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugProcess Interface](../../winscript/reference/ijsdebugprocess-interface.md)