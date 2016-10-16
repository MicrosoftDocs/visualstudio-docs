---
title: "IDebugDocumentContext2"
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
  - "IDebugDocumentContext2"
helpviewer_keywords: 
  - "IDebugDocumentContext2"
ms.assetid: 2a446c71-8100-4c09-a1cc-fd446bd74030
caps.latest.revision: 12
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
# IDebugDocumentContext2
This interface represents a position in a source file document.  
  
## Syntax  
  
```  
IDebugDocumentContext2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for source code level debugging. In addition to a position in source code, this interface supplies methods for comparing contexts and navigating through a source code document.  
  
## Notes for Callers  
 Methods on several interfaces, most typically the [GetDocumentContext](../extensibility/idebugstackframe2--getdocumentcontext.md) and [GetDocumentContext](../extensibility/idebugcodecontext2--getdocumentcontext.md) interfaces, return this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugDocumentContext2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetDocument](../extensibility/idebugdocumentcontext2--getdocument.md)|Gets the document that contains this document context.|  
|[GetName](../extensibility/idebugdocumentcontext2--getname.md)|Gets the displayable name of the document that contains this document context.|  
|[EnumCodeContexts](../extensibility/idebugdocumentcontext2--enumcodecontexts.md)|Retrieves a list of all code contexts associated with this document context.|  
|[GetLanguageInfo](../extensibility/idebugdocumentcontext2--getlanguageinfo.md)|Gets the language associated with this document context.|  
|[GetStatementRange](../extensibility/idebugdocumentcontext2--getstatementrange.md)|Gets the file statement range of this document context.|  
|[GetSourceRange](../extensibility/idebugdocumentcontext2--getsourcerange.md)|Gets the file source range of this document context.|  
|[Compare](../extensibility/idebugdocumentcontext2--compare.md)|Compares this document context to a given array of document contexts.|  
|[Seek](../extensibility/idebugdocumentcontext2--seek.md)|Moves the document context by a given number of statements or lines.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [GetDocumentContext](../extensibility/idebugcanstopevent2--getdocumentcontext.md)   
 [GetDocumentContext](../extensibility/idebugactivatedocumentevent2--getdocumentcontext.md)   
 [GetDocumentContext](../extensibility/idebugstackframe2--getdocumentcontext.md)   
 [GetDocumentContext](../extensibility/idebugcodecontext2--getdocumentcontext.md)