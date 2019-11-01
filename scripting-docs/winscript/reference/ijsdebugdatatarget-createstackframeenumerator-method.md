---
title: "IJsDebugDataTarget::CreateStackFrameEnumerator Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJsDebugDataTarget.CreateStackFrameEnumerator"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: cda172e5-18d0-43c5-81d8-432ab30ee70d
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebugDataTarget::CreateStackFrameEnumerator Method
Creates an enumerator for stack frames.  
  
## Syntax  
  
```cpp
HRESULT CreateStackFrameEnumerator(  
   DWORD threadId,  
   IEnumJsStackFrames **ppEnumerator  
);  
```  
  
#### Parameters  
 `threadId`  
 [in] Thread running in the target process.  
  
 `ppEnumerator`  
 [out] The enumerator for stack frames.  
  
## Return Value  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebugDataTarget Interface](../../winscript/reference/ijsdebugdatatarget-interface.md)