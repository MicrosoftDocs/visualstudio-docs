---
title: "IDebugModule3::SetJustMyCodeState | Microsoft Docs"
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
  - "IDebugModule3::SetJustMyCodeState"
helpviewer_keywords: 
  - "IDebugModule3::SetJustMyCodeState"
ms.assetid: 68f8166d-ef64-49ae-ad5e-79604f43bbd4
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
# IDebugModule3::SetJustMyCodeState
Marks the module as being user code or not.  
  
## Syntax  
  
```cpp#  
HRESULT SetJustMyCodeState(  
   BOOL fIsUserCode  
);  
```  
  
```c#  
int SetJustMyCodeState(  
   int fIsUserCode  
);  
```  
  
#### Parameters  
 `fIsUserCode`  
 [in] Nonzero (`TRUE`) if the module should be considered user code, zero (`FALSE`) if it should not.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)