---
title: "DOCCONTEXT_COMPARE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "DOCCONTEXT_COMPARE"
helpviewer_keywords: 
  - "DOCCONTEXT_COMPARE enumeration"
ms.assetid: ed947c34-b07e-4b69-8381-b6e7cb842862
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# DOCCONTEXT_COMPARE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the criteria for comparing two document contexts.  
  
## Syntax  
  
```cpp#  
enum enum_DOCCONTEXT_COMPARE {   
   DOCCONTEXT_EQUAL         = 0x0001,  
   DOCCONTEXT_LESS_THAN     = 0x0002,  
   DOCCONTEXT_GREATER_THAN  = 0x0003,  
   DOCCONTEXT_SAME_DOCUMENT = 0x0004  
};  
typedef DWORD DOCCONTEXT_COMPARE;  
```  
  
```csharp  
enum enum_DOCCONTEXT_COMPARE {   
   DOCCONTEXT_EQUAL         = 0x0001,  
   DOCCONTEXT_LESS_THAN     = 0x0002,  
   DOCCONTEXT_GREATER_THAN  = 0x0003,  
   DOCCONTEXT_SAME_DOCUMENT = 0x0004  
};  
```  
  
## Members  
 DOCCONTEXT_EQUAL  
 Find the first document context in the list that is equal to the target document context.  
  
 DOCCONTEXT_LESS_THAN  
 Find the first document context in the list that is less than the target document context.  
  
 DOCCONTEXT_GREATER_THAN  
 Find the first document context in the list that is greater than the target document context.  
  
 DOCCONTEXT_SAME_DOCUMENT  
 Find the first document context in the list that is in the same document as the target document context.  
  
## Remarks  
 Passed as an argument to the [Compare](../../../extensibility/debugger/reference/idebugdocumentcontext2-compare.md) method.  
  
 These values are used to specify a comparison criteria for finding the first document context in a list. A document context is given a list of document contexts to compare itself against through the `IDebugDocumentContext2::Compare` method. The first document context in the list for which the comparison operator is `true` is then returned.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [Compare](../../../extensibility/debugger/reference/idebugdocumentcontext2-compare.md)
