---
title: "IDebugActivateDocumentEvent2::GetDocument"
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
  - "IDebugActivateDocumentEvent2::GetDocument"
helpviewer_keywords: 
  - "GetDocument method"
  - "IDebugActivateDocumentEvent2::GetDocument method"
ms.assetid: b3c32f1b-f3de-409d-920d-ba7b3fa84fcd
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
# IDebugActivateDocumentEvent2::GetDocument
Gets the document to activate.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocument (   
   IDebugDocument2** ppDoc  
);  
```  
  
```c#  
int GetDocument (   
   out IDebugDocument2 ppDoc  
);  
```  
  
#### Parameters  
 `ppDoc`  
 [out] Returns an [IDebugDocument2](../extensibility/idebugdocument2.md) object that represents the document to be activated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugActivateDocumentEvent2](../extensibility/idebugactivatedocumentevent2.md)   
 [IDebugDocument2](../extensibility/idebugdocument2.md)