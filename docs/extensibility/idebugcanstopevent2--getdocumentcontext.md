---
title: "IDebugCanStopEvent2::GetDocumentContext"
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
  - "IDebugCanStopEvent2::GetDocumentContext"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetDocumentContext"
ms.assetid: 936a6c4e-30c5-4c7e-9ad5-910cc605a4b5
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
# IDebugCanStopEvent2::GetDocumentContext
Gets the document context that describes the location of this event.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocumentContext (   
   IDebugDocumentContext2** ppDocCxt  
);  
```  
  
```c#  
int GetDocumentContext (   
   out IDebugDocumentContext2 ppDocCxt  
);  
```  
  
#### Parameters  
 `ppDocCxt`  
 [out] Returns the [IDebugDocumentContext2](../extensibility/idebugdocumentcontext2.md) interface that represents a position in a source file document corresponding to the current code location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Generally, the document context can be thought of as a position in a source file.  
  
 To get the code context, which is oriented towards code instructions, call the [GetCodeContext](../extensibility/idebugcanstopevent2--getcodecontext.md) method.  
  
## See Also  
 [IDebugCanStopEvent2](../extensibility/idebugcanstopevent2.md)   
 [IDebugDocumentContext2](../extensibility/idebugdocumentcontext2.md)   
 [GetCodeContext](../extensibility/idebugcanstopevent2--getcodecontext.md)