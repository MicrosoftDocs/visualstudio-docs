---
title: "IDebugStackFrameSniffer::EnumStackFrames | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugStackFrameSniffer.EnumStackFrames"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugStackFrameSniffer::EnumStackFrames"
ms.assetid: a7629ab3-ef7d-4bbe-a137-bb2a8ad0f384
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugStackFrameSniffer::EnumStackFrames
Returns an enumerator of stack frames for the current thread.  
  
## Syntax  
  
```cpp
HRESULT EnumStackFrames(  
   IEnumDebugStackFrames**  ppedsf  
);  
```  
  
#### Parameters  
 `ppedsf`  
 [out] Enumerator of stack frames for the current thread.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 The stack frame enumerator returns the frames starting at the top of the stack, starting with the most recently pushed frame.  
  
## See also  
 [IDebugStackFrameSniffer Interface](../../winscript/reference/idebugstackframesniffer-interface.md)