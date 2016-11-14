---
title: "IDebugDocumentText2::GetSize | Microsoft Docs"
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
  - "IDebugDocumentText2::GetSize"
helpviewer_keywords: 
  - "IDebugDocumentText2::GetSize"
ms.assetid: bf515a8f-dcee-4004-8f81-543d547ceaae
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
# IDebugDocumentText2::GetSize
Retrieves the size of the text at this position in the document.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize(   
   ULONG* pcNumLines,  
   ULONG* pcNumChars  
);  
```  
  
```c#  
int GetSize(   
   ref uint pcNumLines,  
   ref uint pcNumChars  
);  
```  
  
#### Parameters  
 `pcNumLines`  
 [out] Returns the number of lines of text.  
  
 `pcNumChars`  
 [out] Returns the number of characters of text.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 [C++ only] If a particular value is not desired, pass a NULL for the parameter.  
  
 [C# only] Both parameters must be specified.  
  
## See Also  
 [IDebugDocumentText2](../../../extensibility/debugger/reference/idebugdocumenttext2.md)