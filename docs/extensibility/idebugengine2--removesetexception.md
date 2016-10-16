---
title: "IDebugEngine2::RemoveSetException"
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
  - "IDebugEngine2::RemoveSetException"
helpviewer_keywords: 
  - "IDebugEngine2::RemoveSetException"
ms.assetid: bdd25097-0e9d-4218-b417-0497ea48d2e8
caps.latest.revision: 11
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
# IDebugEngine2::RemoveSetException
Removes the specified exception so it is no longer handled by the debug engine.  
  
## Syntax  
  
```cpp#  
HRESULT RemoveSetException(   
   EXCEPTION_INFO* pException  
);  
```  
  
```c#  
int RemoveSetException(   
   EXCEPTION_INFO[] pException  
);  
```  
  
#### Parameters  
 `pException`  
 [in] An [EXCEPTION_INFO](../extensibility/exception_info.md) structure that describes the exception to be removed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The exception being removed must have been previously set by an earlier call to the [SetException](../extensibility/idebugengine2--setexception.md) method.  
  
 To remove all set exceptions at once, call the [RemoveAllSetExceptions](../extensibility/idebugengine2--removeallsetexceptions.md) method.  
  
## See Also  
 [IDebugEngine2](../extensibility/idebugengine2.md)   
 [EXCEPTION_INFO](../extensibility/exception_info.md)