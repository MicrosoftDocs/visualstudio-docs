---
title: "JS_NATIVE_FRAME Structure | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "JS_NATIVE_FRAME"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 5afa2ee1-b3e2-47cb-b304-84f96e6fbb14
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JS_NATIVE_FRAME Structure
Represents a stack frame.  
  
## Syntax  
  
```cpp
typedef struct {  
    UINT64 InstructionOffset;    UINT64 ReturnOffset;    UINT64 FrameOffset;    UINT64 StackOffset;  
} JS_NATIVE_FRAME;  
```  
  
## Members  
 `InstructionOffset`  
 The instruction pointer.  
  
 `ReturnOffset`  
 The return address.  
  
 `FrameOffset`  
 The frame pointer.  
  
 `StackOffset`  
 The stack pointer.  
  
## Remarks  
 The `JS_NATIVE_FRAME` struct is used by `IJsStackFrameEnumerator`.  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)