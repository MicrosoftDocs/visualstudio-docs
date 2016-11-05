---
title: "IDebugDocumentTextEvents2::onDestroy | Microsoft Docs"
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
  - "IDebugDocumentTextEvents2::OnDestroy"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onDestroy"
ms.assetid: 60e4689c-c899-4c14-9d18-96393b741e1f
caps.latest.revision: 8
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
# IDebugDocumentTextEvents2::onDestroy
Indicates that the entire document has been destroyed.  
  
## Syntax  
  
```cpp#  
HRESULT onDestroy(   
   void   
);  
```  
  
```c#  
int onDestroy();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)