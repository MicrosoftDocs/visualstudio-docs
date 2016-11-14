---
title: "IDebugPortEx2::CanTerminateProcess | Microsoft Docs"
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
  - "IDebugPortEx2::CanTerminateProcess"
helpviewer_keywords: 
  - "IDebugPortEx2::CanTerminateProcess"
ms.assetid: 111f65d8-5a1a-42b3-9de3-dd9bb03a33fd
caps.latest.revision: 9
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
# IDebugPortEx2::CanTerminateProcess
Determines whether a process can be terminated.  
  
## Syntax  
  
```cpp#  
HRESULT CanTerminateProcess(   
   IDebugProcess2* pPortProcess  
);  
```  
  
```c#  
HRESULT CanTerminateProcess(   
   IDebugProcess2 pPortProcess  
);  
```  
  
#### Parameters  
 `pPortProcess`  
 [in] An [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) object representing the process to be terminated.  
  
## Return Value  
 Returns `S_OK` if the process can be terminated; otherwise, returns `S_FALSE`.  
  
## See Also  
 [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)   
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)