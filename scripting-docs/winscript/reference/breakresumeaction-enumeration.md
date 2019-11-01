---
title: "BREAKRESUMEACTION Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "BREAKRESUMEACTION"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "BREAKRESUMEACTION enumeration"
ms.assetid: b39fcc82-7776-4caa-8155-b398de68df03
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# BREAKRESUMEACTION Enumeration
Describes ways to continue from a breakpoint.  
  
## Syntax  
  
```cpp
typedef enum tagBREAKRESUME_ACTION {  
   BREAKRESUMEACTION_ABORT,  
   BREAKRESUMEACTION_CONTINUE,  
   BREAKRESUMEACTION_STEP_INTO,  
   BREAKRESUMEACTION_STEP_OVER,  
   BREAKRESUMEACTION_STEP_OUT,  
   BREAKRESUMEACTION_IGNORE,  
   BREAKRESUMEACTION_STEP_DOCUMENT,  
} BREAKRESUMEACTION;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|BREAKRESUMEACTION_ABORT|Aborts the application.|  
|BREAKRESUMEACTION_CONTINUE|Continues running.|  
|BREAKRESUMEACTION_STEP_INTO|Steps into a procedure.|  
|BREAKRESUMEACTION_STEP_OVER|Steps over a procedure.|  
|BREAKRESUMEACTION_STEP_OUT|Steps out of the current procedure.|  
|BREAKRESUMEACTION_IGNORE|Continues running with state.|  
|BREAKRESUMEACTION_STEP_DOCUMENT|Steps to the next document.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)