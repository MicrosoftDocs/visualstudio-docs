---
title: "IDebugCanStopEvent2::GetDocumentContext | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCanStopEvent2::GetDocumentContext"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetDocumentContext"
ms.assetid: 936a6c4e-30c5-4c7e-9ad5-910cc605a4b5
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugCanStopEvent2::GetDocumentContext
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the document context that describes the location of this event.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocumentContext (   
   IDebugDocumentContext2** ppDocCxt  
);  
```  
  
```csharp  
int GetDocumentContext (   
   out IDebugDocumentContext2 ppDocCxt  
);  
```  
  
#### Parameters  
 `ppDocCxt`  
 [out] Returns the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface that represents a position in a source file document corresponding to the current code location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Generally, the document context can be thought of as a position in a source file.  
  
 To get the code context, which is oriented towards code instructions, call the [GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md) method.  
  
## See Also  
 [IDebugCanStopEvent2](../../../extensibility/debugger/reference/idebugcanstopevent2.md)   
 [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)   
 [GetCodeContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getcodecontext.md)
