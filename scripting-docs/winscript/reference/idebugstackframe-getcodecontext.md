---
title: "IDebugStackFrame::GetCodeContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrame.GetCodeContext"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrame::GetCodeContext"
ms.assetid: 3dd378f3-e4b7-413e-8812-0f6c72952544
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrame::GetCodeContext
Returns the current code context associated with the stack frame.  
  
## Syntax  
  
```cpp
HRESULT GetCodeContext(  
   IDebugCodeContext**  ppcc  
);  
```  
  
#### Parameters  
 `ppcc`  
 [out] The code context associated with the stack frame.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method returns the current code context associated with the stack frame.  
  
## See also  
 [IDebugStackFrame Interface](../../winscript/reference/idebugstackframe-interface.md)