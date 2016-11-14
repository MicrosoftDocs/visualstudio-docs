---
title: "IDebugProcess2::CauseBreak | Microsoft Docs"
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
  - "IDebugProcess2::CauseBreak"
helpviewer_keywords: 
  - "IDebugProcess2::CauseBreak"
ms.assetid: efda8865-2319-4d53-90bf-6d9d74cd5195
caps.latest.revision: 10
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
# IDebugProcess2::CauseBreak
Requests that the next program that is running code in this process halt and send an [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event object.  
  
## Syntax  
  
```cpp#  
HRESULT CauseBreak(   
   void  
);  
```  
  
```c#  
int CauseBreak();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)