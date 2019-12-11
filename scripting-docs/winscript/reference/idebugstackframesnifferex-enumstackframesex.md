---
title: "IDebugStackFrameSnifferEx::EnumStackFramesEx | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrameSnifferEx.EnumStackFramesEx"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrameSnifferEx::EnumStackFramesEx"
ms.assetid: b656b581-aff0-4984-8d8a-a1c7a8e6558a
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrameSnifferEx::EnumStackFramesEx
Returns an enumerator of stack frames for the current thread.  
  
## Syntax  
  
```cpp
HRESULT EnumStackFramesEx(  
   DWORD_PTR                dwSpMin,  
   IEnumDebugStackFrames**  ppedsf  
);  
```  
  
#### Parameters  
 `dwSpMin`  
 [in] The lower address limit for enumerating stack frames.  
  
 `ppedsf`  
 [out] Enumerator of stack frames for the current thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The stack frame enumerator returns the frames starting at the top of the stack, with the most recently pushed frame. The enumerator contains only stack frames with addresses greater than or equal to `dwSpMin`.  
  
## See also  
 [IDebugStackFrameSnifferEx Interface](../../winscript/reference/idebugstackframesnifferex-interface.md)