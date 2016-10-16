---
title: "IDebugProgramPublisher2::UnpublishProgram"
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
  - "IDebugProgramPublisher2::UnpublishProgram"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::UnpublishProgram"
ms.assetid: 627e7d38-b2ac-4873-9a40-37ff7f47cd1d
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
# IDebugProgramPublisher2::UnpublishProgram
Makes a program unavailable to be debugged.  
  
## Syntax  
  
```cpp  
HRESULT UnpublishProgram(  
   IUnknown* pDebuggeeInterface  
);  
```  
  
```c#  
int UnpublishProgram(  
   object pDebuggeeInterface  
);  
```  
  
#### Parameters  
 `pDebuggeeInterface`  
 [in] An `IUnknown` interface to the program. This is the same value supplied to the [PublishProgram](../extensibility/idebugprogrampublisher2--publishprogram.md) method and uniquely identifies the program being removed (that is, it is used as a cookie).  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To make a program available to the debug engines and session debug manager, use the [PublishProgram](../extensibility/idebugprogrampublisher2--publishprogram.md) method.  
  
## See Also  
 [IDebugProgramPublisher2](../extensibility/idebugprogrampublisher2.md)   
 [PublishProgram](../extensibility/idebugprogrampublisher2--publishprogram.md)