---
title: "DebugStackFrameDescriptor Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "DebugStackFrameDescriptor"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "DebugStackFrameDescriptor structure"
ms.assetid: a86bcb99-41e4-4a26-a1dd-e1458fb73139
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DebugStackFrameDescriptor Structure
Enumerates stack frames and merges output from several enumerators on the same thread.  
  
## Syntax  
  
```cpp
typedef struct tagDebugStackFrameDescriptor {  
   IDebugStackFrame *pdsf;  
   DWORD_PTR        dwMin;  
   DWORD_PTR        dwLim;  
   BOOL             fFinal;  
   IUnknown         *punkFinal;  
} DebugStackFrameDescriptor;  
```  
  
## Members  
 `pdsf`  
 The stack frame object.  
  
 `dwMin`  
 A machine-dependent representation of the lower range of physical addresses associated with this stack frame.  
  
 `dwLim`  
 A machine-dependent representation of the upper range of physical addresses associated with this stack frame.  
  
 `fFinal`  
 Flag that indicates that the frame is being processed.  
  
 `punkFinal`  
 If this parameter is not `NULL`, the current enumerator merging should stop and a new one should be started. The object indicates how to start the new enumeration.  
  
## Remarks  
 The process debug manager uses this structure to sort the stack frames from multiple script engines. By convention, stacks grow down. Consequently, on architectures where stacks grow up, the addresses should be twos-complemented.  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)