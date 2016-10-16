---
title: "IDebugCanStopEvent2::GetCodeContext"
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
  - "IDebugCanStopEvent2::GetCodeContext"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetCodeContext"
ms.assetid: eecf08b6-f9b7-4358-941b-3a448a92ac62
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
# IDebugCanStopEvent2::GetCodeContext
Gets the code context that describes the location of this event.  
  
## Syntax  
  
```cpp#  
HRESULT GetCodeContext(   
   IDebugCodeContext2** ppCodeContext  
);  
```  
  
```c#  
int GetCodeContext(   
   out IDebugCodeContext2 ppCodeContext  
);  
```  
  
#### Parameters  
 `ppCodeContext`  
 [out] Returns the [IDebugCodeContext2](../extensibility/idebugcodecontext2.md) object that represents the current code location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 For most run-time architectures, a code context can be thought of as an address in a program's execution stream, pointing to a specific instruction.  
  
 To get the document context, which is oriented towards lines of source code, call the [GetDocumentContext](../extensibility/idebugcanstopevent2--getdocumentcontext.md) method.  
  
## See Also  
 [IDebugCanStopEvent2](../extensibility/idebugcanstopevent2.md)   
 [IDebugCodeContext2](../extensibility/idebugcodecontext2.md)   
 [GetDocumentContext](../extensibility/idebugcanstopevent2--getdocumentcontext.md)