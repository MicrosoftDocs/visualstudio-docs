---
title: "IDebugDocumentTextEvents2::onDestroy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnDestroy"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onDestroy"
ms.assetid: 60e4689c-c899-4c14-9d18-96393b741e1f
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentTextEvents2::onDestroy
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Indicates that the entire document has been destroyed.  
  
## Syntax  
  
```cpp#  
HRESULT onDestroy(   
   void   
);  
```  
  
```csharp  
int onDestroy();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
