---
title: "IDebugEngine2::RemoveAllSetExceptions"
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
  - "IDebugEngine2::RemoveAllSetExceptions"
helpviewer_keywords: 
  - "IDebugEngine2::RemoveAllSetExceptions"
ms.assetid: 165fbe89-802d-4d99-85ca-c10fd6cccc09
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
# IDebugEngine2::RemoveAllSetExceptions
Removes the list of exceptions the IDE has set for a particular run-time architecture or language.  
  
## Syntax  
  
```cpp#  
HRESULT RemoveAllSetExceptions(   
   REFGUID guidType  
);  
```  
  
```c#  
int RemoveAllSetExceptions(   
   ref Guid guidType  
);  
```  
  
#### Parameters  
 `guidType`  
 [in] Either the GUID for the language or the GUID for the debug engine that is specific to a run-time architecture.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The exceptions removed by this method were set by earlier calls to the [SetException](../extensibility/idebugengine2--setexception.md) method.  
  
 To remove a specific exception, call the [RemoveSetException](../extensibility/idebugengine2--removesetexception.md) method.  
  
## See Also  
 [IDebugEngine2](../extensibility/idebugengine2.md)   
 [IDebugEngine2](../extensibility/idebugengine2.md)   
 [RemoveSetException](../extensibility/idebugengine2--removesetexception.md)