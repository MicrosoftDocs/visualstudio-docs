---
title: "IDebugProgram2::CauseBreak | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProgram2::CauseBreak"
helpviewer_keywords: 
  - "IDebugProgram2::CauseBreak"
ms.assetid: 07d353fc-68ab-4297-a18f-3d3c7a80e121
caps.latest.revision: 8
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
# IDebugProgram2::CauseBreak
Requests that the program stop execution the next time one of its threads attempts to run.  
  
## Syntax  
  
```cpp#  
HRESULT CauseBreak(   
   void   
);  
```  
  
```c#  
int CauseBreak();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 An [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event is sent when the program next attempts to run code after this method is called.  
  
 This method is asynchronous in that the method returns immediately without necessarily waiting for the program to stop.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)   
 [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md)