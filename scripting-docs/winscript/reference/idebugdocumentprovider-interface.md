---
title: "IDebugDocumentProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugDocumentProvider interface"
ms.assetid: 36510acf-1ef9-479c-a430-d3f09502f82c
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentProvider Interface
Provides the means for instantiating a document on demand.  
  
## Remarks  
 This indirect means for instantiating a document:  
  
- Allows the document to load when it is needed.  
  
- Allows the document object to be contained within the debugger IDE.  
  
- Allows multiple ways to access the same document object.  
  
  This effectively separates the document from its provider and allows the provider to carry additional run-time, context information.  
  
  In addition to the methods inherited from `IDebugDocumentInfo`, the `IDebugDocumentProvider` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugDocumentProvider::GetDocument](../../winscript/reference/idebugdocumentprovider-getdocument.md)|Causes the document to be instantiated if it does not already exist.|