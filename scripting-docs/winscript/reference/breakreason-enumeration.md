---
title: "BREAKREASON Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "BREAKREASON"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "BREAKREASON enumeration"
ms.assetid: bde07ede-2f9b-4fa2-affc-f9405683f5f7
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# BREAKREASON Enumeration
Indicates what caused the break.  
  
## Syntax  
  
```cpp
typedef enum tagBREAKREASON {  
   BREAKREASON_STEP,  
   BREAKREASON_BREAKPOINT,  
   BREAKREASON_DEBUGGER_BLOCK,  
   BREAKREASON_HOST_INITIATED,  
   BREAKREASON_LANGUAGE_INITIATED,  
   BREAKREASON_DEBUGGER_HALT,  
   BREAKREASON_ERROR,  
   BREAKREASON_JIT  
} BREAKREASON;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|BREAKREASON_STEP|The language engine is in the stepping mode.|  
|BREAKREASON_BREAKPOINT|The language engine encountered an explicit breakpoint.|  
|BREAKREASON_DEBUGGER_BLOCK|The language engine encountered a debugger block on another thread.|  
|BREAKREASON_HOST_INITIATED|The host requested a break.|  
|BREAKREASON_LANGUAGE_INITIATED|The language engine requested a break.|  
|BREAKREASON_DEBUGGER_HALT|The debugger IDE requested a break.|  
|BREAKREASON_ERROR|An execution error caused the break.|  
|BREAKREASON_JIT|Caused by JIT Debugging startup.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)