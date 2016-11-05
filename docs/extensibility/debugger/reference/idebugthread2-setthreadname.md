---
title: "IDebugThread2::SetThreadName | Microsoft Docs"
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
  - "IDebugThread2::SetThreadName"
helpviewer_keywords: 
  - "IDebugThread2::SetThreadName"
ms.assetid: fa934121-3f58-44dc-9c30-d3f752e44c8b
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
# IDebugThread2::SetThreadName
Sets the name of the thread.  
  
## Syntax  
  
```cpp#  
HRESULT SetThreadName (   
   LPCOLESTR pszName  
);  
```  
  
```c#  
int SetThreadName (   
   string pszName  
);  
```  
  
#### Parameters  
 `pszName`  
 [in] The name of the thread.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To get the thread name, call the [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md) method.  
  
## See Also  
 [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)   
 [GetName](../../../extensibility/debugger/reference/idebugthread2-getname.md)