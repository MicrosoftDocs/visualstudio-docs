---
title: "APPBREAKFLAGS Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "APPBREAKFLAGS"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "APPBREAKFLAGS constants"
ms.assetid: ea8ed80f-2ddb-4800-bb3b-52b76ba6c7a0
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# APPBREAKFLAGS Enumeration
Indicate the current debug state for applications and threads.  
  
## Syntax  
  
```cpp  
enum enum_APPBREAKFLAGS{APPBREAKFLAG_DEBUGGER_BLOCK= 0x00000001,APPBREAKFLAG_DEBUGGER_HALT= 0x00000002,APPBREAKFLAG_STEP= 0x00010000,APPBREAKFLAG_NESTED= 0x00020000,APPBREAKFLAG_STEPTYPE_SOURCE= 0x00000000,APPBREAKFLAG_STEPTYPE_BYTECODE= 0x00100000,APPBREAKFLAG_STEPTYPE_MACHINE= 0x00200000,APPBREAKFLAG_STEPTYPE_MASK= 0x00F00000,APPBREAKFLAG_IN_BREAKPOINT= 0x80000000};  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|APPBREAKFLAG_DEBUGGER_BLOCK|0x00000001|Language engine should break immediately on all threads with BREAKREASON_DEBUGGER_BLOCK.|  
|APPBREAKFLAG_DEBUGGER_HALT|0x00000002|Language engine should break immediately with BREAKREASON_DEBUGGER_HALT.|  
|APPBREAKFLAG_STEP|0x00010000|Language engine should break immediately in the stepping thread with BREAKREASON_STEP.|  
|APPBREAKFLAG_NESTED|0x00020000|The application is in nested execution on a breakpoint.|  
|APPBREAKFLAG_STEPTYPE_SOURCE|0x00000000|The debugger is stepping at the source level.|  
|APPBREAKFLAG_STEPTYPE_BYTECODE|0x00100000|The debugger is stepping at the byte code level.|  
|APPBREAKFLAG_STEPTYPE_MACHINE|0x00200000|The debugger is stepping at the machine level.|  
|APPBREAKFLAG_STEPTYPE_MASK|0x00F00000|Mask for factoring out the step types.|  
|APPBREAKFLAG_IN_BREAKPOINT|0x80000000|A breakpoint is in progress.|  
  
## Remarks  
 Some flags specify that language engines should break at the next opportunity, while other flags specify the stepping mode of the debugger.  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)   
 [BREAKREASON Enumeration](../../winscript/reference/breakreason-enumeration.md)