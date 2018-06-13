---
title: "IDebugDocumentTextEvents2::onDestroy | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: 
  - "vs-ide-sdk"
ms.topic: "conceptual"
f1_keywords: 
  - "IDebugDocumentTextEvents2::OnDestroy"
helpviewer_keywords: 
  - "IDebugDocumentTextEvents2::onDestroy"
ms.assetid: 60e4689c-c899-4c14-9d18-96393b741e1f
author: "gregvanl"
ms.author: "gregvanl"
manager: douge
ms.workload: 
  - "vssdk"
---
# IDebugDocumentTextEvents2::onDestroy
Indicates that the entire document has been destroyed.  
  
## Syntax  
  
```cpp  
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