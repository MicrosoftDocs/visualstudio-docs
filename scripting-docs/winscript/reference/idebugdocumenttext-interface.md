---
title: "IDebugDocumentText Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugDocumentText interface"
ms.assetid: 242bad79-9c0a-4a30-879a-9f43db4e022b
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentText Interface
Provides access to a text-only version of the debug document. This interface uses the following conventions:  
  
- Both character positions and line numbers are zero based.  
  
- Character-positions represent character offsets; they do not represent byte or word offsets. For Win32, a character-position is a Unicode offset.  
  
  In addition to the methods inherited from `IDebugDocument`, the `IDebugDocumentText` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugDocumentText::GetDocumentAttributes](../../winscript/reference/idebugdocumenttext-getdocumentattributes.md)|Returns the attributes of the document.|  
|[IDebugDocumentText::GetSize](../../winscript/reference/idebugdocumenttext-getsize.md)|Returns the number of lines and number of characters in the document.|  
|[IDebugDocumentText::GetPositionOfLine](../../winscript/reference/idebugdocumenttext-getpositionofline.md)|Returns character-position corresponding to the first character of a line.|  
|[IDebugDocumentText::GetLineOfPosition](../../winscript/reference/idebugdocumenttext-getlineofposition.md)|Returns the line number and, optionally, the character offset within the line that corresponds to the given character-position.|  
|[IDebugDocumentText::GetText](../../winscript/reference/idebugdocumenttext-gettext.md)|Retrieves the characters and/or the character attributes associated with a character-position range.|  
|[IDebugDocumentText::GetPositionOfContext](../../winscript/reference/idebugdocumenttext-getpositionofcontext.md)|Returns the character-position range corresponding to a document context.|  
|[IDebugDocumentText::GetContextOfPosition](../../winscript/reference/idebugdocumenttext-getcontextofposition.md)|Creates a document context object corresponding to the provided character position range.|