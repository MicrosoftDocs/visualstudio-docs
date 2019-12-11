---
title: "IJsDebugStackWalker::GetNext Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugStackWalker.GetNext"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 0b124768-50d3-4a69-876c-1aa337839a4e
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugStackWalker::GetNext Method
Gets the next frame.  
  
## Syntax  
  
```cpp
HRESULT GetNext(  
   IJsDebugFrame **ppFrame  
);  
```  
  
#### Parameters  
 `ppFrame`  
 [out] Object representing the stack frame.  
  
## Return Value  
  
## Remarks  
 Returns E_JsDEBUG_OUTSIDE_OF_VM when there are no more stack frames to be enumerated  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugStackWalker Interface](../../winscript/reference/ijsdebugstackwalker-interface.md)