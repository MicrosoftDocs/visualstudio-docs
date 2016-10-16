---
title: "IDebugProgramPublisher2::SetDebuggerPresent"
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
  - "IDebugProgramPublisher2::SetDebuggerPresent"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::SetDebuggerPresent"
ms.assetid: c88c3ff4-3632-4199-b5de-83c6d21bcf75
caps.latest.revision: 7
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
# IDebugProgramPublisher2::SetDebuggerPresent
Tells the program publisher that a debugger is present and running.  
  
## Syntax  
  
```cpp  
HRESULT SetDebuggerPresent(  
   BOOL fDebuggerPresent  
);  
```  
  
```c#  
int SetDebuggerPresent(  
   int fDebuggerPresent  
);  
```  
  
#### Parameters  
 `fDebuggerPresent`  
 [in] Non-zero (`TRUE`) if a debugger is present, zero (`FALSE`) if it is not.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The presence or absence of a debugger is reflected in the data returned from the [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md) method: the value returned there is set or cleared by a prior call to the `SetDebuggerPresent` method.  
  
## See Also  
 [IDebugProgramPublisher2](../extensibility/idebugprogrampublisher2.md)   
 [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md)