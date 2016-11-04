---
title: "IDebugProcess2::EnumThreads | Microsoft Docs"
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
  - "IDebugProcess2::EnumThreads"
helpviewer_keywords: 
  - "IDebugProcess2::EnumThreads"
ms.assetid: 05677385-7a7f-4545-8438-af00dde85db0
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
# IDebugProcess2::EnumThreads
Retrieves a list of all the threads running in the process.  
  
## Syntax  
  
```cpp#  
HRESULT EnumThreads(  
   IEnumDebugThreads2** ppEnum  
);  
```  
  
```c#  
int EnumThreads(  
   out IEnumDebugThreads2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md) object that contains a list of all threads in all programs in the process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method enumerates the threads running in each program and then combines them into a process view of the threads. A single thread may run in multiple programs; this method enumerates that thread only once.  
  
 This method presents a list of the process's threads without duplicates. Otherwise, to enumerate the threads running in a particular program, use the [EnumThreads](../../../extensibility/debugger/reference/idebugprogram2-enumthreads.md) method.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md)   
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)   
 [EnumThreads](../../../extensibility/debugger/reference/idebugprogram2-enumthreads.md)