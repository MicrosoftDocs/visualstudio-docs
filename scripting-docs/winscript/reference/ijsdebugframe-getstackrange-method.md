---
title: "IJsDebugFrame::GetStackRange Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugFrame.GetStackRange"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: a6d1d8be-efc0-442d-9756-1959c8f102bd
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugFrame::GetStackRange Method
Returns the absolute address range of the logical JavaScript stack frame.  
  
## Syntax  
  
```cpp
HRESULT GetStackRange(  
   UINT64 *pStart,  
   UINT64 *pEnd  
);  
```  
  
#### Parameters  
 `pStart`  
 [out] Bottom most stack pointer of the frame.  
  
 `pEnd`  
 [out] Top most stacker pointer of the frame.  
  
## Return Value  
  
## Remarks  
 This method is useful for piecing together interleaved stack traces gathered from multiple runtimes. The start, end stack pointers can encompass multiple physical machine stack frames (for interpreted JavaScript runtime frames). start > end as the stack grows from high to low address.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugFrame Interface](../../winscript/reference/ijsdebugframe-interface.md)