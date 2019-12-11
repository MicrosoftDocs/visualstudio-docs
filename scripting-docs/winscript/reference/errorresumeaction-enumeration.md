---
title: "ERRORRESUMEACTION Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ERRORRESUMEACTION"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "ERRORRESUMEACTION enumeration"
ms.assetid: a68293c8-056b-439f-83e7-69e4a38f4976
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ERRORRESUMEACTION Enumeration
Describes how to continue from a runtime error.  
  
## Syntax  
  
```cpp
typedef enum tagERRORRESUMEACTION {  
   ERRORRESUMEACTION_ReexecuteErrorStatement,  
   ERRORRESUMEACTION_AbortCallAndReturnErrorToCaller,  
   ERRORRESUMEACTION_SkipErrorStatement,  
} ERRORRESUMEACTION;  
```  
  
## Members  
  
|Member|Description|  
|------------|-----------------|  
|ERRORRESUMEACTION_ReexecuteErrorStatement|Re-executes the statement that produced the error.|  
|ERRORRESUMEACTION_AbortCallAndReturnErrorToCaller|Lets the language engine handle the error.|  
|ERRORRESUMEACTION_SkipErrorStatement|Resumes execution in the code following the statement that produced the error.|  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)