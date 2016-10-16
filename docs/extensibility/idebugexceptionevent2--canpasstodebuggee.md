---
title: "IDebugExceptionEvent2::CanPassToDebuggee"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugExceptionEvent2::CanPassToDebuggee"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::CanPassToDebuggee"
ms.assetid: ae4bbe0a-fbe1-49be-a310-ea64279a434b
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugExceptionEvent2::CanPassToDebuggee
Determines whether or not the debug engine (DE) supports the option of passing this exception to the program being debugged when execution resumes.  
  
## Syntax  
  
```cpp#  
HRESULT CanPassToDebuggee(  
   void  
);  
```  
  
```c#  
int CanPassToDebuggee();  
```  
  
## Return Value  
 Returns either `S_OK` (the exception can be passed to the program) or `S_FALSE` (the exception cannot be passed on).  
  
## Remarks  
 The DE must have a default action for passing to the debuggee. The IDE may receive the [IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md) event and call the [Continue](../extensibility/idebugprocess3--continue.md) method without calling the `CanPassToDebuggee` method. Therefore, the DE should have a default case for passing the exception on or not.  
  
## See Also  
 [IDebugExceptionEvent2](../extensibility/idebugexceptionevent2.md)   
 [Continue](../extensibility/idebugprocess3--continue.md)