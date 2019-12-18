---
title: "SCRIPTTHREADSTATE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "SCRIPTTHREADSTATE"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "SCRIPTTHREADSTATE enum"
ms.assetid: 975ec66b-c095-40ac-8ba9-631adb97b589
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SCRIPTTHREADSTATE Enumeration
Specifies the state of a thread in a scripting engine. This enumeration is used by the [IActiveScript::GetScriptThreadState](../../winscript/reference/iactivescript-getscriptthreadstate.md) method.  
  
## Syntax  
  
```cpp
typedef enum tagSCRIPTTHREADSTATE {  
    SCRIPTTHREADSTATE_NOTINSCRIPT  = 0,  
    SCRIPTTHREADSTATE_RUNNING      = 1  
} SCRIPTTHREADSTATE;  
```  
  
## Enumeration Values  
  
|||  
|-|-|  
|SCRIPTTHREADSTATE_NOTINSCRIPT|Specified thread is not currently servicing a scripted event, processing immediately executed script text, or running a script macro.|  
|SCRIPTTHREADSTATE_RUNNING|Specified thread is actively servicing a scripted event, processing immediately executed script text, or running a script macro.|  
  
## See also  
 [Active Script Constants, Enumerations, and Error Codes](../../winscript/reference/active-script-constants-enumerations-and-error-codes.md)