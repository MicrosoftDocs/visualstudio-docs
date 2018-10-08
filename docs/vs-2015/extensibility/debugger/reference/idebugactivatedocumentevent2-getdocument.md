---
title: "IDebugActivateDocumentEvent2::GetDocument | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugActivateDocumentEvent2::GetDocument"
helpviewer_keywords: 
  - "GetDocument method"
  - "IDebugActivateDocumentEvent2::GetDocument method"
ms.assetid: b3c32f1b-f3de-409d-920d-ba7b3fa84fcd
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugActivateDocumentEvent2::GetDocument
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugActivateDocumentEvent2::GetDocument](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugactivatedocumentevent2-getdocument).  
  
Gets the document to activate.  
  
## Syntax  
  
```cpp#  
HRESULT GetDocument (   
   IDebugDocument2** ppDoc  
);  
```  
  
```csharp  
int GetDocument (   
   out IDebugDocument2 ppDoc  
);  
```  
  
#### Parameters  
 `ppDoc`  
 [out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the document to be activated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugActivateDocumentEvent2](../../../extensibility/debugger/reference/idebugactivatedocumentevent2.md)   
 [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)

