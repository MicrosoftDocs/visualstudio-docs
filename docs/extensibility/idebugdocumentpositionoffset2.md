---
title: "IDebugDocumentPositionOffset2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugDocumentPositionOffset2 interface"
ms.assetid: f1b05db3-50d8-453f-a72f-e68b239236a4
caps.latest.revision: 7
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
# IDebugDocumentPositionOffset2
Represents a position in a source file as a character offset.  
  
## Syntax  
  
```  
IDebugDocumentPositionOffset2 : IUnknown  
```  
  
## Notes for Implementers  
 Implemented by the IDE and consumed by debug engines.  
  
## Methods  
 The following table shows the methods of `IDebugDocumentPositionOffset2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetRange](../extensibility/idebugdocumentpositionoffset2--getrange.md)|Retrieves the range for the current document position.|  
  
## Remarks  
 This returns the same information as [GetRange](../extensibility/idebugdocumentposition2--getrange.md) but in `char` offsets from the beginning of the document. This presents the document like it would exist on a disk, that is, a one-dimensional array of characters, instead of the line and column information that is ordinarily returned.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugDocumentPosition2](../extensibility/idebugdocumentposition2.md)